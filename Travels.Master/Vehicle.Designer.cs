namespace Travels.Master
{
    partial class Vehicle
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
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbAC = new System.Windows.Forms.RadioButton();
            this.rbNonAC = new System.Windows.Forms.RadioButton();
            this.lblType = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(99, 46);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(185, 20);
            this.txtRegNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reg No:";
            // 
            // rbAC
            // 
            this.rbAC.AutoSize = true;
            this.rbAC.Location = new System.Drawing.Point(178, 81);
            this.rbAC.Name = "rbAC";
            this.rbAC.Size = new System.Drawing.Size(39, 17);
            this.rbAC.TabIndex = 2;
            this.rbAC.TabStop = true;
            this.rbAC.Text = "AC";
            this.rbAC.UseVisualStyleBackColor = true;
            // 
            // rbNonAC
            // 
            this.rbNonAC.AutoSize = true;
            this.rbNonAC.Location = new System.Drawing.Point(100, 81);
            this.rbNonAC.Name = "rbNonAC";
            this.rbNonAC.Size = new System.Drawing.Size(59, 17);
            this.rbNonAC.TabIndex = 3;
            this.rbNonAC.TabStop = true;
            this.rbNonAC.Text = "NonAC";
            this.rbNonAC.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(49, 81);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(49, 113);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(100, 113);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(184, 20);
            this.txtModel.TabIndex = 7;
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 286);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.rbNonAC);
            this.Controls.Add(this.rbAC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegNo);
            this.Name = "Vehicle";
            this.Text = "Vehicle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbAC;
        private System.Windows.Forms.RadioButton rbNonAC;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
    }
}