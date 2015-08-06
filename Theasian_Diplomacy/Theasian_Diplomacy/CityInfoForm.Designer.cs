namespace Theasian_Diplomacy
{
    partial class CityInfoForm
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
            this.lblFortificationLevel = new System.Windows.Forms.Label();
            this.lblBaseIncome = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.lblFortificationLevelMax = new System.Windows.Forms.Label();
            this.lblSatisfaction = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFortificationLevel
            // 
            this.lblFortificationLevel.AutoSize = true;
            this.lblFortificationLevel.Location = new System.Drawing.Point(9, 119);
            this.lblFortificationLevel.Name = "lblFortificationLevel";
            this.lblFortificationLevel.Size = new System.Drawing.Size(97, 13);
            this.lblFortificationLevel.TabIndex = 0;
            this.lblFortificationLevel.Text = "lblFortificationLevel";
            // 
            // lblBaseIncome
            // 
            this.lblBaseIncome.AutoSize = true;
            this.lblBaseIncome.Location = new System.Drawing.Point(9, 64);
            this.lblBaseIncome.Name = "lblBaseIncome";
            this.lblBaseIncome.Size = new System.Drawing.Size(76, 13);
            this.lblBaseIncome.TabIndex = 1;
            this.lblBaseIncome.Text = "lblBaseIncome";
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityName.Location = new System.Drawing.Point(9, 9);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(138, 25);
            this.lblCityName.TabIndex = 2;
            this.lblCityName.Text = "lblCityName";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(313, 218);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(75, 23);
            this.btnCloseForm.TabIndex = 3;
            this.btnCloseForm.Text = "Done";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFortificationLevelMax
            // 
            this.lblFortificationLevelMax.AutoSize = true;
            this.lblFortificationLevelMax.Location = new System.Drawing.Point(9, 147);
            this.lblFortificationLevelMax.Name = "lblFortificationLevelMax";
            this.lblFortificationLevelMax.Size = new System.Drawing.Size(117, 13);
            this.lblFortificationLevelMax.TabIndex = 4;
            this.lblFortificationLevelMax.Text = "lblFortificationLevelMax";
            // 
            // lblSatisfaction
            // 
            this.lblSatisfaction.AutoSize = true;
            this.lblSatisfaction.Location = new System.Drawing.Point(9, 90);
            this.lblSatisfaction.Name = "lblSatisfaction";
            this.lblSatisfaction.Size = new System.Drawing.Size(72, 13);
            this.lblSatisfaction.TabIndex = 5;
            this.lblSatisfaction.Text = "lblSatisfaction";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 174);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(70, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "lblDescription";
            // 
            // CityInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 270);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSatisfaction);
            this.Controls.Add(this.lblFortificationLevelMax);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblCityName);
            this.Controls.Add(this.lblBaseIncome);
            this.Controls.Add(this.lblFortificationLevel);
            this.Name = "CityInfoForm";
            this.Text = "CityInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFortificationLevel;
        private System.Windows.Forms.Label lblBaseIncome;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Label lblFortificationLevelMax;
        private System.Windows.Forms.Label lblSatisfaction;
        private System.Windows.Forms.Label lblDescription;
    }
}