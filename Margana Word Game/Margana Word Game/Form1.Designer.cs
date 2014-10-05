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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMarganaMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afrikaansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portugueseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitCurrentGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRight = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWrong = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
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
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
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
            // afrikaansToolStripMenuItem
            // 
            this.afrikaansToolStripMenuItem.Name = "afrikaansToolStripMenuItem";
            this.afrikaansToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afrikaansToolStripMenuItem.Text = "Afrikaans";
            this.afrikaansToolStripMenuItem.Click += new System.EventHandler(this.afrikaansToolStripMenuItem_Click);
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
            // cheatToolStripMenuItem
            // 
            this.cheatToolStripMenuItem.Name = "cheatToolStripMenuItem";
            this.cheatToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cheatToolStripMenuItem.Text = "Cheat";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Location = new System.Drawing.Point(186, 138);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 52);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit Word";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnScrambleWord
            // 
            this.btnScrambleWord.BackColor = System.Drawing.Color.Transparent;
            this.btnScrambleWord.Location = new System.Drawing.Point(348, 138);
            this.btnScrambleWord.Name = "btnScrambleWord";
            this.btnScrambleWord.Size = new System.Drawing.Size(75, 52);
            this.btnScrambleWord.TabIndex = 7;
            this.btnScrambleWord.Text = "Shuffle Word";
            this.btnScrambleWord.UseVisualStyleBackColor = false;
            // 
            // btnNextWord
            // 
            this.btnNextWord.BackColor = System.Drawing.Color.Transparent;
            this.btnNextWord.Location = new System.Drawing.Point(267, 138);
            this.btnNextWord.Name = "btnNextWord";
            this.btnNextWord.Size = new System.Drawing.Size(75, 52);
            this.btnNextWord.TabIndex = 6;
            this.btnNextWord.Text = "Next Word";
            this.btnNextWord.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scambled Word:";
            // 
            // lblRealWord
            // 
            this.lblRealWord.AutoSize = true;
            this.lblRealWord.BackColor = System.Drawing.Color.Transparent;
            this.lblRealWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRealWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealWord.Location = new System.Drawing.Point(326, 62);
            this.lblRealWord.Name = "lblRealWord";
            this.lblRealWord.Size = new System.Drawing.Size(99, 22);
            this.lblRealWord.TabIndex = 2;
            this.lblRealWord.Text = "Real World";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.Color.Transparent;
            this.lblWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(158, 62);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(53, 22);
            this.lblWord.TabIndex = 1;
            this.lblWord.Text = "Word";
            // 
            // lblYourWord
            // 
            this.lblYourWord.AutoSize = true;
            this.lblYourWord.BackColor = System.Drawing.Color.Transparent;
            this.lblYourWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourWord.Location = new System.Drawing.Point(135, 109);
            this.lblYourWord.Name = "lblYourWord";
            this.lblYourWord.Size = new System.Drawing.Size(99, 20);
            this.lblYourWord.TabIndex = 3;
            this.lblYourWord.Text = "Your Word:";
            // 
            // txtYourWord
            // 
            this.txtYourWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYourWord.Location = new System.Drawing.Point(240, 106);
            this.txtYourWord.Name = "txtYourWord";
            this.txtYourWord.Size = new System.Drawing.Size(183, 26);
            this.txtYourWord.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.lblTime,
            this.lblRight,
            this.lblWrong,
            this.pbBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 196);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(517, 22);
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
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 17);
            this.lblTime.Text = "0";
            // 
            // lblRight
            // 
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(55, 17);
            this.lblRight.Text = "0 Correct";
            // 
            // lblWrong
            // 
            this.lblWrong.Name = "lblWrong";
            this.lblWrong.Size = new System.Drawing.Size(52, 17);
            this.lblWrong.Text = "0 Wrong";
            // 
            // pbBar1
            // 
            this.pbBar1.Name = "pbBar1";
            this.pbBar1.Size = new System.Drawing.Size(100, 16);
            this.pbBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // frmMarganaMain
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 218);
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
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripStatusLabel lblRight;
        private System.Windows.Forms.ToolStripStatusLabel lblWrong;
        private System.Windows.Forms.ToolStripProgressBar pbBar1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afrikaansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portugueseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitCurrentGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer gameTimer;
    }
}

