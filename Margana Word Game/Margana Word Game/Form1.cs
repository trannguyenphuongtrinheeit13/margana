using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
