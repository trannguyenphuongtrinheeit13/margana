/*
 * Russell Chamunorwa Mazonde
 * small class for adding used words to a list
 * also checks if a word has been used before
 * untested
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margana_Word_Game
{
    class wordtracker
    {
        Queue<string> cmv_UsedWords = new Queue<string>(); //we use this list to keep track of words used

        public wordtracker()
        {

        }

        public void _addNewWord(string _word)
        {
            cmv_UsedWords.Enqueue(_word); //add item to queue
        }

        public string getNextWord()
        {
            //read from top to bottom
            if (cmv_UsedWords.Count != 0)
                return cmv_UsedWords.Peek();
            else
                return null;
        }

        public void dequeueWord()
        {
            if (cmv_UsedWords.Count != 0)
                cmv_UsedWords.Dequeue(); // remove word at top of queue
        }

        public void _clearList()
        {
            cmv_UsedWords.Clear(); // empty the list
        }
    }
}
