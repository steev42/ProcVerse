namespace ProcVerse1
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
            this.cmbHistoryMonthStart = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numHistoryYearStart = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numGameStartYear = new System.Windows.Forms.NumericUpDown();
            this.cmbGameStartMonth = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageFedParams = new System.Windows.Forms.TabPage();
            this.numFinalSupportedFeds = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnSeedGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHistoryYearStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGameStartYear)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pageFedParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFinalSupportedFeds)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbHistoryMonthStart
            // 
            this.cmbHistoryMonthStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHistoryMonthStart.FormattingEnabled = true;
            this.cmbHistoryMonthStart.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbHistoryMonthStart.Location = new System.Drawing.Point(148, 12);
            this.cmbHistoryMonthStart.Name = "cmbHistoryMonthStart";
            this.cmbHistoryMonthStart.Size = new System.Drawing.Size(121, 21);
            this.cmbHistoryMonthStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "History Start Date After";
            // 
            // numHistoryYearStart
            // 
            this.numHistoryYearStart.Location = new System.Drawing.Point(275, 12);
            this.numHistoryYearStart.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numHistoryYearStart.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numHistoryYearStart.Name = "numHistoryYearStart";
            this.numHistoryYearStart.Size = new System.Drawing.Size(120, 20);
            this.numHistoryYearStart.TabIndex = 2;
            this.numHistoryYearStart.Value = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seed";
            // 
            // txtSeed
            // 
            this.txtSeed.Location = new System.Drawing.Point(785, 13);
            this.txtSeed.Name = "txtSeed";
            this.txtSeed.Size = new System.Drawing.Size(172, 20);
            this.txtSeed.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Game Start Date";
            // 
            // numGameStartYear
            // 
            this.numGameStartYear.Location = new System.Drawing.Point(275, 53);
            this.numGameStartYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.numGameStartYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numGameStartYear.Name = "numGameStartYear";
            this.numGameStartYear.Size = new System.Drawing.Size(120, 20);
            this.numGameStartYear.TabIndex = 10;
            this.numGameStartYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // cmbGameStartMonth
            // 
            this.cmbGameStartMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGameStartMonth.FormattingEnabled = true;
            this.cmbGameStartMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbGameStartMonth.Location = new System.Drawing.Point(148, 53);
            this.cmbGameStartMonth.Name = "cmbGameStartMonth";
            this.cmbGameStartMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbGameStartMonth.TabIndex = 9;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(20, 415);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(436, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 385);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageFedParams);
            this.tabControl1.Location = new System.Drawing.Point(7, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(508, 359);
            this.tabControl1.TabIndex = 0;
            // 
            // pageFedParams
            // 
            this.pageFedParams.Controls.Add(this.numFinalSupportedFeds);
            this.pageFedParams.Controls.Add(this.label5);
            this.pageFedParams.Location = new System.Drawing.Point(4, 22);
            this.pageFedParams.Name = "pageFedParams";
            this.pageFedParams.Padding = new System.Windows.Forms.Padding(3);
            this.pageFedParams.Size = new System.Drawing.Size(500, 333);
            this.pageFedParams.TabIndex = 1;
            this.pageFedParams.Text = "Federations";
            this.pageFedParams.UseVisualStyleBackColor = true;
            // 
            // numFinalSupportedFeds
            // 
            this.numFinalSupportedFeds.Location = new System.Drawing.Point(146, 7);
            this.numFinalSupportedFeds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFinalSupportedFeds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFinalSupportedFeds.Name = "numFinalSupportedFeds";
            this.numFinalSupportedFeds.Size = new System.Drawing.Size(70, 20);
            this.numFinalSupportedFeds.TabIndex = 1;
            this.numFinalSupportedFeds.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Final Supported Fed Count";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(20, 107);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(405, 292);
            this.txtResults.TabIndex = 13;
            // 
            // btnSeedGenerate
            // 
            this.btnSeedGenerate.Location = new System.Drawing.Point(321, 415);
            this.btnSeedGenerate.Name = "btnSeedGenerate";
            this.btnSeedGenerate.Size = new System.Drawing.Size(104, 23);
            this.btnSeedGenerate.TabIndex = 14;
            this.btnSeedGenerate.Text = "Seed && Generate";
            this.btnSeedGenerate.UseVisualStyleBackColor = true;
            this.btnSeedGenerate.Click += new System.EventHandler(this.btnSeedGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.btnSeedGenerate);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.numGameStartYear);
            this.Controls.Add(this.cmbGameStartMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numHistoryYearStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHistoryMonthStart);
            this.Name = "Form1";
            this.Text = "ProcVerse Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHistoryYearStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGameStartYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pageFedParams.ResumeLayout(false);
            this.pageFedParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFinalSupportedFeds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHistoryMonthStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numHistoryYearStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numGameStartYear;
        private System.Windows.Forms.ComboBox cmbGameStartMonth;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageFedParams;
        private System.Windows.Forms.NumericUpDown numFinalSupportedFeds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnSeedGenerate;
    }
}

