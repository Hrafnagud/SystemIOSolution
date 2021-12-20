
namespace SystemIOWindowsFormApp
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
            this.groupBoxPersonnelList = new System.Windows.Forms.GroupBox();
            this.groupBoxPersonnelDetail = new System.Windows.Forms.GroupBox();
            this.listBoxPersonnel = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textCompany = new System.Windows.Forms.TextBox();
            this.textCountry = new System.Windows.Forms.TextBox();
            this.btnBringPersonnel = new System.Windows.Forms.Button();
            this.btnPersonnelInfoSave = new System.Windows.Forms.Button();
            this.groupBoxPersonnelList.SuspendLayout();
            this.groupBoxPersonnelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPersonnelList
            // 
            this.groupBoxPersonnelList.Controls.Add(this.listBoxPersonnel);
            this.groupBoxPersonnelList.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPersonnelList.Name = "groupBoxPersonnelList";
            this.groupBoxPersonnelList.Size = new System.Drawing.Size(330, 497);
            this.groupBoxPersonnelList.TabIndex = 0;
            this.groupBoxPersonnelList.TabStop = false;
            this.groupBoxPersonnelList.Text = "Personnel List";
            // 
            // groupBoxPersonnelDetail
            // 
            this.groupBoxPersonnelDetail.Controls.Add(this.textCountry);
            this.groupBoxPersonnelDetail.Controls.Add(this.textCompany);
            this.groupBoxPersonnelDetail.Controls.Add(this.textEmail);
            this.groupBoxPersonnelDetail.Controls.Add(this.textSurname);
            this.groupBoxPersonnelDetail.Controls.Add(this.textName);
            this.groupBoxPersonnelDetail.Controls.Add(this.label1);
            this.groupBoxPersonnelDetail.Controls.Add(this.label2);
            this.groupBoxPersonnelDetail.Controls.Add(this.label3);
            this.groupBoxPersonnelDetail.Controls.Add(this.label4);
            this.groupBoxPersonnelDetail.Controls.Add(this.label5);
            this.groupBoxPersonnelDetail.Location = new System.Drawing.Point(397, 12);
            this.groupBoxPersonnelDetail.Name = "groupBoxPersonnelDetail";
            this.groupBoxPersonnelDetail.Size = new System.Drawing.Size(801, 368);
            this.groupBoxPersonnelDetail.TabIndex = 0;
            this.groupBoxPersonnelDetail.TabStop = false;
            this.groupBoxPersonnelDetail.Text = "PersonnelDetail";
            // 
            // listBoxPersonnel
            // 
            this.listBoxPersonnel.FormattingEnabled = true;
            this.listBoxPersonnel.ItemHeight = 16;
            this.listBoxPersonnel.Location = new System.Drawing.Point(6, 35);
            this.listBoxPersonnel.Name = "listBoxPersonnel";
            this.listBoxPersonnel.Size = new System.Drawing.Size(318, 452);
            this.listBoxPersonnel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Company:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Country:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(127, 44);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(515, 22);
            this.textName.TabIndex = 1;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(127, 77);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(515, 22);
            this.textSurname.TabIndex = 6;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(127, 116);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(515, 22);
            this.textEmail.TabIndex = 7;
            // 
            // textCompany
            // 
            this.textCompany.Location = new System.Drawing.Point(127, 155);
            this.textCompany.Name = "textCompany";
            this.textCompany.Size = new System.Drawing.Size(515, 22);
            this.textCompany.TabIndex = 8;
            // 
            // textCountry
            // 
            this.textCountry.Location = new System.Drawing.Point(127, 194);
            this.textCountry.Name = "textCountry";
            this.textCountry.Size = new System.Drawing.Size(515, 22);
            this.textCountry.TabIndex = 9;
            // 
            // btnBringPersonnel
            // 
            this.btnBringPersonnel.Location = new System.Drawing.Point(12, 541);
            this.btnBringPersonnel.Name = "btnBringPersonnel";
            this.btnBringPersonnel.Size = new System.Drawing.Size(324, 82);
            this.btnBringPersonnel.TabIndex = 10;
            this.btnBringPersonnel.Text = "VIEW PERSONNEL INFORMATION";
            this.btnBringPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnPersonnelInfoSave
            // 
            this.btnPersonnelInfoSave.Location = new System.Drawing.Point(397, 430);
            this.btnPersonnelInfoSave.Name = "btnPersonnelInfoSave";
            this.btnPersonnelInfoSave.Size = new System.Drawing.Size(801, 79);
            this.btnPersonnelInfoSave.TabIndex = 11;
            this.btnPersonnelInfoSave.Text = "SAVE PERSONNEL INFORMATION TO MY COMPUTER";
            this.btnPersonnelInfoSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 719);
            this.Controls.Add(this.btnPersonnelInfoSave);
            this.Controls.Add(this.btnBringPersonnel);
            this.Controls.Add(this.groupBoxPersonnelDetail);
            this.Controls.Add(this.groupBoxPersonnelList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPersonnelList.ResumeLayout(false);
            this.groupBoxPersonnelDetail.ResumeLayout(false);
            this.groupBoxPersonnelDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonnelList;
        private System.Windows.Forms.ListBox listBoxPersonnel;
        private System.Windows.Forms.GroupBox groupBoxPersonnelDetail;
        private System.Windows.Forms.TextBox textCountry;
        private System.Windows.Forms.TextBox textCompany;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBringPersonnel;
        private System.Windows.Forms.Button btnPersonnelInfoSave;
    }
}

