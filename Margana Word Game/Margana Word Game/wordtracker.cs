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
        List<string> cmv_UsedWords = new List<string>(); //we use this list to keep track of words used

        public wordtracker()
        {

        }

        public void _addNewWord(string _word)
        {
            cmv_UsedWords.Add(_word); //add 
        }

        public Boolean _checkWordUsed(string _word)
        {
            foreach(string cmv_check in cmv_UsedWords){
                if (cmv_check == _word)
                    //word exists in list
                    return true;
            }
            return false;
        }

        public void _clearList()
        {
            cmv_UsedWords.Clear(); // empty the list
        }
    }
}
