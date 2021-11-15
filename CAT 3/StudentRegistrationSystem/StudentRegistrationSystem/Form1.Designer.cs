namespace StudentRegistrationSystem
{
    partial class StudentRegistrationSystem
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
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblOtherNames = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblModeOfStudy = new System.Windows.Forms.Label();
            this.lblFavoriteSport = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtOtherNames = new System.Windows.Forms.TextBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.cboSubCounty = new System.Windows.Forms.ComboBox();
            this.rdoFullTime = new System.Windows.Forms.RadioButton();
            this.cboxSoccer = new System.Windows.Forms.CheckBox();
            this.cboxBasketBall = new System.Windows.Forms.CheckBox();
            this.cboxHockey = new System.Windows.Forms.CheckBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.rdoPartTime = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 21);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(92, 25);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname";
            // 
            // lblOtherNames
            // 
            this.lblOtherNames.AutoSize = true;
            this.lblOtherNames.Location = new System.Drawing.Point(353, 18);
            this.lblOtherNames.Name = "lblOtherNames";
            this.lblOtherNames.Size = new System.Drawing.Size(128, 25);
            this.lblOtherNames.TabIndex = 1;
            this.lblOtherNames.Text = "Other Names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "County";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sub-County";
            // 
            // lblModeOfStudy
            // 
            this.lblModeOfStudy.AutoSize = true;
            this.lblModeOfStudy.Location = new System.Drawing.Point(12, 170);
            this.lblModeOfStudy.Name = "lblModeOfStudy";
            this.lblModeOfStudy.Size = new System.Drawing.Size(139, 25);
            this.lblModeOfStudy.TabIndex = 4;
            this.lblModeOfStudy.Text = "Mode of Study";
            // 
            // lblFavoriteSport
            // 
            this.lblFavoriteSport.AutoSize = true;
            this.lblFavoriteSport.Location = new System.Drawing.Point(12, 254);
            this.lblFavoriteSport.Name = "lblFavoriteSport";
            this.lblFavoriteSport.Size = new System.Drawing.Size(134, 25);
            this.lblFavoriteSport.TabIndex = 5;
            this.lblFavoriteSport.Text = "Favorite Sport";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(112, 16);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(236, 30);
            this.txtSurname.TabIndex = 6;
            // 
            // txtOtherNames
            // 
            this.txtOtherNames.Location = new System.Drawing.Point(483, 16);
            this.txtOtherNames.Name = "txtOtherNames";
            this.txtOtherNames.Size = new System.Drawing.Size(236, 30);
            this.txtOtherNames.TabIndex = 7;
            // 
            // cboCounty
            // 
            this.cboCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(112, 84);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(236, 33);
            this.cboCounty.TabIndex = 8;
            this.cboCounty.SelectedIndexChanged += new System.EventHandler(this.cboCounty_SelectedIndexChanged);
            // 
            // cboSubCounty
            // 
            this.cboSubCounty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubCounty.FormattingEnabled = true;
            this.cboSubCounty.Location = new System.Drawing.Point(483, 84);
            this.cboSubCounty.Name = "cboSubCounty";
            this.cboSubCounty.Size = new System.Drawing.Size(236, 33);
            this.cboSubCounty.TabIndex = 9;
            // 
            // rdoFullTime
            // 
            this.rdoFullTime.AutoSize = true;
            this.rdoFullTime.Location = new System.Drawing.Point(243, 168);
            this.rdoFullTime.Name = "rdoFullTime";
            this.rdoFullTime.Size = new System.Drawing.Size(117, 29);
            this.rdoFullTime.TabIndex = 10;
            this.rdoFullTime.TabStop = true;
            this.rdoFullTime.Text = "Full Time";
            this.rdoFullTime.UseVisualStyleBackColor = true;
            // 
            // cboxSoccer
            // 
            this.cboxSoccer.AutoSize = true;
            this.cboxSoccer.Location = new System.Drawing.Point(158, 254);
            this.cboxSoccer.Name = "cboxSoccer";
            this.cboxSoccer.Size = new System.Drawing.Size(100, 29);
            this.cboxSoccer.TabIndex = 12;
            this.cboxSoccer.Text = "Soccer";
            this.cboxSoccer.UseVisualStyleBackColor = true;
            // 
            // cboxBasketBall
            // 
            this.cboxBasketBall.AutoSize = true;
            this.cboxBasketBall.Location = new System.Drawing.Point(261, 253);
            this.cboxBasketBall.Name = "cboxBasketBall";
            this.cboxBasketBall.Size = new System.Drawing.Size(135, 29);
            this.cboxBasketBall.TabIndex = 13;
            this.cboxBasketBall.Text = "Basket Ball";
            this.cboxBasketBall.UseVisualStyleBackColor = true;
            // 
            // cboxHockey
            // 
            this.cboxHockey.AutoSize = true;
            this.cboxHockey.Location = new System.Drawing.Point(403, 251);
            this.cboxHockey.Name = "cboxHockey";
            this.cboxHockey.Size = new System.Drawing.Size(104, 29);
            this.cboxHockey.TabIndex = 14;
            this.cboxHockey.Text = "Hockey";
            this.cboxHockey.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(17, 341);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(140, 35);
            this.btnRecord.TabIndex = 15;
            this.btnRecord.Text = "Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(172, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 35);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 25;
            this.lstResults.Location = new System.Drawing.Point(738, 16);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(456, 379);
            this.lstResults.TabIndex = 17;
            // 
            // rdoPartTime
            // 
            this.rdoPartTime.AutoSize = true;
            this.rdoPartTime.Location = new System.Drawing.Point(366, 166);
            this.rdoPartTime.Name = "rdoPartTime";
            this.rdoPartTime.Size = new System.Drawing.Size(121, 29);
            this.rdoPartTime.TabIndex = 18;
            this.rdoPartTime.Text = "Part Time";
            this.rdoPartTime.UseVisualStyleBackColor = true;
            // 
            // StudentRegistrationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 412);
            this.Controls.Add(this.rdoPartTime);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.cboxHockey);
            this.Controls.Add(this.cboxBasketBall);
            this.Controls.Add(this.cboxSoccer);
            this.Controls.Add(this.rdoFullTime);
            this.Controls.Add(this.cboSubCounty);
            this.Controls.Add(this.cboCounty);
            this.Controls.Add(this.txtOtherNames);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblFavoriteSport);
            this.Controls.Add(this.lblModeOfStudy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOtherNames);
            this.Controls.Add(this.lblSurname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StudentRegistrationSystem";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.StudentRegistrationSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblOtherNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblModeOfStudy;
        private System.Windows.Forms.Label lblFavoriteSport;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtOtherNames;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.ComboBox cboSubCounty;
        private System.Windows.Forms.RadioButton rdoFullTime;
        private System.Windows.Forms.CheckBox cboxSoccer;
        private System.Windows.Forms.CheckBox cboxBasketBall;
        private System.Windows.Forms.CheckBox cboxHockey;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.RadioButton rdoPartTime;
    }
}

