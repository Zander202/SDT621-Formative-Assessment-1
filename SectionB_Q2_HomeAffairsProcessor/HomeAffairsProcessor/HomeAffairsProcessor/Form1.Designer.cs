using System;
using System.Drawing;
using System.Windows.Forms;

namespace HomeAffairsProcessor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblName;
        private Label lblID;
        private Label lblCitizenship;
        private Label lblResult;
        private TextBox txtName;
        private TextBox txtID;
        private ComboBox cmbCitizenship;
        private Button btnValidate;
        private Button btnGenerate;
        private TextBox txtSummary;
        private PictureBox picCoatOfArms;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCitizenship = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbCitizenship = new System.Windows.Forms.ComboBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.picCoatOfArms = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCoatOfArms)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTitle.Location = new System.Drawing.Point(370, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(590, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Home Affairs Digital Identity Processor";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 11F);
            this.lblName.Location = new System.Drawing.Point(390, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 30);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Enter your Name:";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Arial", 11F);
            this.lblID.Location = new System.Drawing.Point(390, 170);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(160, 30);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "Enter your ID:";
            // 
            // lblCitizenship
            // 
            this.lblCitizenship.BackColor = System.Drawing.Color.Transparent;
            this.lblCitizenship.Font = new System.Drawing.Font("Arial", 11F);
            this.lblCitizenship.Location = new System.Drawing.Point(390, 230);
            this.lblCitizenship.Name = "lblCitizenship";
            this.lblCitizenship.Size = new System.Drawing.Size(180, 30);
            this.lblCitizenship.TabIndex = 6;
            this.lblCitizenship.Text = "Choose your Citizen:";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Arial", 10F);
            this.lblResult.Location = new System.Drawing.Point(590, 340);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(350, 30);
            this.lblResult.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 11F);
            this.txtName.Location = new System.Drawing.Point(590, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 24);
            this.txtName.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial", 11F);
            this.txtID.Location = new System.Drawing.Point(590, 167);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(300, 24);
            this.txtID.TabIndex = 5;
            // 
            // cmbCitizenship
            // 
            this.cmbCitizenship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCitizenship.Font = new System.Drawing.Font("Arial", 11F);
            this.cmbCitizenship.Items.AddRange(new object[] {
            "South African",
            "Permanent Resident",
            "Visitor"});
            this.cmbCitizenship.Location = new System.Drawing.Point(590, 227);
            this.cmbCitizenship.Name = "cmbCitizenship";
            this.cmbCitizenship.Size = new System.Drawing.Size(300, 25);
            this.cmbCitizenship.TabIndex = 7;
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnValidate.ForeColor = System.Drawing.Color.White;
            this.btnValidate.Location = new System.Drawing.Point(700, 285);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(140, 38);
            this.btnValidate.TabIndex = 8;
            this.btnValidate.Text = "Validate ID";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(700, 615);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(160, 38);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate profile";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtSummary
            // 
            this.txtSummary.BackColor = System.Drawing.Color.White;
            this.txtSummary.Font = new System.Drawing.Font("Courier New", 9F);
            this.txtSummary.Location = new System.Drawing.Point(590, 385);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSummary.Size = new System.Drawing.Size(350, 210);
            this.txtSummary.TabIndex = 10;
            // 
            // picCoatOfArms
            // 
            this.picCoatOfArms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.picCoatOfArms.Image = Properties.Resources.coat_of_arms_of_south_africa_seeklogo;
            this.picCoatOfArms.Location = new System.Drawing.Point(30, 80);
            this.picCoatOfArms.Name = "picCoatOfArms";
            this.picCoatOfArms.Size = new System.Drawing.Size(310, 540);
            this.picCoatOfArms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoatOfArms.TabIndex = 0;
            this.picCoatOfArms.TabStop = false;
            this.picCoatOfArms.Click += new System.EventHandler(this.picCoatOfArms_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.picCoatOfArms);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCitizenship);
            this.Controls.Add(this.cmbCitizenship);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCoatOfArms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.Form1_Load);

        }
    }
}