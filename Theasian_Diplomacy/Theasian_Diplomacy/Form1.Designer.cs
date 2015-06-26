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
            this.btnListAll = new System.Windows.Forms.Button();
            this.lstCharacter = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.lstFactionLeaders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dialoguesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultezLesVisitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesLettresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lireLeJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPlayer = new System.Windows.Forms.GroupBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.trésorerieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerLesLoisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerLesImpôtsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportDespionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servicesSecretsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectuerUneOpérationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerSaGardesPersonnellesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gèrerLeTauxDeRecrutementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPlayerAge = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpPlayer.SuspendLayout();
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
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(1036, 210);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(164, 23);
            this.btnListAll.TabIndex = 1;
            this.btnListAll.Text = "List all game elements";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.btnListFaction_Click);
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
            this.menuMainMenu,
            this.dialoguesToolStripMenuItem,
            this.nouvellesToolStripMenuItem,
            this.trésorerieToolStripMenuItem,
            this.servicesSecretsToolStripMenuItem});
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
            this.menuMainMenu.Size = new System.Drawing.Size(99, 20);
            this.menuMainMenu.Text = "Menu principal";
            // 
            // menuNewGame
            // 
            this.menuNewGame.Name = "menuNewGame";
            this.menuNewGame.Size = new System.Drawing.Size(157, 22);
            this.menuNewGame.Text = "Nouvelle partie!";
            this.menuNewGame.Click += new System.EventHandler(this.menuNewGame_Click);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.Size = new System.Drawing.Size(157, 22);
            this.menuQuit.Text = "Quitter";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.Location = new System.Drawing.Point(938, 301);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(200, 264);
            this.lstCity.TabIndex = 4;
            // 
            // lstFactionLeaders
            // 
            this.lstFactionLeaders.FormattingEnabled = true;
            this.lstFactionLeaders.Location = new System.Drawing.Point(812, 301);
            this.lstFactionLeaders.Name = "lstFactionLeaders";
            this.lstFactionLeaders.Size = new System.Drawing.Size(120, 264);
            this.lstFactionLeaders.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(809, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Faction leaders, faction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(935, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cities, owners";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1141, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Characters, Factions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1267, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Factions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Or: 0 pièces";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Niveau de sécurité: 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Points d\'actions: 0";
            // 
            // dialoguesToolStripMenuItem
            // 
            this.dialoguesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultezLesVisitesToolStripMenuItem,
            this.consulterLesLettresToolStripMenuItem});
            this.dialoguesToolStripMenuItem.Name = "dialoguesToolStripMenuItem";
            this.dialoguesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.dialoguesToolStripMenuItem.Text = "Dialogues";
            // 
            // consultezLesVisitesToolStripMenuItem
            // 
            this.consultezLesVisitesToolStripMenuItem.Name = "consultezLesVisitesToolStripMenuItem";
            this.consultezLesVisitesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.consultezLesVisitesToolStripMenuItem.Text = "Rencontrer des visiteurs";
            // 
            // consulterLesLettresToolStripMenuItem
            // 
            this.consulterLesLettresToolStripMenuItem.Name = "consulterLesLettresToolStripMenuItem";
            this.consulterLesLettresToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.consulterLesLettresToolStripMenuItem.Text = "Consulter les lettres";
            // 
            // nouvellesToolStripMenuItem
            // 
            this.nouvellesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lireLeJournalToolStripMenuItem,
            this.rapportDespionsToolStripMenuItem});
            this.nouvellesToolStripMenuItem.Name = "nouvellesToolStripMenuItem";
            this.nouvellesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.nouvellesToolStripMenuItem.Text = "Nouvelles";
            // 
            // lireLeJournalToolStripMenuItem
            // 
            this.lireLeJournalToolStripMenuItem.Name = "lireLeJournalToolStripMenuItem";
            this.lireLeJournalToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.lireLeJournalToolStripMenuItem.Text = "Lire le journal";
            // 
            // grpPlayer
            // 
            this.grpPlayer.Controls.Add(this.lblPlayerAge);
            this.grpPlayer.Controls.Add(this.txtPlayerName);
            this.grpPlayer.Location = new System.Drawing.Point(15, 125);
            this.grpPlayer.Name = "grpPlayer";
            this.grpPlayer.Size = new System.Drawing.Size(290, 170);
            this.grpPlayer.TabIndex = 13;
            this.grpPlayer.TabStop = false;
            this.grpPlayer.Text = "Informations personnelles";
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(7, 20);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(145, 20);
            this.txtPlayerName.TabIndex = 0;
            this.txtPlayerName.Text = "NomJoueurParDéfaut";
            // 
            // trésorerieToolStripMenuItem
            // 
            this.trésorerieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerLesLoisToolStripMenuItem,
            this.consulterToolStripMenuItem,
            this.changerLesImpôtsToolStripMenuItem,
            this.gèrerLeTauxDeRecrutementToolStripMenuItem});
            this.trésorerieToolStripMenuItem.Name = "trésorerieToolStripMenuItem";
            this.trésorerieToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.trésorerieToolStripMenuItem.Text = "Gestion du royaume";
            // 
            // changerLesLoisToolStripMenuItem
            // 
            this.changerLesLoisToolStripMenuItem.Name = "changerLesLoisToolStripMenuItem";
            this.changerLesLoisToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.changerLesLoisToolStripMenuItem.Text = "Changer les lois";
            // 
            // consulterToolStripMenuItem
            // 
            this.consulterToolStripMenuItem.Name = "consulterToolStripMenuItem";
            this.consulterToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.consulterToolStripMenuItem.Text = "Consulter le trésor";
            // 
            // changerLesImpôtsToolStripMenuItem
            // 
            this.changerLesImpôtsToolStripMenuItem.Name = "changerLesImpôtsToolStripMenuItem";
            this.changerLesImpôtsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.changerLesImpôtsToolStripMenuItem.Text = "Changer les impôts/taxes";
            // 
            // rapportDespionsToolStripMenuItem
            // 
            this.rapportDespionsToolStripMenuItem.Name = "rapportDespionsToolStripMenuItem";
            this.rapportDespionsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.rapportDespionsToolStripMenuItem.Text = "Rapport d\'espions";
            // 
            // servicesSecretsToolStripMenuItem
            // 
            this.servicesSecretsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effectuerUneOpérationToolStripMenuItem,
            this.gérerSaGardesPersonnellesToolStripMenuItem});
            this.servicesSecretsToolStripMenuItem.Name = "servicesSecretsToolStripMenuItem";
            this.servicesSecretsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.servicesSecretsToolStripMenuItem.Text = "Services secrets";
            // 
            // effectuerUneOpérationToolStripMenuItem
            // 
            this.effectuerUneOpérationToolStripMenuItem.Name = "effectuerUneOpérationToolStripMenuItem";
            this.effectuerUneOpérationToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.effectuerUneOpérationToolStripMenuItem.Text = "Effectuer une opération";
            // 
            // gérerSaGardesPersonnellesToolStripMenuItem
            // 
            this.gérerSaGardesPersonnellesToolStripMenuItem.Name = "gérerSaGardesPersonnellesToolStripMenuItem";
            this.gérerSaGardesPersonnellesToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.gérerSaGardesPersonnellesToolStripMenuItem.Text = "Gérer sa garde personnelles";
            // 
            // gèrerLeTauxDeRecrutementToolStripMenuItem
            // 
            this.gèrerLeTauxDeRecrutementToolStripMenuItem.Name = "gèrerLeTauxDeRecrutementToolStripMenuItem";
            this.gèrerLeTauxDeRecrutementToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.gèrerLeTauxDeRecrutementToolStripMenuItem.Text = "Gèrer le taux de recrutement";
            // 
            // lblPlayerAge
            // 
            this.lblPlayerAge.AutoSize = true;
            this.lblPlayerAge.Location = new System.Drawing.Point(6, 43);
            this.lblPlayerAge.Name = "lblPlayerAge";
            this.lblPlayerAge.Size = new System.Drawing.Size(80, 13);
            this.lblPlayerAge.TabIndex = 14;
            this.lblPlayerAge.Text = "Âge: over 9000";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 577);
            this.Controls.Add(this.grpPlayer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFactionLeaders);
            this.Controls.Add(this.lstCity);
            this.Controls.Add(this.lstCharacter);
            this.Controls.Add(this.btnListAll);
            this.Controls.Add(this.lstFaction);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMainMenu";
            this.Text = "Theasian Diplomacy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpPlayer.ResumeLayout(false);
            this.grpPlayer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFaction;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.ListBox lstCharacter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuNewGame;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.ListBox lstFactionLeaders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem dialoguesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultezLesVisitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLesLettresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvellesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lireLeJournalToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpPlayer;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.ToolStripMenuItem rapportDespionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trésorerieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerLesLoisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerLesImpôtsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servicesSecretsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effectuerUneOpérationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerSaGardesPersonnellesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gèrerLeTauxDeRecrutementToolStripMenuItem;
        private System.Windows.Forms.Label lblPlayerAge;
    }
}

