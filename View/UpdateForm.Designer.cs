
namespace View
{
    partial class UpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbSpecies = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.nudCageNumber = new System.Windows.Forms.NumericUpDown();
            this.cbxPregnant = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lsbTempreture = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCageNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Species:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cage Number:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(113, 10);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 23);
            this.txbName.TabIndex = 6;
            // 
            // txbSpecies
            // 
            this.txbSpecies.Location = new System.Drawing.Point(113, 60);
            this.txbSpecies.Name = "txbSpecies";
            this.txbSpecies.Size = new System.Drawing.Size(100, 23);
            this.txbSpecies.TabIndex = 7;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(113, 114);
            this.nudAge.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(120, 23);
            this.nudAge.TabIndex = 8;
            // 
            // nudCageNumber
            // 
            this.nudCageNumber.Location = new System.Drawing.Point(113, 164);
            this.nudCageNumber.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudCageNumber.Name = "nudCageNumber";
            this.nudCageNumber.Size = new System.Drawing.Size(120, 23);
            this.nudCageNumber.TabIndex = 9;
            // 
            // cbxPregnant
            // 
            this.cbxPregnant.AutoSize = true;
            this.cbxPregnant.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbxPregnant.Location = new System.Drawing.Point(12, 201);
            this.cbxPregnant.Name = "cbxPregnant";
            this.cbxPregnant.Size = new System.Drawing.Size(79, 19);
            this.cbxPregnant.TabIndex = 10;
            this.cbxPregnant.Text = "Pregnant?";
            this.cbxPregnant.UseVisualStyleBackColor = true;
            this.cbxPregnant.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(423, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lsbTempreture
            // 
            this.lsbTempreture.FormattingEnabled = true;
            this.lsbTempreture.ItemHeight = 15;
            this.lsbTempreture.Location = new System.Drawing.Point(423, 12);
            this.lsbTempreture.Name = "lsbTempreture";
            this.lsbTempreture.Size = new System.Drawing.Size(120, 94);
            this.lsbTempreture.TabIndex = 12;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 252);
            this.Controls.Add(this.lsbTempreture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxPregnant);
            this.Controls.Add(this.nudCageNumber);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.txbSpecies);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "Update Animal";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCageNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbSpecies;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.NumericUpDown nudCageNumber;
        private System.Windows.Forms.CheckBox cbxPregnant;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lsbTempreture;
    }
}