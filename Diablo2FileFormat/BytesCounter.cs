using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo2FileFormat
{
	public class BytesCounter
	{
		public int Bytes => m_bytes;

		public int Bits => m_bits;

		public BytesCounter(int bits)
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
}
