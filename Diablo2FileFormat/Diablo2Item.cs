using Diablo2FileFormat.Sections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo2FileFormat
{
    public class Diablo2Item : IDiablo2FileSection
    {
        private byte HeaderMarkerJ = 0x4A;
        private byte HeaderMarkerM = 0x4D;

        private readonly BitField m_bitData;

        public byte[] Data { get; }
        public bool IsChanged { get; set; }
        public int Size => Data.Length;

        public Diablo2Item()
        {
            Data = new byte[14];
            m_bitData = new BitField(Data);
            Data[0] = HeaderMarkerJ;
            Data[1] = HeaderMarkerM;

            IsIdentified = true;
        }

        // older then Ver114R
        public Diablo2Item(byte[] data, int offset, int size)
        {
            if (size > 0)
            {
                Data = new byte[size];
                Array.Copy(data, offset, Data, 0, size);
            }
            else
            {
                Data = new byte[0];
            }
            m_bitData = new BitField(Data);
        }

        // Ver114R
        public Diablo2Item(byte[] data, int offset)
        {
            var tmp = data.Skip(offset).ToArray();
            var size = parse(tmp, 0);
            if (size.Bytes > 0)
            {
                Data = new byte[size.Bytes];
                Array.Copy(data, offset, Data, 0, size.Bytes);
            }
            else
            {
                Data = new byte[0];
            }
            m_bitData = new BitField(Data);
        }

        public static Diablo2Item Load(string filepath)
        {
            var data = File.ReadAllBytes(filepath);
            return new Diablo2Item(data, 0, data.Length);
        }

        public void Save(string filepath)
        {
            File.WriteAllBytes(filepath, Data);
        }

        public bool IsStored => m_bitData.Read(58, 3) == 0;

        public ItemLocation Location => (ItemLocation)m_bitData.Read(73, 3);

        public uint PositionX => m_bitData.Read(65, 4);
        public uint PositionY => m_bitData.Read(69, 4);

        public string ItemType
        {
            get
            {
                byte[] str = new byte[4];
                str[0] = (byte)m_bitData.Read(76, 8);
                str[1] = (byte)m_bitData.Read(84, 8);
                str[2] = (byte)m_bitData.Read(92, 8);
                str[3] = (byte)m_bitData.Read(100, 8);

                return Encoding.ASCII.GetString(str);
            }
        }

        public bool IsIdentified
        {
            get { return m_bitData.Read(20, 1) == 1; }
            set { m_bitData.Write((uint)(value ? 1 : 0), 20, 1); }
        }

        ItemTypeId GetItemTypeId(string itemTypeStr)
        {
            // todo:
            return ItemTypeId.Other;
        }

        ulong Read(BitField data, ref int pos, int count)
        {
            ulong tmp = data.Read(pos, count); // already reversed
            pos += count;
            return tmp;
        }

        internal class BytesCounter
        {
            internal int Bytes => m_bytes;

            internal int Bits => m_bits;

            internal BytesCounter(int bits)
            {
                m_bits = bits;
                m_bytes = m_bits / 8;
                if ((m_bits % 8) != 0)
                {
                    m_bytes += 1;
                }
            }

            private int m_bits = 0;
            private int m_bytes = 0;

        }

        // https://squeek502.github.io/d2itemreader/formats/d2.html
        BytesCounter parse(byte[] data, int offset)
        {
            var bitData = new BitField(data);
            int pos = 0;
            pos += 4; // ?
            m_Identified = Read(bitData, ref pos, 1) != 0;
            pos += 6; // ?
            m_Socketed = Read(bitData, ref pos, 1) != 0;
            pos += 1; // ?
            m_Unsaved = Read(bitData, ref pos, 1) != 0;
            pos += 2; // ?
            m_Ear = Read(bitData, ref pos, 1) != 0;
            m_Starter = Read(bitData, ref pos, 1) != 0;
            pos += 3; // ?
            m_Simple = Read(bitData, ref pos, 1) != 0;
            m_Ethereal = Read(bitData, ref pos, 1) != 0;
            pos += 1;  // ?
            m_Personalized = Read(bitData, ref pos, 1) != 0;
            pos += 1; // ?
            m_Runeword = Read(bitData, ref pos, 1) != 0;
            pos += 5; // ?
            m_Version = (ItemVersion)Read(bitData, ref pos, 8);
            pos += 2; // ?
            m_Parent = (Parent) Read(bitData, ref pos, 3);
            m_Placement = (Placement) Read(bitData, ref pos, 4);
            m_Column = (int) Read(bitData, ref pos, 4);
            m_Row = (int) Read(bitData, ref pos, 3);
            pos += 1; // ?
            m_Storage = (Storage)Read(bitData, ref pos, 3);

            if(m_Ear)
            {
                m_EarClass = (int) Read(bitData, ref pos, 3);
                m_EarLevel = (int) Read(bitData, ref pos, 7);
                byte[] buf = new byte[64];
                for (int i = 0; i < 64; i++)
                {
                    buf[i] = (byte)Read(bitData, ref pos, 7);
                    if (buf[i] == 0)
                    {
                        break;
                    }
                }
                m_EarOriginName = new byte[buf.Length];
                Array.Copy(buf, m_EarOriginName, buf.Length);
                return new BytesCounter(pos);
            }

            m_ItemType[0] = (byte)Read(bitData, ref pos, 8);
            m_ItemType[1] = (byte)Read(bitData, ref pos, 8);
            m_ItemType[2] = (byte)Read(bitData, ref pos, 8);
            m_ItemType[3] = (byte)Read(bitData, ref pos, 8);
            m_ItemTypeId = GetItemTypeId(Encoding.ASCII.GetString(m_ItemType).Trim(' '));

            m_SocketsFilled = (int) Read(bitData, ref pos, 3);

            if (m_Simple)
            {
                return new BytesCounter(pos);
            }

            m_Id = bitData.Read(111, 32);
            m_Level = (int) bitData.Read(143, 7);
            m_Rarity = (Rarity) bitData.Read(150, 4);

            // nullable data
            pos = 154;
            if(bitData.Read(pos, 1) != 0)
            {
                m_IdxPicture = (int)bitData.Read(pos + 1, 3);
                pos += 3;
            }
            pos++;
            if(bitData.Read(pos, 1) != 0)
            {
                m_IdClassSpecAffix = (int)bitData.Read(pos + 1, 11);
                pos += 11;
            }
            pos++;
            switch(m_Rarity)
            {
                case Rarity.LowQuality:
                    m_IdLowQualityType = (int)bitData.Read(pos, 3);
                    pos += 3;
                    break;
                case Rarity.Superior:
                    m_IdSuperiorType = (int)bitData.Read(pos, 3);
                    pos += 3;
                    break;
                case Rarity.Magic:
                    m_IdMagicPrefix = (int)bitData.Read(pos, 11);
                    pos += 11;
                    m_IdMagicSuffix = (int)bitData.Read(pos, 11);
                    pos += 11;
                    break;
                case Rarity.Set:
                    m_IdSetType = (int)bitData.Read(pos, 12);
                    pos += 12;
                    break;
                case Rarity.Unique:
                    m_IdUniqueType = (int)bitData.Read(pos, 12);
                    pos += 12;
                    break;
                case Rarity.Rare:
                case Rarity.Crafted:
                    m_IdRareName1 = (int)bitData.Read(pos, 8);
                    pos += 8;
                    m_IdRareName2 = (int)bitData.Read(pos, 8);
                    pos += 8;
                    for(int i = 0; i < m_IdRareAffixes.Length; i++)
                    {
                        if(bitData.Read(pos, 1) != 0)
                        {
                            m_IdRareAffixes[i] = (int)bitData.Read(pos + 1, 11);
                            pos += 11;
                        }
                        pos++;
                    }
                    break;
            }
            if(m_Runeword)
            {
                m_IdRunwordName = (int)bitData.Read(pos, 12);
                pos += 12;
                // 4 unknown bits
                pos += 4;
            }
            if(m_Personalized)
            {
                List<byte> chars = new List<byte>();
                while(chars.Count < 100) // unormally big
                {
                    byte c = (byte)bitData.Read(pos, 7);
                    pos += 7;
                    if(c == 0)
                    {
                        m_OwnerName = new byte[chars.Count + 1];
                        for(int i = 0; i < chars.Count; i++)
                        {
                            m_OwnerName[i] = chars.ElementAt(i);
                        }
                        m_OwnerName[chars.Count] = 0;
                        break;
                    }
                    chars.Add(c);
                }
            }
            //if(*is a tom*)
            //{
            //    pos += 5;
            //}
            pos += 1;
            //if(*is an armor*)
            //{
            //    pos += 11;
            //}
            //if(*is an armor or is a weapon*)
            //{
            //    pos += 8;
            //}
            //if(*max durability > 0*)
            //{
            //    pos += 9;
            //}
            //if(*is a stackable weapon*)
            //{
            //    pos += 9;
            //}
            if(m_Socketed)
            {
                m_SocketsTotal = (int)bitData.Read(pos, 4);
                pos += 4;
            }
            if(m_Rarity == Rarity.Set)
            {
                m_SetPropertiesBits = (int) bitData.Read(pos, 5);
                pos += 5;
            }
            // List of magical properties of the item. See Property Lists (https://squeek502.github.io/d2itemreader/formats/d2.html#property-lists)
            if(m_SetPropertiesBits.HasValue && m_SetPropertiesBits.Value != 0)
            {
                // m_SetPropertiesBits.Value & (1 << index) != 0 ==> read set property
            }
            if(m_Runeword)
            {
                // A property list containing the properties of the item that come from the runeword
            }
            return new BytesCounter(pos);
        }

        bool m_Identified = false;
        bool m_Socketed = false;
        bool m_Unsaved = false;
        bool m_Ear = false;
        bool m_Starter = false;
        bool m_Simple = false;
        bool m_Ethereal = false;
        bool m_Personalized = false;
        bool m_Runeword = false;
        ItemVersion m_Version = ItemVersion.NotSet;
        Parent m_Parent = Parent.NotSet;
        Storage m_Storage = Storage.NotSet;
        Placement m_Placement = Placement.NotSet;
        int m_Column = -1;
        int m_Row = -1;
        //byte [] m_TypeCode = new byte[3];
        //
        int? m_EarClass;
        int? m_EarLevel;
        byte[] m_EarOriginName;
        //
        byte[] m_ItemType = new byte[4];
        ItemTypeId? m_ItemTypeId;

        int? m_SocketsFilled;
        int? m_SocketsTotal;
        uint m_Id = 0xFFFF;
        int m_Level = -1;
        Rarity m_Rarity = Rarity.Invalid;
        int? m_IdxPicture;
        int? m_IdClassSpecAffix;
        int? m_IdLowQualityType;
        int? m_IdSuperiorType;
        int? m_IdMagicPrefix;
        int? m_IdMagicSuffix;
        int? m_IdSetType;
        int? m_IdUniqueType;
        int? m_IdRareName1;
        int? m_IdRareName2;
        int?[] m_IdRareAffixes = new int?[6];
        int? m_IdRunwordName;
        byte[] m_OwnerName;
        int? m_SetPropertiesBits;

        enum Parent
        {
            Stored = 0,
            Equipped = 1,
            Belt = 2,
            Ground = 3,
            Cursor = 4,
            Item = 6,
            NotSet = 0xFF
        }

        enum Storage
        {
            Inventory = 1,
            Cube = 4,
            Stash = 5,
            NotSet = 0xFF
        }

        enum Placement
        {
            Helmet = 1,
            Amulet = 2,
            Armor = 3,
            WeaponRight = 4,
            WeaponLeft = 5,
            RingRight = 6,
            RingLeft = 7,
            Belt = 8,
            Boots = 9,
            Gloves = 10,
            AltWeaponRight = 11,
            AltWeaponLeft = 12,
            NotSet = 0xFF
        }

        enum ItemVersion
        {
            Pre108 = 0,
            Classic = 1,
            Expansion = 100,
            Expansion110 = 101,
            NotSet = 0xFFFF
        }

        enum ItemTypeId
        {
            Armor,
            Shield,
            Weapon,
            Other
        }

        enum Rarity
        {
            Invalid = 0,
            LowQuality,
            Normal,
            Superior,
            Magic,
            Set,
            Rare,
            Unique,
            Crafted,
            Tempered
        }
    }
}
