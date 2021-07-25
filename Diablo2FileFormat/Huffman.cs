using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo2FileFormat
{
	static public class Huffman
	{
		static public byte decode( BitField bits, ref int pos )
		{
			return Decoder.DecodeByte( bits, ref pos );
		}
	}

	class Node
	{
		public Node [] children;
		public byte? value;
	}

	static class Decoder
	{
		// reads bit after bit starting from pos until gets decoded byte,
		// returns decoded byte,
		// advances pos by number of bits read
		static internal byte DecodeByte( BitField bits, ref int pos )
		{
			//https://github.com/dschu012/d2s/blob/2d4289c2536b483161ac235d3ea271e3f37b1c54/src/d2/items.ts#L501
			//https://github.com/d07RiV/d07riv.github.io/blob/master/d2r.html#L11-L20
			//for (let i = 0; i < 4; i++)
			//{
			//    let node = HUFFMAN as any;
			//    do
			//    {
			//        node = node[reader.ReadBit()];
			//    } while (Array.isArray(node));
			//    item.type += node;
			//}
			Node node = DecodeData;
			do
			{
				var b = bits.Read( pos, 1 );
				pos += 1;
				if (node == null)
				{
					// fatal
					return 0;
				}
				node = node.children [ b ];
			} while (!node.value.HasValue);
			return node.value.Value;
		}

		static Node DecodeData = new Node
		{
			children = new Node [] {
                // [[[[ "w", "u" ],[["8",["y",["5",["j",[]]]]],"h"]],["s",[["2","n"],"x"]]],[[["c",["k","f"]],"b"],[["t","m"],["9","7"]]]]
                new Node {
					children = new Node[] {
                        // [[[ "w", "u" ],[["8",["y",["5",["j",[]]]]],"h"]],["s",[["2","n"],"x"]]]
                        new Node {
							children = new Node[] {
                                // [[ "w", "u" ],[["8",["y",["5",["j",[]]]]],"h"]]
                                new Node {
									children = new Node[] {
                                        // [ "w", "u" ]
                                        new Node {
											children = new Node[] {
                                                //  "w"
                                                new Node {
													children = new Node[] {null, null, },
													value = (byte)'w',
												},
                                                //  "u"
                                                new Node {
													children = new Node[] {null, null, },
													value = (byte)'u',
												},
											},
										},
                                        // [["8",["y",["5",["j",[]]]]],"h"]
                                        new Node {
											children = new Node[] {
                                                // ["8",["y",["5",["j",[]]]]]
                                                new Node {
													children = new Node[] {
                                                        // "8"
                                                        new Node {
															children = new Node[] { null, null, },
															value = (byte)'8',
														},
                                                        // ["y",["5",["j",[]]]]
                                                        new Node {
															children = new Node[] {
                                                                // "y"
                                                                new Node {
																	children = new Node[] { null, null, },
																	value = (byte)'y',
																},
                                                                // ["5",["j",[]]]
                                                                new Node {
																	children = new Node[] {
                                                                        // "5"
                                                                        new Node {
																			children = new Node[] { null, null, },
																			value = (byte)'5',
																		},
                                                                        // ["j",[]]
                                                                        new Node {
																			children = new Node[] {
                                                                                // "j"
                                                                                new Node {
																					children = new Node[] { null, null, },
																					value = (byte)'j',
																				},
                                                                                // []
                                                                                null,
																			},
																		},
																	},
																},
															},
														},
													},
												},
                                                // ,"h"
                                                new Node {
													children = new Node[] {null, null, },
													value = (byte)'h',
												},
											},
										},
									},
								},
                                // ["s",[["2","n"],"x"]]
                                new Node {
									children = new Node[] {
                                        // "s"
                                        new Node {
											children = new Node[] {null,null,},
											value = (byte)'s',
										},
                                        // [["2","n"],"x"]
                                        new Node {
											children = new Node[] {
                                                // ["2","n"]
                                                new Node {
													children = new Node[] {
                                                        // "2"
                                                        new Node {
															children = new Node[] {null,null,},
															value = (byte)'2',
														},
                                                        // "n"
                                                        new Node {
															children = new Node[] {null,null,},
															value = (byte)'n',
														},
													},
												},
                                                // "x"
                                                new Node {
													children = new Node[] {null,null,},
													value = (byte)'x',
												},
											},
										},
									},
								},
							},
						},
                        // [[["c",["k","f"]],"b"],[["t","m"],["9","7"]]]
                        new Node {
							children = new Node[] {
                                // [["c",["k","f"]],"b"]
                                new Node {
									children = new Node[] {
                                        // ["c",["k","f"]]
                                        new Node {
											children = new Node[] {
                                                // "c"
                                                new Node {
													children = new Node[] { null, null, },
													value = (byte)'c',
												},
                                                // ["k","f"]
                                                new Node {
													children = new Node[] {
                                                        // "k"
                                                        new Node {
															children = new Node[] { null, null, },
															value = (byte)'k',
														},
                                                        // "f"
                                                        new Node {
															children = new Node[] {null, null, },
															value = (byte)'f',
														},
													},
												},
											},
										},
                                        // "b"
                                        new Node {
											children = new Node[] { null, null, },
											value = (byte)'b',
										},
									},
								},
                                // [["t","m"],["9","7"]]
                                new Node {
									children = new Node[] {
                                        // ["t","m"]
                                        new Node {
											children = new Node[] {
                                                // "t"
                                                new Node {
													children = new Node[] { null, null },
													value = (byte) 't'
												},
                                                // "m"
                                                new Node {
													children = new Node[] { null, null },
													value = (byte) 'm'
												},
											},
										},
                                        // ["9","7"]
                                        new Node {
											children = new Node[] {
                                                // "9"
                                                new Node {
													children = new Node[] { null, null },
													value = (byte) '9'
												},
                                                // "7"
                                                new Node {
													children = new Node[] { null, null },
													value = (byte) '7'
												},
											},
										},
									},
								},
							},
						},
					},
				},
                // [ " ", [[[["e", "d"], "p"], ["g",[[["z", "q"], "3"], ["v", "6"]]]], [["r", "l"], ["a",[["1",["4", "0"]],["i", "o"]]]]] ]
                new Node {
					children = new Node [] {
                        // " "
                        new Node {
							children = new Node [] { null, null },
							value = (byte)' ',
						},
                        // [[[["e", "d"], "p"], ["g",[[["z", "q"], "3"], ["v", "6"]]]], [["r", "l"], ["a",[["1",["4", "0"]],["i", "o"]]]]]
                        new Node {
							children = new Node [] {
                                // [[["e", "d"], "p"], ["g",[[["z", "q"], "3"], ["v", "6"]]]]
                                new Node {
									children = new Node [] {
                                        // [["e", "d"], "p"]
                                        new Node {
											children = new Node [] {
                                                // ["e", "d"]
                                                new Node {
													children = new Node [] {
                                                        // "e"
                                                        new Node {
															children = new Node[] {null, null, },
															value = (byte)'e',
														},
                                                        // "d"
                                                        new Node {
															children = new Node[] {null, null, },
															value = (byte)'d',
														}
													}
												},
                                                // "p"
                                                new Node {
													children = new Node[] {null, null, },
													value = (byte)'p',
												},
											}
										},
                                        // ["g",[[["z", "q"], "3"], ["v", "6"]]]
                                        new Node {
											children = new Node [] {
                                                // "g"
                                                new Node {
													children = new Node[] {null, null, },
													value = (byte)'g',
												},
                                                // [[["z", "q"], "3"], ["v", "6"]]
                                                new Node {
													children = new Node [] {
                                                        // [["z", "q"], "3"]
                                                        new Node {
															children = new Node [] {
                                                                // ["z", "q"]
                                                                new Node {
																	children = new Node [] {
                                                                        // "z"
                                                                        new Node {
																			children = new Node[] {null, null, },
																			value = (byte)'z',
																		},
                                                                        // "q"
                                                                        new Node {
																			children = new Node[] {null, null, },
																			value = (byte)'q',
																		},
																	}
																},
                                                                // "3"
                                                                new Node {
																	children = new Node[] {null, null, },
																	value = (byte)'3',
																},
															}
														},
                                                        // ["v", "6"]
                                                        new Node {
															children = new Node [] {
                                                                // "v"
                                                                new Node {
																	children = new Node[] {null, null, },
																	value = (byte)'v',
																},
                                                                // "6"
                                                                new Node {
																	children = new Node[] {null, null, },
																	value = (byte)'6',
																},
															}
														},
													}
												},
											}
										},
									}
								},
                                // [["r", "l"], ["a",[["1",["4", "0"]],["i", "o"]]]]
                                new Node {
									children = new Node [] {
                                        // ["r", "l"]
                                        new Node {
											children = new Node [] {
                                                // "r"
                                                new Node {
													children = new Node[] {null, null, },
													value = (byte)'r',
												},
                                                // "l"
                                                new Node {
													children = new Node[] {null, null, },
													value = (byte)'l',
												},
											}
										},
                                        // ["a",[["1",["4", "0"]],["i", "o"]]]
                                        new Node {
											children = new Node [] {
                                                //"a"
                                                new Node {
													children = new Node[] {null, null, },
													value = (byte)'a',
												},
                                                // [["1",["4", "0"]],["i", "o"]]
                                                new Node {
													children = new Node [] {
                                                        // ["1",["4", "0"]]
                                                        new Node {
															children = new Node [] {
                                                                // "1"
                                                                new Node {
																	children = new Node[] {null, null, },
																	value = (byte)'1',
																},
                                                                // ["4", "0"]
                                                                new Node {
																	children = new Node [] {
                                                                        // "4"
                                                                        new Node {
																			children = new Node[] {null, null, },
																			value = (byte)'4',
																		},
                                                                        // "0"
                                                                        new Node {
																			children = new Node[] {null, null, },
																			value = (byte)'0',
																		},
																	}
																},
															}
														},
                                                        // ["i", "o"]
                                                        new Node {
															children = new Node [] {
                                                                // "i"
                                                                new Node {
																	children = new Node[] {null, null, },
																	value = (byte)'i',
																},
                                                                // "o"
                                                                new Node {
																	children = new Node[] {null, null, },
																	value = (byte)'o',
																},
															}
														},
													}
												},
											}
										},
									}
								},
							}
						},
					},
				}
			}
		};
	}
}
