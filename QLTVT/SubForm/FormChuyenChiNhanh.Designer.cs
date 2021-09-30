
namespace QLTVT.SubForm
{
    partial class FormChuyenChiNhanh
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
            this.cmbCHINHANH = new System.Windows.Forms.ComboBox();
            this.btnXACNHAN = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(100, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHUYỂN CHI NHÁNH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCHINHANH
            // 
            this.cmbCHINHANH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCHINHANH.FormattingEnabled = true;
            this.cmbCHINHANH.Location = new System.Drawing.Point(106, 109);
            this.cmbCHINHANH.Name = "cmbCHINHANH";
            this.cmbCHINHANH.Size = new System.Drawing.Size(294, 24);
            this.cmbCHINHANH.TabIndex = 4;
            // 
            // btnXACNHAN
            // 
            this.btnXACNHAN.BackColor = System.Drawing.Color.Blue;
            this.btnXACNHAN.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnXACNHAN.ForeColor = System.Drawing.Color.White;
            this.btnXACNHAN.Location = new System.Drawing.Point(106, 190);
            this.btnXACNHAN.Name = "btnXACNHAN";
            this.btnXACNHAN.Size = new System.Drawing.Size(136, 35);
            this.btnXACNHAN.TabIndex = 5;
            this.btnXACNHAN.Text = "XÁC NHẬN";
            this.btnXACNHAN.UseVisualStyleBackColor = false;
            this.btnXACNHAN.Click += new System.EventHandler(this.btnXACNHAN_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.BackColor = System.Drawing.Color.Red;
            this.btnTHOAT.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnTHOAT.ForeColor = System.Drawing.Color.White;
            this.btnTHOAT.Location = new System.Drawing.Point(264, 190);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(136, 35);
            this.btnTHOAT.TabIndex = 6;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = false;
            // 
            // FormChuyenChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 285);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnXACNHAN);
            this.Controls.Add(this.cmbCHINHANH);
            this.Controls.Add(this.label1);
            this.Name = "FormChuyenChiNhanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển Chi Nhánh";
            this.Load += new System.EventHandler(this.FormChuyenChiNhanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCHINHANH;
        private System.Windows.Forms.Button btnXACNHAN;
        private System.Windows.Forms.Button btnTHOAT;
    }
}