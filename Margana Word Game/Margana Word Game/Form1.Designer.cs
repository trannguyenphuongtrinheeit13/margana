namespace Margana_Word_Game
{
    partial class frmMarganaMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnScrambleWord = new System.Windows.Forms.Button();
            this.btnNextWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRealWord = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblYourWord = new System.Windows.Forms.Label();
            this.txtYourWord = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitCurrentGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afrikaansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portugueseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameOptionsToolStripMenuItem,
            this.cheatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameOptionsToolStripMenuItem
            // 
            this.gameOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.pauseGameToolStripMenuItem,
            this.exitCurrentGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameOptionsToolStripMenuItem.Name = "gameOptionsToolStripMenuItem";
            this.gameOptionsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.gameOptionsToolStripMenuItem.Text = "Game Options";
            // 
            // cheatToolStripMenuItem
            // 
            this.cheatToolStripMenuItem.Name = "cheatToolStripMenuItem";
            this.cheatToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cheatToolStripMenuItem.Text = "Cheat";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(186, 128);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 52);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit Word";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnScrambleWord
            // 
            this.btnScrambleWord.Location = new System.Drawing.Point(348, 128);
            this.btnScrambleWord.Name = "btnScrambleWord";
            this.btnScrambleWord.Size = new System.Drawing.Size(75, 52);
            this.btnScrambleWord.TabIndex = 2;
            this.btnScrambleWord.Text = "Shuffle Word";
            this.btnScrambleWord.UseVisualStyleBackColor = true;
            // 
            // btnNextWord
            // 
            this.btnNextWord.Location = new System.Drawing.Point(267, 128);
            this.btnNextWord.Name = "btnNextWord";
            this.btnNextWord.Size = new System.Drawing.Size(75, 52);
            this.btnNextWord.TabIndex = 3;
            this.btnNextWord.Text = "Next Word";
            this.btnNextWord.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scambled Word:";
            // 
            // lblRealWord
            // 
            this.lblRealWord.AutoSize = true;
            this.lblRealWord.Location = new System.Drawing.Point(363, 62);
            this.lblRealWord.Name = "lblRealWord";
            this.lblRealWord.Size = new System.Drawing.Size(60, 13);
            this.lblRealWord.TabIndex = 5;
            this.lblRealWord.Text = "Real World";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(104, 62);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(33, 13);
            this.lblWord.TabIndex = 6;
            this.lblWord.Text = "Word";
            // 
            // lblYourWord
            // 
            this.lblYourWord.AutoSize = true;
            this.lblYourWord.Location = new System.Drawing.Point(173, 104);
            this.lblYourWord.Name = "lblYourWord";
            this.lblYourWord.Size = new System.Drawing.Size(61, 13);
            this.lblYourWord.TabIndex = 7;
            this.lblYourWord.Text = "Your Word:";
            // 
            // txtYourWord
            // 
            this.txtYourWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYourWord.Location = new System.Drawing.Point(240, 96);
            this.txtYourWord.Name = "txtYourWord";
            this.txtYourWord.Size = new System.Drawing.Size(183, 26);
            this.txtYourWord.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 200);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(454, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 17);
            this.toolStripStatusLabel1.Text = "Margana";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel2.Text = "Time:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel3.Text = "0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel4.Text = "0 Correct";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel5.Text = "0 Wrong";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afrikaansToolStripMenuItem,
            this.englishToolStripMenuItem,
            this.germanToolStripMenuItem,
            this.portugueseToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // pauseGameToolStripMenuItem
            // 
            this.pauseGameToolStripMenuItem.Name = "pauseGameToolStripMenuItem";
            this.pauseGameToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.pauseGameToolStripMenuItem.Text = "Pause Game";
            // 
            // exitCurrentGameToolStripMenuItem
            // 
            this.exitCurrentGameToolStripMenuItem.Name = "exitCurrentGameToolStripMenuItem";
            this.exitCurrentGameToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitCurrentGameToolStripMenuItem.Text = "Exit Current Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // afrikaansToolStripMenuItem
            // 
            this.afrikaansToolStripMenuItem.Name = "afrikaansToolStripMenuItem";
            this.afrikaansToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afrikaansToolStripMenuItem.Text = "Afrikaans";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // germanToolStripMenuItem
            // 
            this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
            this.germanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.germanToolStripMenuItem.Text = "German";
            // 
            // portugueseToolStripMenuItem
            // 
            this.portugueseToolStripMenuItem.Name = "portugueseToolStripMenuItem";
            this.portugueseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.portugueseToolStripMenuItem.Text = "Portuguese";
            // 
            // frmMarganaMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 222);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtYourWord);
            this.Controls.Add(this.lblYourWord);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblRealWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNextWord);
            this.Controls.Add(this.btnScrambleWord);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMarganaMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Margana Word Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheatToolStripMenuItem;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnScrambleWord;
        private System.Windows.Forms.Button btnNextWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRealWord;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblYourWord;
        private System.Windows.Forms.TextBox txtYourWord;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afrikaansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portugueseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitCurrentGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

