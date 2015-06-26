namespace Theasian_Diplomacy
{
    partial class frmMainMenu
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
            this.lstFaction = new System.Windows.Forms.ListBox();
            this.btnListFaction = new System.Windows.Forms.Button();
            this.lstCharacter = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstFaction
            // 
            this.lstFaction.FormattingEnabled = true;
            this.lstFaction.Location = new System.Drawing.Point(1270, 301);
            this.lstFaction.Name = "lstFaction";
            this.lstFaction.Size = new System.Drawing.Size(120, 264);
            this.lstFaction.TabIndex = 0;
            // 
            // btnListFaction
            // 
            this.btnListFaction.Location = new System.Drawing.Point(1207, 272);
            this.btnListFaction.Name = "btnListFaction";
            this.btnListFaction.Size = new System.Drawing.Size(120, 23);
            this.btnListFaction.TabIndex = 1;
            this.btnListFaction.Text = "List all factions";
            this.btnListFaction.UseVisualStyleBackColor = true;
            this.btnListFaction.Click += new System.EventHandler(this.btnListFaction_Click);
            // 
            // lstCharacter
            // 
            this.lstCharacter.FormattingEnabled = true;
            this.lstCharacter.Location = new System.Drawing.Point(1144, 301);
            this.lstCharacter.Name = "lstCharacter";
            this.lstCharacter.Size = new System.Drawing.Size(120, 264);
            this.lstCharacter.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1402, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuMainMenu
            // 
            this.menuMainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewGame,
            this.menuQuit});
            this.menuMainMenu.Name = "menuMainMenu";
            this.menuMainMenu.Size = new System.Drawing.Size(80, 20);
            this.menuMainMenu.Text = "Main Menu";
            // 
            // menuNewGame
            // 
            this.menuNewGame.Name = "menuNewGame";
            this.menuNewGame.Size = new System.Drawing.Size(152, 22);
            this.menuNewGame.Text = "New Game!";
            this.menuNewGame.Click += new System.EventHandler(this.menuNewGame_Click);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(152, 22);
            this.menuQuit.Text = "Quit";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 577);
            this.Controls.Add(this.lstCharacter);
            this.Controls.Add(this.btnListFaction);
            this.Controls.Add(this.lstFaction);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMenu";
            this.Text = "Theasian Diplomacy";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFaction;
        private System.Windows.Forms.Button btnListFaction;
        private System.Windows.Forms.ListBox lstCharacter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuNewGame;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
    }
}

