namespace FruitCalculator
{
    partial class Form1
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
            this.lblNoOfFruits = new System.Windows.Forms.Label();
            this.txtFruits = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.txtDozens = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeftOver = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNoOfFruits
            // 
            this.lblNoOfFruits.AutoSize = true;
            this.lblNoOfFruits.Location = new System.Drawing.Point(54, 47);
            this.lblNoOfFruits.Name = "lblNoOfFruits";
            this.lblNoOfFruits.Size = new System.Drawing.Size(91, 20);
            this.lblNoOfFruits.TabIndex = 0;
            this.lblNoOfFruits.Text = "No of Fruits";
            // 
            // txtFruits
            // 
            this.txtFruits.Location = new System.Drawing.Point(178, 41);
            this.txtFruits.Name = "txtFruits";
            this.txtFruits.Size = new System.Drawing.Size(224, 26);
            this.txtFruits.TabIndex = 1;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(226, 95);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(128, 37);
            this.btnCompute.TabIndex = 2;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // txtDozens
            // 
            this.txtDozens.Location = new System.Drawing.Point(178, 162);
            this.txtDozens.Name = "txtDozens";
            this.txtDozens.ReadOnly = true;
            this.txtDozens.Size = new System.Drawing.Size(224, 26);
            this.txtDozens.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dozens";
            // 
            // txtLeftOver
            // 
            this.txtLeftOver.Location = new System.Drawing.Point(178, 220);
            this.txtLeftOver.Name = "txtLeftOver";
            this.txtLeftOver.ReadOnly = true;
            this.txtLeftOver.Size = new System.Drawing.Size(224, 26);
            this.txtLeftOver.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Left Over";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 291);
            this.Controls.Add(this.txtLeftOver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDozens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.txtFruits);
            this.Controls.Add(this.lblNoOfFruits);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoOfFruits;
        private System.Windows.Forms.TextBox txtFruits;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.TextBox txtDozens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLeftOver;
        private System.Windows.Forms.Label label3;
    }
}

