using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diablo2FileFormat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo2FileFormat.Tests
{
    [TestClass()]
    public class HuffmanTests
    {
        [TestMethod()]
        public void decodeTest()
        {
			string encoded_a = "11110";
			string encoded_b = "0101";
			string encoded_c = "01000";
			string encoded_d = "110001";
			string encoded_e = "110000";
			string encoded_f = "010011";
			string encoded_g = "11010";
			string encoded_h = "00011";
			string encoded_i = "1111110";
			string encoded_j = "000101110";
			string encoded_k = "010010";
			string encoded_l = "11101";
			string encoded_m = "01101";
			string encoded_n = "001101";
			string encoded_o = "1111111";
			string encoded_p = "11001";
			string encoded_q = "11011001";
			string encoded_r = "11100";
			string encoded_s = "0010";
			string encoded_t = "01100";
			string encoded_u = "00001";
			string encoded_v = "1101110";
			string encoded_w = "00000";
			string encoded_x = "00111";
			string encoded_y = "0001010";
			string encoded_z = "11011000";
			string encoded_0 = "11111011";
			string encoded_1 = "1111100";
			string encoded_2 = "001100";
			string encoded_3 = "1101101";
			string encoded_4 = "11111010";
			string encoded_5 = "00010110";
			string encoded_6 = "1101111";
			string encoded_7 = "01111";
			string encoded_8 = "000100";
			string encoded_9 = "01110";
			string[] letters = {
				encoded_a, encoded_b, encoded_c, encoded_d, encoded_e, encoded_f, encoded_g, encoded_h, encoded_i, encoded_j,
				encoded_k, encoded_l, encoded_m, encoded_n, encoded_o, encoded_p, encoded_q, encoded_r, encoded_s, encoded_t,
				encoded_u, encoded_v, encoded_w, encoded_x, encoded_y, encoded_z, encoded_0, encoded_1, encoded_2, encoded_3,
				encoded_4, encoded_5, encoded_6, encoded_7, encoded_8, encoded_9
			};
			int bits_count = 0;
			foreach (var l in letters)
			{
				bits_count += l.Length;
			}
			var bytes_count = new BytesCounter(bits_count);
			byte[] test_data = new byte[bytes_count.Bytes];
			BitField test_bit_field = new BitField(test_data);
			int bitn = 0;
			foreach (var l in letters)
			{
				foreach (var letter in l)
				{
					if (letter == '1')
					{
						test_bit_field.Write(1, bitn, 1);
					}
					bitn++;
				}
			}
			// expected data
			char[] expected_chars =
			{
				'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's',
				't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'
			};
			// read data
			int test_pos = 0;
			char[] read_chars = new char[letters.Length];
			for (int i = 0; i < letters.Length; i++)
			{
				read_chars[i] = (char)Huffman.decode(test_bit_field, ref test_pos);
				Assert.AreEqual(expected_chars[i], read_chars[i]);
			}
        }
    }
}