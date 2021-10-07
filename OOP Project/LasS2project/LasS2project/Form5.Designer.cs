
namespace LasS2project
{
    partial class Form5
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
            this.rbCToF = new System.Windows.Forms.RadioButton();
            this.rbFToC = new System.Windows.Forms.RadioButton();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lbConjunction = new System.Windows.Forms.Label();
            this.lbFrom = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.lbTo = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbCToF
            // 
            this.rbCToF.AutoSize = true;
            this.rbCToF.Checked = true;
            this.rbCToF.Location = new System.Drawing.Point(105, 36);
            this.rbCToF.Name = "rbCToF";
            this.rbCToF.Size = new System.Drawing.Size(98, 21);
            this.rbCToF.TabIndex = 0;
            this.rbCToF.TabStop = true;
            this.rbCToF.Text = "from C to F";
            this.rbCToF.UseVisualStyleBackColor = true;
            this.rbCToF.CheckedChanged += new System.EventHandler(this.rbCToF_CheckedChanged);
            // 
            // rbFToC
            // 
            this.rbFToC.AutoSize = true;
            this.rbFToC.Location = new System.Drawing.Point(105, 63);
            this.rbFToC.Name = "rbFToC";
            this.rbFToC.Size = new System.Drawing.Size(98, 21);
            this.rbFToC.TabIndex = 1;
            this.rbFToC.Text = "from F to C";
            this.rbFToC.UseVisualStyleBackColor = true;
            this.rbFToC.CheckedChanged += new System.EventHandler(this.rbFToC_CheckedChanged);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(15, 100);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(124, 22);
            this.txtFrom.TabIndex = 2;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(171, 100);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(124, 22);
            this.txtTo.TabIndex = 3;
            // 
            // lbConjunction
            // 
            this.lbConjunction.AutoSize = true;
            this.lbConjunction.Location = new System.Drawing.Point(145, 103);
            this.lbConjunction.Name = "lbConjunction";
            this.lbConjunction.Size = new System.Drawing.Size(20, 17);
            this.lbConjunction.TabIndex = 4;
            this.lbConjunction.Text = "to";
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFrom.Location = new System.Drawing.Point(68, 125);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(22, 20);
            this.lbFrom.TabIndex = 5;
            this.lbFrom.Text = "C";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(12, 164);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(73, 17);
            this.lbMessage.TabIndex = 7;
            this.lbMessage.Text = "Message: ";
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTo.Location = new System.Drawing.Point(227, 125);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(20, 20);
            this.lbTo.TabIndex = 8;
            this.lbTo.Text = "F";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 184);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(281, 78);
            this.txtMessage.TabIndex = 9;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(10, 268);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 30);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(110, 268);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(82, 30);
            this.btnReadFile.TabIndex = 11;
            this.btnReadFile.Text = "&Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(220, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 308);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.lbConjunction);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.rbFToC);
            this.Controls.Add(this.rbCToF);
            this.Name = "Form5";
            this.Text = "Temp App - Samuel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbCToF;
        private System.Windows.Forms.RadioButton rbFToC;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lbConjunction;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnExit;
    }
}