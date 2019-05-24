using System;
using System.Text;
using System.Collections.Generic;

namespace WordSearchII
{
    class Program
    {
        // Modify to search all 8 directions.
        static (int, int)[] direction = new (int, int)[] { (0, 1), (0, -1), (1, 0), (-1, 0), (1, 1), (1, -1), (-1, -1), (-1, 1) };

        static bool Lookup(char[][] board, bool[,] isVisited, int row, int col, string word, int wordIndex)
        {
            if (word.Length == wordIndex)
            {
                return true;
            }

            if (row < 0 || col < 0 || row >= board.Length || col >= board[0].Length)
            {
                return false;
            }

            if (word[wordIndex] != board[row][col])
            {
                return false;
            }

            if (isVisited[row, col])
            {
                return false;
            }

            isVisited[row, col] = true;

            foreach (var dir in direction)
            {
                if (Lookup(board, isVisited, row + dir.Item1, col + dir.Item2, word, wordIndex + 1))
                {
                    return true;
                }
            }

            isVisited[row, col] = false;

            return false;
        }
        static IList<string> FindWords(char[][] board, string[] words)
        {
            IList<string> wordList = new List<string>();

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[0].Length; col++)
                {
                    foreach (string word in words)
                    {
                        bool[,] isVisited = new bool[board.Length, board[0].Length];
                        if (Lookup(board, isVisited, row, col, word, 0))
                        {
                            if (!wordList.Contains(word))
                            {
                                wordList.Add(word);
                            }
                        }
                    }
                }
            }

            return wordList;
        }

        static void Main(string[] args)
        {
            char[][] board = new char[][]
            {
                new char[] { 'o', 'a', 'a', 'n' },
                new char[] { 'e', 't', 'a', 'e' },
                new char[] { 'i', 'h', 'k', 'r' },
                new char[] { 'i', 'f', 'l', 'v' }
            };

            string[] words = new string[] { "oath", "pea", "eat", "rain", "han" };

            IList<string> wordList = FindWords(board, words);

            foreach (string w in wordList)
            {
                Console.Write(w + " ");
            }
        }
    }
}
