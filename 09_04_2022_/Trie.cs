using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_04_2022_
{
    public class Trie
    {
        public class TrieNode
        {
            public char character;
            public bool isWord;
            public Dictionary<char, TrieNode> children;

            public TrieNode(char ch)
            {
                character = ch;
                isWord = false;
                children = new Dictionary<char, TrieNode>();
            }
            //public TrieNode()
            //{
            //    character('\0');
            //}
        }

        public static void addWord(TrieNode n, String word)
        {
            if (word == null || string.IsNullOrEmpty(word)) return;
            char[] characters = word.ToCharArray();
            foreach (char ch in characters)
            {
                if (!n.children.ContainsKey(ch))
                {
                    n.children.Add(ch, new TrieNode(ch));
                }
                n = n.children.GetValueOrDefault(ch);
            }
            n.isWord = true;
        }
        public static List<string> getAllWords(TrieNode n)
        {
            return getWords(n, "");
        }

        public static bool hasPrefix(TrieNode n, string prefix)
        {
            return has(n, prefix, false);
        }

        public static bool hasWord(TrieNode n, string prefix)
        {
            return has(n, prefix, true);
        }

        private static bool has(TrieNode n, string prefix, bool checkHasWord)
        {
            if (prefix == null) return false;
            char[] characters = prefix.ToCharArray();
            foreach (char ch in characters)
            {
                if (!n.children.ContainsKey(ch)) return false;
                n = n.children.GetValueOrDefault(ch);
            }
            if (checkHasWord)
            {
                return n.isWord;
            }
            else
            {
                return true;
            }
        }

        public static List<string> getWords(TrieNode n, string prefix)
        {
            if (prefix == null) return null;
            List<string> result = new List<string>();
            char[] characters = prefix.ToCharArray();
            foreach  (char ch in characters)
            {
                if (!n.children.ContainsKey(ch)) return result;
                n = n.children.GetValueOrDefault(ch);
            }
            getWords(n, prefix, result);
            return result;
        }

        private static void getWords(TrieNode n, string word, List<string> result)
        {
            if (n.isWord) result.Add(word);
            foreach (char ch in n.children.Keys)
            {
                getWords(n.children.GetValueOrDefault(ch), word + ch, result);
            }
        }
    }
}
