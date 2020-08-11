using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDotnet.SearchEngine
{
    public class AlgorithmSearchEngine
    {
        private Trie _trie = new Trie();

        public bool AddWord(string word)
        {
            bool isNewWord = false;
            isNewWord = _trie.AddWord(word);
            return isNewWord;
        }
    }
 
    public class TrieNode
    {
        Dictionary<char, TrieNode> _nodeChildren = new Dictionary<char, TrieNode>();

        public bool HasChildNode(char character)
        {
            return _nodeChildren.ContainsKey(character);
        }

        public void MakeChildNode(char character)
        {
            _nodeChildren[character] = new TrieNode();
        }

        public TrieNode GetChildNode(char character)
        {
            return _nodeChildren[character];
        }
    }

    public class Trie
    {
        private const char EndOfWordMarker = '\0';

        private TrieNode _rootNode = new TrieNode();

        public bool AddWord(string word)
        {
            bool isNewWord = false;

            var currentNode = _rootNode;

            foreach (var c in word)
            {
                if (!currentNode.HasChildNode(c))
                {
                    isNewWord = true;
                    currentNode.MakeChildNode(c);
                }

                currentNode = currentNode.GetChildNode(c);
            }

            if (!currentNode.HasChildNode(EndOfWordMarker))
            {
                isNewWord = true;
                currentNode.MakeChildNode(EndOfWordMarker);
            }

            return isNewWord;
        }
    }
}
