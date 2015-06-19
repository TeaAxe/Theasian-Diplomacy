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
            this.btnListFaction.Location = new System.Drawing.Point(1270, 272);
            this.btnListFaction.Name = "btnListFaction";
            this.btnListFaction.Size = new System.Drawing.Size(120, 23);
            this.btnListFaction.TabIndex = 1;
            this.btnListFaction.Text = "List all factions";
            this.btnListFaction.UseVisualStyleBackColor = true;
            this.btnListFaction.Click += new System.EventHandler(this.btnListFaction_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 577);
            this.Controls.Add(this.btnListFaction);
            this.Controls.Add(this.lstFaction);
            this.Name = "frmMainMenu";
            this.Text = "Theasian Diplomacy";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstFaction;
        private System.Windows.Forms.Button btnListFaction;
    }
}

