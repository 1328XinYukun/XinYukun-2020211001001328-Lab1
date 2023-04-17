namespace _2020211001001328_XinYukun_lab3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.chkReading = new System.Windows.Forms.CheckBox();
            this.chkPainting = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioMarried = new System.Windows.Forms.RadioButton();
            this.radiounmarried = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "China",
            "Japan",
            "US",
            "UK"});
            this.cmbCountry.Location = new System.Drawing.Point(210, 106);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(243, 23);
            this.cmbCountry.TabIndex = 0;
            this.cmbCountry.Text = "Bangladesh";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(210, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 25);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Nabil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Country";
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(9, 62);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(60, 19);
            this.radioMale.TabIndex = 5;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFemale);
            this.groupBox1.Controls.Add(this.radioMale);
            this.groupBox1.Location = new System.Drawing.Point(50, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(252, 62);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(76, 19);
            this.radioFemale.TabIndex = 6;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // chkReading
            // 
            this.chkReading.AutoSize = true;
            this.chkReading.Location = new System.Drawing.Point(210, 271);
            this.chkReading.Name = "chkReading";
            this.chkReading.Size = new System.Drawing.Size(85, 19);
            this.chkReading.TabIndex = 7;
            this.chkReading.Text = "Reading";
            this.chkReading.UseVisualStyleBackColor = true;
            // 
            // chkPainting
            // 
            this.chkPainting.AutoSize = true;
            this.chkPainting.Location = new System.Drawing.Point(352, 271);
            this.chkPainting.Name = "chkPainting";
            this.chkPainting.Size = new System.Drawing.Size(93, 19);
            this.chkPainting.TabIndex = 8;
            this.chkPainting.Text = "Painting";
            this.chkPainting.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hobbies";
            // 
            // radioMarried
            // 
            this.radioMarried.AutoSize = true;
            this.radioMarried.Location = new System.Drawing.Point(13, 35);
            this.radioMarried.Name = "radioMarried";
            this.radioMarried.Size = new System.Drawing.Size(84, 19);
            this.radioMarried.TabIndex = 10;
            this.radioMarried.TabStop = true;
            this.radioMarried.Text = "Married";
            this.radioMarried.UseVisualStyleBackColor = true;
            // 
            // radiounmarried
            // 
            this.radiounmarried.AutoSize = true;
            this.radiounmarried.Location = new System.Drawing.Point(235, 35);
            this.radiounmarried.Name = "radiounmarried";
            this.radiounmarried.Size = new System.Drawing.Size(100, 19);
            this.radiounmarried.TabIndex = 11;
            this.radiounmarried.TabStop = true;
            this.radiounmarried.Text = "Unmarried";
            this.radiounmarried.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiounmarried);
            this.groupBox2.Controls.Add(this.radioMarried);
            this.groupBox2.Location = new System.Drawing.Point(50, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 77);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkPainting);
            this.Controls.Add(this.chkReading);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbCountry);
            this.Name = "Form1";
            this.Text = "Customer Data Entry Screen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.CheckBox chkReading;
        private System.Windows.Forms.CheckBox chkPainting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioMarried;
        private System.Windows.Forms.RadioButton radiounmarried;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}

