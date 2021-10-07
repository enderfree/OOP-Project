
namespace LasS2project
{
    partial class Form6
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
            this.lbToday = new System.Windows.Forms.Label();
            this.lbEnterIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbToday
            // 
            this.lbToday.AutoSize = true;
            this.lbToday.Location = new System.Drawing.Point(116, 21);
            this.lbToday.Name = "lbToday";
            this.lbToday.Size = new System.Drawing.Size(56, 17);
            this.lbToday.TabIndex = 0;
            this.lbToday.Text = "Today: ";
            // 
            // lbEnterIP
            // 
            this.lbEnterIP.AutoSize = true;
            this.lbEnterIP.Location = new System.Drawing.Point(22, 83);
            this.lbEnterIP.Name = "lbEnterIP";
            this.lbEnterIP.Size = new System.Drawing.Size(125, 17);
            this.lbEnterIP.TabIndex = 1;
            this.lbEnterIP.Text = "Enter IP address : ";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(153, 80);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(234, 22);
            this.txtIP.TabIndex = 2;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(39, 154);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(98, 42);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.Text = "Validate IP";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(163, 154);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(97, 42);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(298, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 42);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 224);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lbEnterIP);
            this.Controls.Add(this.lbToday);
            this.Name = "Form6";
            this.Text = "IP4-Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbToday;
        private System.Windows.Forms.Label lbEnterIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}