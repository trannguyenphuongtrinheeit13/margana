/*
 * Russell Chamunorwa Mazonde "Shady"
 * 19 September 2014
 * Untested
 * Shuffles up characters in a word
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margana_Word_Game
{
    class WordShuffler
    {
        char cmv_randomLetter;
        string cmv_temp = "";
        Random cmv_radomize;
        string cmv_scrambledWord = "";
        string cmv_word;
   
        public WordShuffler(string _word)
        {
            this.cmv_word = _word;
        }

        public string scramble()
        {
            // get the word
            // pick a random letter position based on length of word
            // pick the letter and place it in a new variable
            // remove the letter from its position in the original word
            // pick a random letter position based on the new length on the word
            // keep doing so until there are no letters word
            do
            {
                cmv_randomLetter = cmv_word[cmv_radomize.Next(cmv_word.Length)]; //get char at random position in string                                     

                for (int i = 0; i <= cmv_word.Length - 1; i++)
                {
                    if ((cmv_word[i]) == cmv_randomLetter)
                    {// check if word being iterated in for loop is the random letter picked before
                        cmv_temp = cmv_word.Remove(i); //remove letter at position
                        cmv_word = cmv_temp; //assign new word that has one less letter to _word variable
                        cmv_temp = ""; //clear temp
                        break;
                    }
                }
                cmv_scrambledWord += cmv_randomLetter; //append random character to variable that will hold scrambled word.
            } while (cmv_word.Length > 0);

            return cmv_scrambledWord;
        }
    }
}
