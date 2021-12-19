
namespace View
{
    partial class ZooApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxMamals = new System.Windows.Forms.CheckBox();
            this.cbxBirds = new System.Windows.Forms.CheckBox();
            this.cbxReptiles = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(345, 12);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowTemplate.Height = 25;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(443, 387);
            this.dgvData.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(40, 68);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create new";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(40, 108);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 64);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Get Detailed Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(40, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Change";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(40, 248);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxMamals
            // 
            this.cbxMamals.AutoSize = true;
            this.cbxMamals.Checked = true;
            this.cbxMamals.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMamals.Location = new System.Drawing.Point(40, 336);
            this.cbxMamals.Name = "cbxMamals";
            this.cbxMamals.Size = new System.Drawing.Size(68, 19);
            this.cbxMamals.TabIndex = 5;
            this.cbxMamals.Text = "Mamals";
            this.cbxMamals.UseVisualStyleBackColor = true;
            this.cbxMamals.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // cbxBirds
            // 
            this.cbxBirds.AutoSize = true;
            this.cbxBirds.Checked = true;
            this.cbxBirds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxBirds.Location = new System.Drawing.Point(40, 361);
            this.cbxBirds.Name = "cbxBirds";
            this.cbxBirds.Size = new System.Drawing.Size(52, 19);
            this.cbxBirds.TabIndex = 6;
            this.cbxBirds.Text = "Birds";
            this.cbxBirds.UseVisualStyleBackColor = true;
            this.cbxBirds.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // cbxReptiles
            // 
            this.cbxReptiles.AutoSize = true;
            this.cbxReptiles.Checked = true;
            this.cbxReptiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxReptiles.Location = new System.Drawing.Point(40, 386);
            this.cbxReptiles.Name = "cbxReptiles";
            this.cbxReptiles.Size = new System.Drawing.Size(67, 19);
            this.cbxReptiles.TabIndex = 7;
            this.cbxReptiles.Text = "Reptiles";
            this.cbxReptiles.UseVisualStyleBackColor = true;
            this.cbxReptiles.CheckedChanged += new System.EventHandler(this.cbx_CheckedChanged);
            // 
            // ZooApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxReptiles);
            this.Controls.Add(this.cbxBirds);
            this.Controls.Add(this.cbxMamals);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvData);
            this.Name = "ZooApp";
            this.Text = "Zoo App";
            this.Load += new System.EventHandler(this.ZooApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox cbxMamals;
        private System.Windows.Forms.CheckBox cbxBirds;
        private System.Windows.Forms.CheckBox cbxReptiles;
    }
}

