
namespace LasS2project
{
    partial class Form0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            this.tabDashboard = new System.Windows.Forms.TabControl();
            this.tabPGeneratedNumbers = new System.Windows.Forms.TabPage();
            this.gbLotto = new System.Windows.Forms.GroupBox();
            this.lb649 = new System.Windows.Forms.Label();
            this.lbLottoMax = new System.Windows.Forms.Label();
            this.pb649 = new System.Windows.Forms.PictureBox();
            this.pbLottoMax = new System.Windows.Forms.PictureBox();
            this.tabPConversions = new System.Windows.Forms.TabPage();
            this.gbConversions = new System.Windows.Forms.GroupBox();
            this.lbTemperature = new System.Windows.Forms.Label();
            this.lbMoneyExchange = new System.Windows.Forms.Label();
            this.pbTemperature = new System.Windows.Forms.PictureBox();
            this.pbMoneyExchange = new System.Windows.Forms.PictureBox();
            this.tabPSimpleCalculator = new System.Windows.Forms.TabPage();
            this.pbCalculator = new System.Windows.Forms.PictureBox();
            this.tabPIPV4Validator = new System.Windows.Forms.TabPage();
            this.pbIP = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabDashboard.SuspendLayout();
            this.tabPGeneratedNumbers.SuspendLayout();
            this.gbLotto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb649)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLottoMax)).BeginInit();
            this.tabPConversions.SuspendLayout();
            this.gbConversions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoneyExchange)).BeginInit();
            this.tabPSimpleCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculator)).BeginInit();
            this.tabPIPV4Validator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIP)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.tabPGeneratedNumbers);
            this.tabDashboard.Controls.Add(this.tabPConversions);
            this.tabDashboard.Controls.Add(this.tabPSimpleCalculator);
            this.tabDashboard.Controls.Add(this.tabPIPV4Validator);
            this.tabDashboard.Location = new System.Drawing.Point(33, 12);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.SelectedIndex = 0;
            this.tabDashboard.Size = new System.Drawing.Size(661, 357);
            this.tabDashboard.TabIndex = 0;
            // 
            // tabPGeneratedNumbers
            // 
            this.tabPGeneratedNumbers.Controls.Add(this.gbLotto);
            this.tabPGeneratedNumbers.Location = new System.Drawing.Point(4, 25);
            this.tabPGeneratedNumbers.Name = "tabPGeneratedNumbers";
            this.tabPGeneratedNumbers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPGeneratedNumbers.Size = new System.Drawing.Size(653, 328);
            this.tabPGeneratedNumbers.TabIndex = 0;
            this.tabPGeneratedNumbers.Text = "Generated Numbers";
            this.tabPGeneratedNumbers.UseVisualStyleBackColor = true;
            // 
            // gbLotto
            // 
            this.gbLotto.Controls.Add(this.lb649);
            this.gbLotto.Controls.Add(this.lbLottoMax);
            this.gbLotto.Controls.Add(this.pb649);
            this.gbLotto.Controls.Add(this.pbLottoMax);
            this.gbLotto.Location = new System.Drawing.Point(54, 35);
            this.gbLotto.Name = "gbLotto";
            this.gbLotto.Size = new System.Drawing.Size(538, 254);
            this.gbLotto.TabIndex = 0;
            this.gbLotto.TabStop = false;
            this.gbLotto.Text = "Lotto";
            // 
            // lb649
            // 
            this.lb649.AutoSize = true;
            this.lb649.Location = new System.Drawing.Point(358, 211);
            this.lb649.Name = "lb649";
            this.lb649.Size = new System.Drawing.Size(64, 17);
            this.lb649.TabIndex = 7;
            this.lb649.Text = "Lotto649";
            // 
            // lbLottoMax
            // 
            this.lbLottoMax.AutoSize = true;
            this.lbLottoMax.Location = new System.Drawing.Point(112, 211);
            this.lbLottoMax.Name = "lbLottoMax";
            this.lbLottoMax.Size = new System.Drawing.Size(69, 17);
            this.lbLottoMax.TabIndex = 6;
            this.lbLottoMax.Text = "Lotto Max";
            // 
            // pb649
            // 
            this.pb649.BackColor = System.Drawing.SystemColors.Control;
            this.pb649.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb649.BackgroundImage")));
            this.pb649.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb649.Location = new System.Drawing.Point(310, 26);
            this.pb649.Name = "pb649";
            this.pb649.Size = new System.Drawing.Size(163, 173);
            this.pb649.TabIndex = 5;
            this.pb649.TabStop = false;
            this.pb649.Click += new System.EventHandler(this.pb649_Click);
            // 
            // pbLottoMax
            // 
            this.pbLottoMax.BackColor = System.Drawing.SystemColors.Control;
            this.pbLottoMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLottoMax.BackgroundImage")));
            this.pbLottoMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLottoMax.Location = new System.Drawing.Point(65, 26);
            this.pbLottoMax.Name = "pbLottoMax";
            this.pbLottoMax.Size = new System.Drawing.Size(163, 173);
            this.pbLottoMax.TabIndex = 4;
            this.pbLottoMax.TabStop = false;
            this.pbLottoMax.Click += new System.EventHandler(this.pbLottoMax_Click);
            // 
            // tabPConversions
            // 
            this.tabPConversions.Controls.Add(this.gbConversions);
            this.tabPConversions.Location = new System.Drawing.Point(4, 25);
            this.tabPConversions.Name = "tabPConversions";
            this.tabPConversions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPConversions.Size = new System.Drawing.Size(653, 328);
            this.tabPConversions.TabIndex = 1;
            this.tabPConversions.Text = "Conversions";
            this.tabPConversions.UseVisualStyleBackColor = true;
            // 
            // gbConversions
            // 
            this.gbConversions.Controls.Add(this.lbTemperature);
            this.gbConversions.Controls.Add(this.lbMoneyExchange);
            this.gbConversions.Controls.Add(this.pbTemperature);
            this.gbConversions.Controls.Add(this.pbMoneyExchange);
            this.gbConversions.Location = new System.Drawing.Point(57, 37);
            this.gbConversions.Name = "gbConversions";
            this.gbConversions.Size = new System.Drawing.Size(538, 254);
            this.gbConversions.TabIndex = 1;
            this.gbConversions.TabStop = false;
            this.gbConversions.Text = "Conversions";
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.Location = new System.Drawing.Point(313, 220);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(143, 17);
            this.lbTemperature.TabIndex = 3;
            this.lbTemperature.Text = "Temperature Convert";
            // 
            // lbMoneyExchange
            // 
            this.lbMoneyExchange.AutoSize = true;
            this.lbMoneyExchange.Location = new System.Drawing.Point(81, 220);
            this.lbMoneyExchange.Name = "lbMoneyExchange";
            this.lbMoneyExchange.Size = new System.Drawing.Size(116, 17);
            this.lbMoneyExchange.TabIndex = 2;
            this.lbMoneyExchange.Text = "Money Exchange";
            // 
            // pbTemperature
            // 
            this.pbTemperature.BackColor = System.Drawing.SystemColors.Control;
            this.pbTemperature.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTemperature.BackgroundImage")));
            this.pbTemperature.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTemperature.Location = new System.Drawing.Point(304, 35);
            this.pbTemperature.Name = "pbTemperature";
            this.pbTemperature.Size = new System.Drawing.Size(163, 173);
            this.pbTemperature.TabIndex = 1;
            this.pbTemperature.TabStop = false;
            this.pbTemperature.Click += new System.EventHandler(this.pbTemperature_Click);
            // 
            // pbMoneyExchange
            // 
            this.pbMoneyExchange.BackColor = System.Drawing.SystemColors.Control;
            this.pbMoneyExchange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMoneyExchange.BackgroundImage")));
            this.pbMoneyExchange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMoneyExchange.Location = new System.Drawing.Point(59, 35);
            this.pbMoneyExchange.Name = "pbMoneyExchange";
            this.pbMoneyExchange.Size = new System.Drawing.Size(163, 173);
            this.pbMoneyExchange.TabIndex = 0;
            this.pbMoneyExchange.TabStop = false;
            this.pbMoneyExchange.Click += new System.EventHandler(this.pbMoneyExchange_Click);
            // 
            // tabPSimpleCalculator
            // 
            this.tabPSimpleCalculator.Controls.Add(this.pbCalculator);
            this.tabPSimpleCalculator.Location = new System.Drawing.Point(4, 25);
            this.tabPSimpleCalculator.Name = "tabPSimpleCalculator";
            this.tabPSimpleCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPSimpleCalculator.Size = new System.Drawing.Size(653, 328);
            this.tabPSimpleCalculator.TabIndex = 2;
            this.tabPSimpleCalculator.Text = "Simple Calculator";
            this.tabPSimpleCalculator.UseVisualStyleBackColor = true;
            // 
            // pbCalculator
            // 
            this.pbCalculator.BackColor = System.Drawing.SystemColors.Control;
            this.pbCalculator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCalculator.BackgroundImage")));
            this.pbCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCalculator.Location = new System.Drawing.Point(243, 51);
            this.pbCalculator.Name = "pbCalculator";
            this.pbCalculator.Size = new System.Drawing.Size(163, 217);
            this.pbCalculator.TabIndex = 7;
            this.pbCalculator.TabStop = false;
            this.pbCalculator.Click += new System.EventHandler(this.pbCalculator_Click);
            // 
            // tabPIPV4Validator
            // 
            this.tabPIPV4Validator.Controls.Add(this.pbIP);
            this.tabPIPV4Validator.Location = new System.Drawing.Point(4, 25);
            this.tabPIPV4Validator.Name = "tabPIPV4Validator";
            this.tabPIPV4Validator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPIPV4Validator.Size = new System.Drawing.Size(653, 328);
            this.tabPIPV4Validator.TabIndex = 3;
            this.tabPIPV4Validator.Text = "IPv4 Validator";
            this.tabPIPV4Validator.UseVisualStyleBackColor = true;
            // 
            // pbIP
            // 
            this.pbIP.BackColor = System.Drawing.SystemColors.Control;
            this.pbIP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbIP.BackgroundImage")));
            this.pbIP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbIP.Location = new System.Drawing.Point(245, 56);
            this.pbIP.Name = "pbIP";
            this.pbIP.Size = new System.Drawing.Size(163, 217);
            this.pbIP.TabIndex = 8;
            this.pbIP.TabStop = false;
            this.pbIP.Click += new System.EventHandler(this.pbIP_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(595, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 435);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabDashboard);
            this.Name = "Form0";
            this.Text = "Dashboard - Samuel Fauteux";
            this.tabDashboard.ResumeLayout(false);
            this.tabPGeneratedNumbers.ResumeLayout(false);
            this.gbLotto.ResumeLayout(false);
            this.gbLotto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb649)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLottoMax)).EndInit();
            this.tabPConversions.ResumeLayout(false);
            this.gbConversions.ResumeLayout(false);
            this.gbConversions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMoneyExchange)).EndInit();
            this.tabPSimpleCalculator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCalculator)).EndInit();
            this.tabPIPV4Validator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDashboard;
        private System.Windows.Forms.TabPage tabPGeneratedNumbers;
        private System.Windows.Forms.GroupBox gbLotto;
        private System.Windows.Forms.Label lb649;
        private System.Windows.Forms.Label lbLottoMax;
        private System.Windows.Forms.PictureBox pb649;
        private System.Windows.Forms.PictureBox pbLottoMax;
        private System.Windows.Forms.TabPage tabPConversions;
        private System.Windows.Forms.GroupBox gbConversions;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.Label lbMoneyExchange;
        private System.Windows.Forms.PictureBox pbTemperature;
        private System.Windows.Forms.PictureBox pbMoneyExchange;
        private System.Windows.Forms.TabPage tabPSimpleCalculator;
        private System.Windows.Forms.PictureBox pbCalculator;
        private System.Windows.Forms.TabPage tabPIPV4Validator;
        private System.Windows.Forms.PictureBox pbIP;
        private System.Windows.Forms.Button btnExit;
    }
}

