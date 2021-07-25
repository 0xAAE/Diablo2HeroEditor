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

		public byte [] Data { get; }
		public bool IsChanged { get; set; }
		public int Size => Data.Length;

		/// <summary>
		///  Minimal data length, version 110:
		///  ear bits: 76 + 10 + 2 * 7 bits (1-letter owner name) = 100 bits
		///  simple item: 111 bits
		///  other items: 111+ bits
		/// </summary>
		private int MinDataLength_V110 => 14; // 111 bits is minimal for non-ear

		///  Minimal data length, version 114R:
		///  (-16 bits, there is no "JM" header)
		///  ear bits: 60 + 10 + 2 * 7 bits (1-letter owner name) = 84 bits
		///  simple item: 95 bits
		///  other items: 95+ bits
		/// </summary>
		private int MinDataLength_V114R => 12; // 95 bits is minimal for non-ear

		public Diablo2Item( FileVersion version )
		{
			if (version == FileVersion.V110)
			{
				Data = new byte [ MinDataLength_V110 ];
				m_bitData = new BitField( Data );
				Data [ 0 ] = HeaderMarkerJ;
				Data [ 1 ] = HeaderMarkerM;
			}
			else
			{
				Data = new byte [ MinDataLength_V114R ];
				m_bitData = new BitField( Data );
			}
			m_bitData = new BitField( Data );
			IsIdentified = true;
		}

		// older then Ver114R
		public Diablo2Item( byte [] data, int offset, int size )
		{
			if (size > 0)
			{
				Data = new byte [ size ];
				Array.Copy( data, offset, Data, 0, size );
			}
			else
			{
				Data = new byte [ 0 ];
			}
			m_bitData = new BitField( Data );
			parse_v110();
		}

		// Ver114R
		public Diablo2Item( byte [] data, int offset )
		{
			var tmp = data.Skip( offset ).ToArray();
			var size = parse( tmp, 0 );
			if (size.Bytes > 0)
			{
				Data = new byte [ size.Bytes ];
				Array.Copy( data, offset, Data, 0, size.Bytes );
			}
			else
			{
				Data = new byte [ 0 ];
			}
			m_bitData = new BitField( Data );
		}

		public static Diablo2Item Load( string filepath )
		{
			var data = File.ReadAllBytes( filepath );
			return new Diablo2Item( data, 0, data.Length );
		}

		public void Save( string filepath )
		{
			File.WriteAllBytes( filepath, Data );
		}

		public bool IsStored => ! m_Unsaved;

		public ItemLocation Location => m_Storage;

		public uint PositionX => (uint) m_Row;
		public uint PositionY => (uint) m_Column;

		public string ItemTypeStr => Encoding.ASCII.GetString( m_ItemType ).Trim( ' ' );

		public ItemType ItemType
		{
			get
			{
				try
				{
					return ItemTypeWiki.ItemTypeString.Single( ( kv ) => kv.Key == ItemTypeStr ).Value;
				}
				catch (ArgumentNullException)
				{
				}
				catch (InvalidOperationException)
				{
				}
				return ItemType.Unknown;
			}
		}

		public bool IsIdentified
		{
			get { return m_Identified; }
			set { m_bitData.Write( (uint) ( value ? 1 : 0 ), 20, 1 ); }
		}

		public ItemKind ItemKind
		{
			get
			{
				var item = ItemType;
				if (item != ItemType.Unknown)
				{
					if (ItemTypeWiki.ArmorName.ContainsKey( item ))
					{
						return ItemKind.Armor;
					}
					if (ItemTypeWiki.ShieldName.ContainsKey( item ))
					{
						return ItemKind.Shield;
					}
					if (ItemTypeWiki.WeaponName.ContainsKey( item ))
					{
						return ItemKind.Weapon;
					}
					if (ItemTypeWiki.MiscName.ContainsKey( item ))
					{
						return ItemKind.Other;
					}
				}
				return ItemKind.Unknown;
			}
		}

		ulong Read( BitField data, ref int pos, int count )
		{
			ulong tmp = data.Read( pos, count ); // already reversed
			pos += count;
			return tmp;
		}

		// https://squeek502.github.io/d2itemreader/formats/d2.html
		void parse_v110()
		{
			if (m_bitData == null)
			{
				return;
			}
			int pos = 0;
			pos += 20; // 'J' + 'M' + ?
			m_Identified = Read( m_bitData, ref pos, 1 ) != 0;
			pos += 6; // ?
			m_Socketed = Read( m_bitData, ref pos, 1 ) != 0;
			pos += 1; // ?
			m_Unsaved = Read( m_bitData, ref pos, 1 ) != 0;
			pos += 2; // ?
			m_Ear = Read( m_bitData, ref pos, 1 ) != 0;
			m_Starter = Read( m_bitData, ref pos, 1 ) != 0;
			pos += 3; // ?
			m_Simple = Read( m_bitData, ref pos, 1 ) != 0;
			m_Ethereal = Read( m_bitData, ref pos, 1 ) != 0;
			pos += 1;  // ?
			m_Personalized = Read( m_bitData, ref pos, 1 ) != 0;
			pos += 1; // ?
			m_Runeword = Read( m_bitData, ref pos, 1 ) != 0;
			pos += 5; // ?
			m_Version = (ItemVersion) Read( m_bitData, ref pos, 8 );
			pos += 2; // ?
			m_Parent = (ItemParent) Read( m_bitData, ref pos, 3 );
			m_Placement = (BodyPlacement) Read( m_bitData, ref pos, 4 );
			m_Column = (int) Read( m_bitData, ref pos, 4 );
			m_Row = (int) Read( m_bitData, ref pos, 3 );
			pos += 1; // ?
			m_Storage = (ItemLocation) Read( m_bitData, ref pos, 3 );

			if (m_Ear)
			{
				m_EarClass = (int) Read( m_bitData, ref pos, 3 );
				m_EarLevel = (int) Read( m_bitData, ref pos, 7 );
				byte [] buf = new byte [ 64 ];
				for (int i = 0; i < 64; i++)
				{
					buf [ i ] = (byte) Read( m_bitData, ref pos, 7 );
					if (buf [ i ] == 0)
					{
						break;
					}
				}
				m_EarOriginName = new byte [ buf.Length ];
				Array.Copy( buf, m_EarOriginName, buf.Length );
				return;
			}

            m_ItemType[0] = (byte)Read(m_bitData, ref pos, 8);
            m_ItemType[1] = (byte)Read(m_bitData, ref pos, 8);
            m_ItemType[2] = (byte)Read(m_bitData, ref pos, 8);
            m_ItemType[3] = (byte)Read(m_bitData, ref pos, 8);

			m_SocketsFilled = (int) Read( m_bitData, ref pos, 3 );

			if (m_Simple)
			{
				return;
			}
			System.Diagnostics.Debug.Assert( pos == 111 );

			m_Id = (uint) Read( m_bitData, ref pos, 32 );
			m_Level = (int) Read( m_bitData, ref pos, 7 );
			m_Rarity = (ItemRarity) Read( m_bitData, ref pos, 4 );

			// nullable data
			if (Read( m_bitData, ref pos, 1 ) != 0)
			{
				m_IdxPicture = (int) Read( m_bitData, ref pos, 3 );
			}
			if (Read( m_bitData, ref pos, 1 ) != 0)
			{
				m_IdClassSpecAffix = (int) Read( m_bitData, ref pos, 11 );
			}
			switch (m_Rarity)
			{
				case ItemRarity.LowQuality:
					m_IdLowQualityType = (int) Read( m_bitData, ref pos, 3 );
					break;
				case ItemRarity.Superior:
					m_IdSuperiorType = (int) Read( m_bitData, ref pos, 3 );
					break;
				case ItemRarity.Magic:
					m_IdMagicPrefix = (int) Read( m_bitData, ref pos, 11 );
					m_IdMagicSuffix = (int) Read( m_bitData, ref pos, 11 );
					break;
				case ItemRarity.Set:
					m_IdSetType = (int) Read( m_bitData, ref pos, 12 );
					break;
				case ItemRarity.Unique:
					m_IdUniqueType = (int) Read( m_bitData, ref pos, 12 );
					break;
				case ItemRarity.Rare:
				case ItemRarity.Crafted:
					m_IdRareName1 = (int) Read( m_bitData, ref pos, 8 );
					m_IdRareName2 = (int) Read( m_bitData, ref pos, 8 );
					for (int i = 0; i < m_IdRareAffixes.Length; i++)
					{
						if (Read( m_bitData, ref pos, 1 ) != 0)
						{
							m_IdRareAffixes [ i ] = (int) Read( m_bitData, ref pos, 11 );
						}
					}
					break;
			}
			if (m_Runeword)
			{
				m_IdRunwordName = (int) Read( m_bitData, ref pos, 12 );
				// 4 unknown bits
				pos += 4;
			}
			if (m_Personalized)
			{
				List<byte> chars = new List<byte>();
				while (chars.Count < 100) // abnormally big
				{
					byte c = (byte) Read( m_bitData, ref pos, 7 );
					if (c == 0)
					{
						m_OwnerName = new byte [ chars.Count + 1 ];
						for (int i = 0; i < chars.Count; i++)
						{
							m_OwnerName [ i ] = chars.ElementAt( i );
						}
						m_OwnerName [ chars.Count ] = 0;
						break;
					}
					chars.Add( c );
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
			if (m_Socketed)
			{
				m_SocketsTotal = (int) Read( m_bitData, ref pos, 4 );
			}
			if (m_Rarity == ItemRarity.Set)
			{
				m_SetPropertiesBits = (int) Read( m_bitData, ref pos, 5 );
			}
			// List of magical properties of the item. See Property Lists (https://squeek502.github.io/d2itemreader/formats/d2.html#property-lists)
			if (m_SetPropertiesBits.HasValue && m_SetPropertiesBits.Value != 0)
			{
				// m_SetPropertiesBits.Value & (1 << index) != 0 ==> read set property
			}
			if (m_Runeword)
			{
				// A property list containing the properties of the item that come from the runeword
			}
		}

		BytesCounter parse( byte [] data, int offset )
		{
			var bitData = new BitField( data );
			int pos = 0;
			pos += 4; // ?
			m_Identified = Read( bitData, ref pos, 1 ) != 0;
			pos += 6; // ?
			m_Socketed = Read( bitData, ref pos, 1 ) != 0;
			pos += 1; // ?
			m_Unsaved = Read( bitData, ref pos, 1 ) != 0;
			pos += 2; // ?
			m_Ear = Read( bitData, ref pos, 1 ) != 0;
			m_Starter = Read( bitData, ref pos, 1 ) != 0;
			pos += 3; // ?
			m_Simple = Read( bitData, ref pos, 1 ) != 0;
			m_Ethereal = Read( bitData, ref pos, 1 ) != 0;
			pos += 1;  // ?
			m_Personalized = Read( bitData, ref pos, 1 ) != 0;
			pos += 1; // ?
			m_Runeword = Read( bitData, ref pos, 1 ) != 0;
			pos += 5; // ?
			m_Version = (ItemVersion) Read( bitData, ref pos, 8 );
			pos += 2; // ?
			m_Parent = (ItemParent) Read( bitData, ref pos, 3 );
			m_Placement = (BodyPlacement) Read( bitData, ref pos, 4 );
			m_Column = (int) Read( bitData, ref pos, 4 );
			m_Row = (int) Read( bitData, ref pos, 3 );
			pos += 1; // ?
			m_Storage = (ItemLocation) Read( bitData, ref pos, 3 );

			if (m_Ear)
			{
				m_EarClass = (int) Read( bitData, ref pos, 3 );
				m_EarLevel = (int) Read( bitData, ref pos, 7 );
				byte [] buf = new byte [ 64 ];
				for (int i = 0; i < 64; i++)
				{
					buf [ i ] = (byte) Read( bitData, ref pos, 7 );
					if (buf [ i ] == 0)
					{
						break;
					}
				}
				m_EarOriginName = new byte [ buf.Length ];
				Array.Copy( buf, m_EarOriginName, buf.Length );
				return new BytesCounter( pos );
			}

			m_ItemType[0] = Huffman.decode(bitData, ref pos);
			m_ItemType[1] = Huffman.decode(bitData, ref pos);
			m_ItemType[2] = Huffman.decode(bitData, ref pos);
			ulong fin = Read(bitData, ref pos, 2);

			m_SocketsFilled = (int) Read( bitData, ref pos, 3 );
			var t = this.ItemType;
			var k = this.ItemKind;

			if (m_Simple)
			{
				return new BytesCounter( pos );
			}

			m_Id = bitData.Read( 111, 32 );
			m_Level = (int) bitData.Read( 143, 7 );
			m_Rarity = (ItemRarity) bitData.Read( 150, 4 );

			// nullable data
			pos = 154;
			if (bitData.Read( pos, 1 ) != 0)
			{
				m_IdxPicture = (int) bitData.Read( pos + 1, 3 );
				pos += 3;
			}
			pos++;
			if (bitData.Read( pos, 1 ) != 0)
			{
				m_IdClassSpecAffix = (int) bitData.Read( pos + 1, 11 );
				pos += 11;
			}
			pos++;
			switch (m_Rarity)
			{
				case ItemRarity.LowQuality:
					m_IdLowQualityType = (int) bitData.Read( pos, 3 );
					pos += 3;
					break;
				case ItemRarity.Superior:
					m_IdSuperiorType = (int) bitData.Read( pos, 3 );
					pos += 3;
					break;
				case ItemRarity.Magic:
					m_IdMagicPrefix = (int) bitData.Read( pos, 11 );
					pos += 11;
					m_IdMagicSuffix = (int) bitData.Read( pos, 11 );
					pos += 11;
					break;
				case ItemRarity.Set:
					m_IdSetType = (int) bitData.Read( pos, 12 );
					pos += 12;
					break;
				case ItemRarity.Unique:
					m_IdUniqueType = (int) bitData.Read( pos, 12 );
					pos += 12;
					break;
				case ItemRarity.Rare:
				case ItemRarity.Crafted:
					m_IdRareName1 = (int) bitData.Read( pos, 8 );
					pos += 8;
					m_IdRareName2 = (int) bitData.Read( pos, 8 );
					pos += 8;
					for (int i = 0; i < m_IdRareAffixes.Length; i++)
					{
						if (bitData.Read( pos, 1 ) != 0)
						{
							m_IdRareAffixes [ i ] = (int) bitData.Read( pos + 1, 11 );
							pos += 11;
						}
						pos++;
					}
					break;
			}
			if (m_Runeword)
			{
				m_IdRunwordName = (int) bitData.Read( pos, 12 );
				pos += 12;
				// 4 unknown bits
				pos += 4;
			}
			if (m_Personalized)
			{
				List<byte> chars = new List<byte>();
				while (chars.Count < 100) // unormally big
				{
					byte c = (byte) bitData.Read( pos, 7 );
					pos += 7;
					if (c == 0)
					{
						m_OwnerName = new byte [ chars.Count + 1 ];
						for (int i = 0; i < chars.Count; i++)
						{
							m_OwnerName [ i ] = chars.ElementAt( i );
						}
						m_OwnerName [ chars.Count ] = 0;
						break;
					}
					chars.Add( c );
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
			if (m_Socketed)
			{
				m_SocketsTotal = (int) bitData.Read( pos, 4 );
				pos += 4;
			}
			if (m_Rarity == ItemRarity.Set)
			{
				m_SetPropertiesBits = (int) bitData.Read( pos, 5 );
				pos += 5;
			}
			// List of magical properties of the item. See Property Lists (https://squeek502.github.io/d2itemreader/formats/d2.html#property-lists)
			if (m_SetPropertiesBits.HasValue && m_SetPropertiesBits.Value != 0)
			{
				// m_SetPropertiesBits.Value & (1 << index) != 0 ==> read set property
			}
			if (m_Runeword)
			{
				// A property list containing the properties of the item that come from the runeword
			}
			return new BytesCounter( pos );
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
		ItemParent m_Parent = ItemParent.NotSet;
		ItemLocation m_Storage = ItemLocation.NotSet;
		BodyPlacement m_Placement = BodyPlacement.NotSet;
		int m_Column = -1;
		int m_Row = -1;
		//byte [] m_TypeCode = new byte[3];
		//
		int? m_EarClass;
		int? m_EarLevel;
		byte [] m_EarOriginName;
		//
		byte [] m_ItemType = new byte [ 3 ];

		int? m_SocketsFilled;
		int? m_SocketsTotal;
		uint m_Id = 0xFFFF;
		int m_Level = -1;
		ItemRarity m_Rarity = ItemRarity.Invalid;
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
		int? [] m_IdRareAffixes = new int? [ 6 ];
		int? m_IdRunwordName;
		byte [] m_OwnerName;
		int? m_SetPropertiesBits;

	}
}
