
namespace LasS2project
{
    partial class Form4
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
            this.gbFrom = new System.Windows.Forms.GroupBox();
            this.rbFromRUB = new System.Windows.Forms.RadioButton();
            this.rbFromGBP = new System.Windows.Forms.RadioButton();
            this.rbFromEUR = new System.Windows.Forms.RadioButton();
            this.rbFromUSD = new System.Windows.Forms.RadioButton();
            this.rbFromCAD = new System.Windows.Forms.RadioButton();
            this.gbTo = new System.Windows.Forms.GroupBox();
            this.rbToRUB = new System.Windows.Forms.RadioButton();
            this.rbToGBP = new System.Windows.Forms.RadioButton();
            this.rbToEUR = new System.Windows.Forms.RadioButton();
            this.rbToUSD = new System.Windows.Forms.RadioButton();
            this.rbToCAD = new System.Windows.Forms.RadioButton();
            this.txtInputAmmount = new System.Windows.Forms.TextBox();
            this.txtOutputAmmount = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbFrom.SuspendLayout();
            this.gbTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFrom
            // 
            this.gbFrom.Controls.Add(this.rbFromRUB);
            this.gbFrom.Controls.Add(this.rbFromGBP);
            this.gbFrom.Controls.Add(this.rbFromEUR);
            this.gbFrom.Controls.Add(this.rbFromUSD);
            this.gbFrom.Controls.Add(this.rbFromCAD);
            this.gbFrom.Location = new System.Drawing.Point(12, 25);
            this.gbFrom.Name = "gbFrom";
            this.gbFrom.Size = new System.Drawing.Size(151, 179);
            this.gbFrom.TabIndex = 0;
            this.gbFrom.TabStop = false;
            this.gbFrom.Text = "From";
            // 
            // rbFromRUB
            // 
            this.rbFromRUB.AutoSize = true;
            this.rbFromRUB.Location = new System.Drawing.Point(19, 144);
            this.rbFromRUB.Name = "rbFromRUB";
            this.rbFromRUB.Size = new System.Drawing.Size(58, 21);
            this.rbFromRUB.TabIndex = 4;
            this.rbFromRUB.TabStop = true;
            this.rbFromRUB.Text = "RUB";
            this.rbFromRUB.UseVisualStyleBackColor = true;
            // 
            // rbFromGBP
            // 
            this.rbFromGBP.AutoSize = true;
            this.rbFromGBP.Location = new System.Drawing.Point(19, 117);
            this.rbFromGBP.Name = "rbFromGBP";
            this.rbFromGBP.Size = new System.Drawing.Size(58, 21);
            this.rbFromGBP.TabIndex = 3;
            this.rbFromGBP.TabStop = true;
            this.rbFromGBP.Text = "GBP";
            this.rbFromGBP.UseVisualStyleBackColor = true;
            // 
            // rbFromEUR
            // 
            this.rbFromEUR.AutoSize = true;
            this.rbFromEUR.Location = new System.Drawing.Point(19, 90);
            this.rbFromEUR.Name = "rbFromEUR";
            this.rbFromEUR.Size = new System.Drawing.Size(58, 21);
            this.rbFromEUR.TabIndex = 2;
            this.rbFromEUR.TabStop = true;
            this.rbFromEUR.Text = "EUR";
            this.rbFromEUR.UseVisualStyleBackColor = true;
            // 
            // rbFromUSD
            // 
            this.rbFromUSD.AutoSize = true;
            this.rbFromUSD.Location = new System.Drawing.Point(19, 59);
            this.rbFromUSD.Name = "rbFromUSD";
            this.rbFromUSD.Size = new System.Drawing.Size(58, 21);
            this.rbFromUSD.TabIndex = 1;
            this.rbFromUSD.TabStop = true;
            this.rbFromUSD.Text = "USD";
            this.rbFromUSD.UseVisualStyleBackColor = true;
            // 
            // rbFromCAD
            // 
            this.rbFromCAD.AutoSize = true;
            this.rbFromCAD.Checked = true;
            this.rbFromCAD.Location = new System.Drawing.Point(19, 32);
            this.rbFromCAD.Name = "rbFromCAD";
            this.rbFromCAD.Size = new System.Drawing.Size(57, 21);
            this.rbFromCAD.TabIndex = 0;
            this.rbFromCAD.TabStop = true;
            this.rbFromCAD.Text = "CAD";
            this.rbFromCAD.UseVisualStyleBackColor = true;
            // 
            // gbTo
            // 
            this.gbTo.Controls.Add(this.rbToRUB);
            this.gbTo.Controls.Add(this.rbToGBP);
            this.gbTo.Controls.Add(this.rbToEUR);
            this.gbTo.Controls.Add(this.rbToUSD);
            this.gbTo.Controls.Add(this.rbToCAD);
            this.gbTo.Location = new System.Drawing.Point(226, 25);
            this.gbTo.Name = "gbTo";
            this.gbTo.Size = new System.Drawing.Size(151, 179);
            this.gbTo.TabIndex = 5;
            this.gbTo.TabStop = false;
            this.gbTo.Text = "To";
            // 
            // rbToRUB
            // 
            this.rbToRUB.AutoSize = true;
            this.rbToRUB.Location = new System.Drawing.Point(19, 144);
            this.rbToRUB.Name = "rbToRUB";
            this.rbToRUB.Size = new System.Drawing.Size(58, 21);
            this.rbToRUB.TabIndex = 4;
            this.rbToRUB.TabStop = true;
            this.rbToRUB.Text = "RUB";
            this.rbToRUB.UseVisualStyleBackColor = true;
            // 
            // rbToGBP
            // 
            this.rbToGBP.AutoSize = true;
            this.rbToGBP.Location = new System.Drawing.Point(19, 117);
            this.rbToGBP.Name = "rbToGBP";
            this.rbToGBP.Size = new System.Drawing.Size(58, 21);
            this.rbToGBP.TabIndex = 3;
            this.rbToGBP.TabStop = true;
            this.rbToGBP.Text = "GBP";
            this.rbToGBP.UseVisualStyleBackColor = true;
            // 
            // rbToEUR
            // 
            this.rbToEUR.AutoSize = true;
            this.rbToEUR.Location = new System.Drawing.Point(19, 90);
            this.rbToEUR.Name = "rbToEUR";
            this.rbToEUR.Size = new System.Drawing.Size(58, 21);
            this.rbToEUR.TabIndex = 2;
            this.rbToEUR.TabStop = true;
            this.rbToEUR.Text = "EUR";
            this.rbToEUR.UseVisualStyleBackColor = true;
            // 
            // rbToUSD
            // 
            this.rbToUSD.AutoSize = true;
            this.rbToUSD.Location = new System.Drawing.Point(19, 59);
            this.rbToUSD.Name = "rbToUSD";
            this.rbToUSD.Size = new System.Drawing.Size(58, 21);
            this.rbToUSD.TabIndex = 1;
            this.rbToUSD.TabStop = true;
            this.rbToUSD.Text = "USD";
            this.rbToUSD.UseVisualStyleBackColor = true;
            // 
            // rbToCAD
            // 
            this.rbToCAD.AutoSize = true;
            this.rbToCAD.Checked = true;
            this.rbToCAD.Location = new System.Drawing.Point(19, 32);
            this.rbToCAD.Name = "rbToCAD";
            this.rbToCAD.Size = new System.Drawing.Size(57, 21);
            this.rbToCAD.TabIndex = 0;
            this.rbToCAD.TabStop = true;
            this.rbToCAD.Text = "CAD";
            this.rbToCAD.UseVisualStyleBackColor = true;
            // 
            // txtInputAmmount
            // 
            this.txtInputAmmount.Location = new System.Drawing.Point(12, 210);
            this.txtInputAmmount.Name = "txtInputAmmount";
            this.txtInputAmmount.Size = new System.Drawing.Size(111, 22);
            this.txtInputAmmount.TabIndex = 6;
            // 
            // txtOutputAmmount
            // 
            this.txtOutputAmmount.Location = new System.Drawing.Point(226, 210);
            this.txtOutputAmmount.Name = "txtOutputAmmount";
            this.txtOutputAmmount.ReadOnly = true;
            this.txtOutputAmmount.Size = new System.Drawing.Size(111, 22);
            this.txtOutputAmmount.TabIndex = 7;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 254);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(84, 27);
            this.btnConvert.TabIndex = 8;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(169, 254);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(84, 27);
            this.btnReadFile.TabIndex = 9;
            this.btnReadFile.Text = "&Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(282, 254);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 27);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 312);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtOutputAmmount);
            this.Controls.Add(this.txtInputAmmount);
            this.Controls.Add(this.gbTo);
            this.Controls.Add(this.gbFrom);
            this.Name = "Form4";
            this.Text = "MoneyEx - Samuel";
            this.gbFrom.ResumeLayout(false);
            this.gbFrom.PerformLayout();
            this.gbTo.ResumeLayout(false);
            this.gbTo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFrom;
        private System.Windows.Forms.RadioButton rbFromRUB;
        private System.Windows.Forms.RadioButton rbFromGBP;
        private System.Windows.Forms.RadioButton rbFromEUR;
        private System.Windows.Forms.RadioButton rbFromUSD;
        private System.Windows.Forms.RadioButton rbFromCAD;
        private System.Windows.Forms.GroupBox gbTo;
        private System.Windows.Forms.RadioButton rbToRUB;
        private System.Windows.Forms.RadioButton rbToGBP;
        private System.Windows.Forms.RadioButton rbToEUR;
        private System.Windows.Forms.RadioButton rbToUSD;
        private System.Windows.Forms.RadioButton rbToCAD;
        private System.Windows.Forms.TextBox txtInputAmmount;
        private System.Windows.Forms.TextBox txtOutputAmmount;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnExit;
    }
}