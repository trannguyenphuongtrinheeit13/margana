using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Margana_Word_Game
{
    public partial class frmMarganaMain : Form
    {
        public frmMarganaMain()
        {
            InitializeComponent();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySQL lc_mySQLConnection = new mySQL(); //create class instance 
            lc_mySQLConnection._OpenConnection(); //create sql connection
            lc_mySQLConnection._closeConnection(); //close mysql connection   
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void afrikaansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //change program menu text and disable other game buttons
            this.Text = "Margana - Afrikaans";
            englishToolStripMenuItem.Enabled = false;
            germanToolStripMenuItem.Enabled = false;
            portugueseToolStripMenuItem.Enabled = false;
            string lc_realWord = "";

            //enable game buttons
            btnNextWord.Enabled = true;
            btnScrambleWord.Enabled = true;
            btnSubmit.Enabled = true;

            //get words from database
            mySQL lc_mySQLConnection = new mySQL(); //create class instance 
            lc_mySQLConnection._OpenConnection(); //create sql connection
            MySqlDataReader lc_sqlResult = lc_mySQLConnection._getWords("Afrikaans"); //get all afrikaans words

            //add words to queue
            wordtracker lc_wordQueue = new wordtracker();

            while (lc_sqlResult.Read())
            {
                lc_wordQueue._addNewWord(lc_sqlResult.GetString(0).ToLower());//add word one at a time and convert to lower
            }

            lc_mySQLConnection._closeConnection(); //close mysql connection   

            lblRealWord.Visible = false;
            lblRealWord.Text = "Real Word";

            lc_realWord = lc_wordQueue.getNextWord(); // keep the word used in a seperate variable
            WordShuffler lc_wordShuffler = new WordShuffler(lc_wordQueue.getNextWord()); // shuffle current word
            string lc_shuffledWord = lc_wordShuffler.scramble();
            gameTimer.Enabled = true;
            pauseGameToolStripMenuItem.Enabled = true;
            cheatToolStripMenuItem.Enabled = true;
            txtYourWord.Enabled = true;
            txtYourWord.Focus();
            txtYourWord.Clear();
            lblWord.Text = lc_shuffledWord; // temp
            lc_wordQueue.dequeueWord(); // remove first word from queue

        }
    }
}
