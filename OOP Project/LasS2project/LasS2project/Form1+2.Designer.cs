
namespace LasS2project
{
    partial class Form1_2
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
            this.lbWinningNb = new System.Windows.Forms.Label();
            this.txtLottoNb = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWinningNb
            // 
            this.lbWinningNb.AutoSize = true;
            this.lbWinningNb.Location = new System.Drawing.Point(28, 30);
            this.lbWinningNb.Name = "lbWinningNb";
            this.lbWinningNb.Size = new System.Drawing.Size(176, 17);
            this.lbWinningNb.TabIndex = 0;
            this.lbWinningNb.Text = "The winning numbers are: ";
            // 
            // txtLottoNb
            // 
            this.txtLottoNb.BackColor = System.Drawing.SystemColors.Window;
            this.txtLottoNb.Location = new System.Drawing.Point(210, 30);
            this.txtLottoNb.Multiline = true;
            this.txtLottoNb.Name = "txtLottoNb";
            this.txtLottoNb.ReadOnly = true;
            this.txtLottoNb.Size = new System.Drawing.Size(72, 244);
            this.txtLottoNb.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(10, 302);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(94, 33);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(119, 302);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(94, 33);
            this.btnReadFile.TabIndex = 3;
            this.btnReadFile.Text = "&Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(219, 302);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 369);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtLottoNb);
            this.Controls.Add(this.lbWinningNb);
            this.Name = "Form1_2";
            this.Text = "Lotto - Samuel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWinningNb;
        private System.Windows.Forms.TextBox txtLottoNb;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnExit;
    }
}