//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using static _09_04_2022_.Trie;

//namespace _09_04_2022_
//{
//    public class Task
//    {
//        public static Rectangle buildLargestRectangle(String[] words)
//        {
//            sortWordsByLength(words);
//            int maxWordLength = words[0].Count();
//            int maxSize = maxWordLength * maxWordLength;
//            List<string>[] wordGroups = createWordGroups(words);
//            TrieNode[] trieGroups = new TrieNode[maxWordLength + 1];
//            for (int size = maxSize; size > 0; --size)
//            {
//                for (int length = maxWordLength; length > 0; --length)
//                {
//                    if (size % length == 0)
//                    {
//                        int width = size / length;
//                        if (width <= maxWordLength)
//                        {
//                            createTrieGroups(wordGroups, trieGroups, width);
//                            Rectangle result = buildRectangle(wordGroups, trieGroups, length, width);
//                            if (result != null) return result;
//                        }
//                    }
//                }
//            }
//            return null;
//        }

//        public class Rectangle
//        {
//            private List<string> matrix;
//            private int length, width;
//            public Rectangle(int l, int w)
//            {
//                matrix = new List<string>();
//                length = l;
//                width = w;
//            }
//            public void append(string word)
//            {
//                if (word != null) matrix.Add(word);
//            }
//            public void remove()
//            {
//                matrix.Remove();
//            }
//            public int getLength()
//            {
//                return length;
//            }
//            public int getWidth()
//            {
//                return width;
//            }
//            public String getWordByRow(int row)
//            {
//                return matrix.get(row);
//            }
//            public String getWordByCol(int col)
//            {
//                StringBuilder sb = new StringBuilder();
//                for (int i = 0; i < matrix.size(); ++i)
//                {
//                    sb.append(matrix.get(i).charAt(col));
//                }
//                return sb.toString();
//            }
//            public void print()
//            {
//                for (String row : matrix)
//                {
//                    println(row);
//                }
//                println();
//            }
//        }
//    }
//}
