using Diablo2FileFormat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo2FileFormat.Sections
{
    public class ItemListSection : IDiablo2FileSection, IItemList
    {
        private int ItemListHeaderSize = 4;

        private byte HeaderMarkerJ = 0x4A;
        private byte HeaderMarkerM = 0x4D;

        public byte[] Data
        {
            get
            {
                var data = new byte[Size];

                // Item list marker
                data[0] = HeaderMarkerJ;
                data[1] = HeaderMarkerM;

                // Item list size
                Array.Copy(BitConverter.GetBytes((short)m_items.Count), 0, data, 2, 2);

                int offset = ItemListHeaderSize;
                foreach (var item in m_items)
                {
                    Array.Copy(item.Data, 0, data, offset, item.Size);
                    offset += item.Size;
                }

                return data;
            }
        }

        public bool IsChanged { get; set; }

        public int Size => ItemListHeaderSize + m_items.Sum(i => i.Size);

        private readonly List<Diablo2Item> m_items = new List<Diablo2Item>();

        public ItemListSection(byte[] data, int offset, FileVersion version)
        {
            if (data.Length - offset < ItemListHeaderSize)
                throw new Exception("Invalid item list");

            int nbItem = BitConverter.ToUInt16(data, offset + 2);

            offset += ItemListHeaderSize;
            int itemStartOffset = offset;
            if(version != FileVersion.V114R)
            {
                offset += 2; // skip the header and the first item JM marker
            }
            while (offset < data.Length - 1 && m_items.Count < nbItem)
            {
                if (version != FileVersion.V114R)
                {
                    if (data[offset] == HeaderMarkerJ && data[offset + 1] == HeaderMarkerM)
                    {
                        m_items.Add(new Diablo2Item(data, itemStartOffset, offset - itemStartOffset));
                        itemStartOffset = offset;
                    }
                    ++offset;
                }
                else
                {
                    int len = BitConverter.ToUInt16(data, offset);
                    m_items.Add(new Diablo2Item(data, offset, len + 2));
                    offset += len + 2;
                }
            }

            //int size = data.Length - offset;

            //if (size > 0)
            //{
            //    Data = new byte[size];
            //    Array.Copy(data, offset, Data, 0, size);

            //    BuildItemList();
            //}
            //else
            //{
            //    Data = new byte[0];
            //}
        }

        public ushort NumberOfItems
        {
            get
            {
                return (ushort)m_items.Count;
            }
        }

        private void BuildItemList()
        {
            int offset = ItemListHeaderSize + 2; // skip the header as well as the JM marker
            int itemStartOffset = ItemListHeaderSize;
            while (offset < Data.Length - 1)
            {
                if (Data[offset] == HeaderMarkerJ && Data[offset + 1] == HeaderMarkerM)
                {
                    m_items.Add(new Diablo2Item(Data, itemStartOffset, offset - itemStartOffset - 1));
                    itemStartOffset = offset;
                }
                ++offset;
            }
        }

        public List<Diablo2Item> GetItems()
        {
            return m_items;
        }

        public void Add(Diablo2Item item)
        {
            m_items.Add(item);

            IsChanged = true;
        }
    }
}
