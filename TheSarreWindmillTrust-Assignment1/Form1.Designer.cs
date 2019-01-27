namespace TheSarreWindmillTrust_Assignment1
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
            this.uiNameLabel = new System.Windows.Forms.Label();
            this.uiNumericRatingLabel = new System.Windows.Forms.Label();
            this.uiAdjectiveRatingLabel = new System.Windows.Forms.Label();
            this.uiDonorRatingLabel = new System.Windows.Forms.Label();
            this.uiDonorRatingComboBox = new System.Windows.Forms.ComboBox();
            this.uiDonorRatingTextBox = new System.Windows.Forms.TextBox();
            this.uiNewDonorButton = new System.Windows.Forms.Button();
            this.uiNewNameTextbox = new System.Windows.Forms.TextBox();
            this.uiNewNameLabel = new System.Windows.Forms.Label();
            this.uiUniqueIDLabel = new System.Windows.Forms.Label();
            this.uiDonationIDLabel = new System.Windows.Forms.Label();
            this.uiIDTextbox = new System.Windows.Forms.TextBox();
            this.uiDateLabel = new System.Windows.Forms.Label();
            this.uiAmountLabel = new System.Windows.Forms.Label();
            this.uiAmountTextBox = new System.Windows.Forms.TextBox();
            this.uiDonateButton = new System.Windows.Forms.Button();
            this.uiNewDonorTitleLabel = new System.Windows.Forms.Label();
            this.uiDonationTitleLabel = new System.Windows.Forms.Label();
            this.uiDisplayDonorsTitleLabel = new System.Windows.Forms.Label();
            this.uiNumericTextBox = new System.Windows.Forms.TextBox();
            this.uiAdjectiveTextBox = new System.Windows.Forms.TextBox();
            this.uiNewIDTextBox = new System.Windows.Forms.TextBox();
            this.uiDonateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.uiCreateDonorGroupBox = new System.Windows.Forms.GroupBox();
            this.uiFirstDateText = new System.Windows.Forms.Label();
            this.uiFirstDatePicker = new System.Windows.Forms.DateTimePicker();
            this.uiFirstDonationText = new System.Windows.Forms.Label();
            this.uiFirstDonationAmountTextBox = new System.Windows.Forms.TextBox();
            this.uiDonateGroupBox = new System.Windows.Forms.GroupBox();
            this.uiDisplayDonorGroupBox = new System.Windows.Forms.GroupBox();
            this.uiDonorNameTextBox = new System.Windows.Forms.TextBox();
            this.uiLastAmountLabel = new System.Windows.Forms.Label();
            this.uiTotalAmountTextbox = new System.Windows.Forms.TextBox();
            this.uiLastAmountTextbox = new System.Windows.Forms.TextBox();
            this.uiFirstDateLabel = new System.Windows.Forms.Label();
            this.uiLastDateLabel = new System.Windows.Forms.Label();
            this.uiFirstDateTextbox = new System.Windows.Forms.TextBox();
            this.uiLastDateTextbox = new System.Windows.Forms.TextBox();
            this.uiTotalAmountLabel = new System.Windows.Forms.Label();
            this.uiCreateDonorGroupBox.SuspendLayout();
            this.uiDonateGroupBox.SuspendLayout();
            this.uiDisplayDonorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiNameLabel
            // 
            this.uiNameLabel.AutoSize = true;
            this.uiNameLabel.Location = new System.Drawing.Point(15, 266);
            this.uiNameLabel.Name = "uiNameLabel";
            this.uiNameLabel.Size = new System.Drawing.Size(73, 13);
            this.uiNameLabel.TabIndex = 0;
            this.uiNameLabel.Text = "Current Donor";
            // 
            // uiNumericRatingLabel
            // 
            this.uiNumericRatingLabel.AutoSize = true;
            this.uiNumericRatingLabel.Location = new System.Drawing.Point(203, 16);
            this.uiNumericRatingLabel.Name = "uiNumericRatingLabel";
            this.uiNumericRatingLabel.Size = new System.Drawing.Size(80, 13);
            this.uiNumericRatingLabel.TabIndex = 2;
            this.uiNumericRatingLabel.Text = "Numeric Rating";
            // 
            // uiAdjectiveRatingLabel
            // 
            this.uiAdjectiveRatingLabel.AutoSize = true;
            this.uiAdjectiveRatingLabel.Location = new System.Drawing.Point(306, 15);
            this.uiAdjectiveRatingLabel.Name = "uiAdjectiveRatingLabel";
            this.uiAdjectiveRatingLabel.Size = new System.Drawing.Size(85, 13);
            this.uiAdjectiveRatingLabel.TabIndex = 3;
            this.uiAdjectiveRatingLabel.Text = "Adjective Rating";
            // 
            // uiDonorRatingLabel
            // 
            this.uiDonorRatingLabel.AutoSize = true;
            this.uiDonorRatingLabel.Location = new System.Drawing.Point(3, 139);
            this.uiDonorRatingLabel.Name = "uiDonorRatingLabel";
            this.uiDonorRatingLabel.Size = new System.Drawing.Size(70, 13);
            this.uiDonorRatingLabel.TabIndex = 4;
            this.uiDonorRatingLabel.Text = "Donor Rating";
            // 
            // uiDonorRatingComboBox
            // 
            this.uiDonorRatingComboBox.FormattingEnabled = true;
            this.uiDonorRatingComboBox.Location = new System.Drawing.Point(76, 136);
            this.uiDonorRatingComboBox.Name = "uiDonorRatingComboBox";
            this.uiDonorRatingComboBox.Size = new System.Drawing.Size(121, 21);
            this.uiDonorRatingComboBox.TabIndex = 5;
            this.uiDonorRatingComboBox.SelectedIndexChanged += new System.EventHandler(this.uiDonorRatingComboBox_SelectedIndexChanged);
            // 
            // uiDonorRatingTextBox
            // 
            this.uiDonorRatingTextBox.Location = new System.Drawing.Point(203, 136);
            this.uiDonorRatingTextBox.Multiline = true;
            this.uiDonorRatingTextBox.Name = "uiDonorRatingTextBox";
            this.uiDonorRatingTextBox.ReadOnly = true;
            this.uiDonorRatingTextBox.Size = new System.Drawing.Size(206, 96);
            this.uiDonorRatingTextBox.TabIndex = 6;
            // 
            // uiNewDonorButton
            // 
            this.uiNewDonorButton.Location = new System.Drawing.Point(15, 75);
            this.uiNewDonorButton.Name = "uiNewDonorButton";
            this.uiNewDonorButton.Size = new System.Drawing.Size(109, 23);
            this.uiNewDonorButton.TabIndex = 7;
            this.uiNewDonorButton.Text = "Create New Donor";
            this.uiNewDonorButton.UseVisualStyleBackColor = true;
            this.uiNewDonorButton.Click += new System.EventHandler(this.uiNewDonorButton_Click);
            // 
            // uiNewNameTextbox
            // 
            this.uiNewNameTextbox.Location = new System.Drawing.Point(15, 49);
            this.uiNewNameTextbox.Name = "uiNewNameTextbox";
            this.uiNewNameTextbox.Size = new System.Drawing.Size(109, 20);
            this.uiNewNameTextbox.TabIndex = 8;
            // 
            // uiNewNameLabel
            // 
            this.uiNewNameLabel.AutoSize = true;
            this.uiNewNameLabel.Location = new System.Drawing.Point(15, 33);
            this.uiNewNameLabel.Name = "uiNewNameLabel";
            this.uiNewNameLabel.Size = new System.Drawing.Size(95, 13);
            this.uiNewNameLabel.TabIndex = 9;
            this.uiNewNameLabel.Text = "Enter Donor Name";
            // 
            // uiUniqueIDLabel
            // 
            this.uiUniqueIDLabel.AutoSize = true;
            this.uiUniqueIDLabel.Location = new System.Drawing.Point(124, 72);
            this.uiUniqueIDLabel.Name = "uiUniqueIDLabel";
            this.uiUniqueIDLabel.Size = new System.Drawing.Size(61, 13);
            this.uiUniqueIDLabel.TabIndex = 10;
            this.uiUniqueIDLabel.Text = "Unique ID: ";
            // 
            // uiDonationIDLabel
            // 
            this.uiDonationIDLabel.AutoSize = true;
            this.uiDonationIDLabel.Location = new System.Drawing.Point(15, 151);
            this.uiDonationIDLabel.Name = "uiDonationIDLabel";
            this.uiDonationIDLabel.Size = new System.Drawing.Size(83, 13);
            this.uiDonationIDLabel.TabIndex = 11;
            this.uiDonationIDLabel.Text = "Enter Unique ID";
            // 
            // uiIDTextbox
            // 
            this.uiIDTextbox.Location = new System.Drawing.Point(3, 46);
            this.uiIDTextbox.Name = "uiIDTextbox";
            this.uiIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.uiIDTextbox.TabIndex = 12;
            // 
            // uiDateLabel
            // 
            this.uiDateLabel.AutoSize = true;
            this.uiDateLabel.Location = new System.Drawing.Point(118, 151);
            this.uiDateLabel.Name = "uiDateLabel";
            this.uiDateLabel.Size = new System.Drawing.Size(58, 13);
            this.uiDateLabel.TabIndex = 13;
            this.uiDateLabel.Text = "Enter Date";
            // 
            // uiAmountLabel
            // 
            this.uiAmountLabel.AutoSize = true;
            this.uiAmountLabel.Location = new System.Drawing.Point(244, 30);
            this.uiAmountLabel.Name = "uiAmountLabel";
            this.uiAmountLabel.Size = new System.Drawing.Size(117, 13);
            this.uiAmountLabel.TabIndex = 15;
            this.uiAmountLabel.Text = "Enter Donation Amount";
            // 
            // uiAmountTextBox
            // 
            this.uiAmountTextBox.Location = new System.Drawing.Point(259, 167);
            this.uiAmountTextBox.Name = "uiAmountTextBox";
            this.uiAmountTextBox.Size = new System.Drawing.Size(114, 20);
            this.uiAmountTextBox.TabIndex = 16;
            // 
            // uiDonateButton
            // 
            this.uiDonateButton.Location = new System.Drawing.Point(15, 193);
            this.uiDonateButton.Name = "uiDonateButton";
            this.uiDonateButton.Size = new System.Drawing.Size(75, 23);
            this.uiDonateButton.TabIndex = 17;
            this.uiDonateButton.Text = "Donate";
            this.uiDonateButton.UseVisualStyleBackColor = true;
            this.uiDonateButton.Click += new System.EventHandler(this.uiDonateButton_Click);
            // 
            // uiNewDonorTitleLabel
            // 
            this.uiNewDonorTitleLabel.AutoSize = true;
            this.uiNewDonorTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiNewDonorTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.uiNewDonorTitleLabel.Name = "uiNewDonorTitleLabel";
            this.uiNewDonorTitleLabel.Size = new System.Drawing.Size(171, 20);
            this.uiNewDonorTitleLabel.TabIndex = 18;
            this.uiNewDonorTitleLabel.Text = "Create a New Donor";
            // 
            // uiDonationTitleLabel
            // 
            this.uiDonationTitleLabel.AutoSize = true;
            this.uiDonationTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDonationTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.uiDonationTitleLabel.Name = "uiDonationTitleLabel";
            this.uiDonationTitleLabel.Size = new System.Drawing.Size(68, 20);
            this.uiDonationTitleLabel.TabIndex = 19;
            this.uiDonationTitleLabel.Text = "Donate";
            // 
            // uiDisplayDonorsTitleLabel
            // 
            this.uiDisplayDonorsTitleLabel.AutoSize = true;
            this.uiDisplayDonorsTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDisplayDonorsTitleLabel.Location = new System.Drawing.Point(12, 232);
            this.uiDisplayDonorsTitleLabel.Name = "uiDisplayDonorsTitleLabel";
            this.uiDisplayDonorsTitleLabel.Size = new System.Drawing.Size(130, 20);
            this.uiDisplayDonorsTitleLabel.TabIndex = 20;
            this.uiDisplayDonorsTitleLabel.Text = "Display Donors";
            // 
            // uiNumericTextBox
            // 
            this.uiNumericTextBox.Location = new System.Drawing.Point(203, 31);
            this.uiNumericTextBox.Name = "uiNumericTextBox";
            this.uiNumericTextBox.ReadOnly = true;
            this.uiNumericTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiNumericTextBox.TabIndex = 21;
            // 
            // uiAdjectiveTextBox
            // 
            this.uiAdjectiveTextBox.Location = new System.Drawing.Point(309, 31);
            this.uiAdjectiveTextBox.Name = "uiAdjectiveTextBox";
            this.uiAdjectiveTextBox.ReadOnly = true;
            this.uiAdjectiveTextBox.Size = new System.Drawing.Size(100, 20);
            this.uiAdjectiveTextBox.TabIndex = 22;
            // 
            // uiNewIDTextBox
            // 
            this.uiNewIDTextBox.Location = new System.Drawing.Point(182, 68);
            this.uiNewIDTextBox.Name = "uiNewIDTextBox";
            this.uiNewIDTextBox.ReadOnly = true;
            this.uiNewIDTextBox.Size = new System.Drawing.Size(111, 20);
            this.uiNewIDTextBox.TabIndex = 23;
            // 
            // uiDonateDateTimePicker
            // 
            this.uiDonateDateTimePicker.Location = new System.Drawing.Point(121, 167);
            this.uiDonateDateTimePicker.Name = "uiDonateDateTimePicker";
            this.uiDonateDateTimePicker.Size = new System.Drawing.Size(132, 20);
            this.uiDonateDateTimePicker.TabIndex = 24;
            // 
            // uiCreateDonorGroupBox
            // 
            this.uiCreateDonorGroupBox.Controls.Add(this.uiFirstDateText);
            this.uiCreateDonorGroupBox.Controls.Add(this.uiFirstDatePicker);
            this.uiCreateDonorGroupBox.Controls.Add(this.uiFirstDonationText);
            this.uiCreateDonorGroupBox.Controls.Add(this.uiFirstDonationAmountTextBox);
            this.uiCreateDonorGroupBox.Controls.Add(this.uiNewIDTextBox);
            this.uiCreateDonorGroupBox.Controls.Add(this.uiUniqueIDLabel);
            this.uiCreateDonorGroupBox.Location = new System.Drawing.Point(12, 9);
            this.uiCreateDonorGroupBox.Name = "uiCreateDonorGroupBox";
            this.uiCreateDonorGroupBox.Size = new System.Drawing.Size(414, 100);
            this.uiCreateDonorGroupBox.TabIndex = 25;
            this.uiCreateDonorGroupBox.TabStop = false;
            this.uiCreateDonorGroupBox.Text = "groupBox1";
            // 
            // uiFirstDateText
            // 
            this.uiFirstDateText.AutoSize = true;
            this.uiFirstDateText.Location = new System.Drawing.Point(256, 24);
            this.uiFirstDateText.Name = "uiFirstDateText";
            this.uiFirstDateText.Size = new System.Drawing.Size(58, 13);
            this.uiFirstDateText.TabIndex = 29;
            this.uiFirstDateText.Text = "Enter Date";
            // 
            // uiFirstDatePicker
            // 
            this.uiFirstDatePicker.Location = new System.Drawing.Point(259, 40);
            this.uiFirstDatePicker.Name = "uiFirstDatePicker";
            this.uiFirstDatePicker.Size = new System.Drawing.Size(132, 20);
            this.uiFirstDatePicker.TabIndex = 28;
            // 
            // uiFirstDonationText
            // 
            this.uiFirstDonationText.AutoSize = true;
            this.uiFirstDonationText.Location = new System.Drawing.Point(124, 24);
            this.uiFirstDonationText.Name = "uiFirstDonationText";
            this.uiFirstDonationText.Size = new System.Drawing.Size(117, 13);
            this.uiFirstDonationText.TabIndex = 28;
            this.uiFirstDonationText.Text = "Enter Donation Amount";
            // 
            // uiFirstDonationAmountTextBox
            // 
            this.uiFirstDonationAmountTextBox.Location = new System.Drawing.Point(127, 40);
            this.uiFirstDonationAmountTextBox.Name = "uiFirstDonationAmountTextBox";
            this.uiFirstDonationAmountTextBox.Size = new System.Drawing.Size(114, 20);
            this.uiFirstDonationAmountTextBox.TabIndex = 28;
            // 
            // uiDonateGroupBox
            // 
            this.uiDonateGroupBox.Controls.Add(this.uiDonationTitleLabel);
            this.uiDonateGroupBox.Controls.Add(this.uiAmountLabel);
            this.uiDonateGroupBox.Controls.Add(this.uiIDTextbox);
            this.uiDonateGroupBox.Location = new System.Drawing.Point(12, 121);
            this.uiDonateGroupBox.Name = "uiDonateGroupBox";
            this.uiDonateGroupBox.Size = new System.Drawing.Size(414, 105);
            this.uiDonateGroupBox.TabIndex = 26;
            this.uiDonateGroupBox.TabStop = false;
            this.uiDonateGroupBox.Text = "groupBox2";
            // 
            // uiDisplayDonorGroupBox
            // 
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiTotalAmountLabel);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiLastDateTextbox);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiFirstDateTextbox);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiLastDateLabel);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiFirstDateLabel);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiLastAmountTextbox);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiTotalAmountTextbox);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiLastAmountLabel);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiDonorNameTextBox);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiAdjectiveTextBox);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiNumericTextBox);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiNumericRatingLabel);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiAdjectiveRatingLabel);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiDonorRatingLabel);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiDonorRatingComboBox);
            this.uiDisplayDonorGroupBox.Controls.Add(this.uiDonorRatingTextBox);
            this.uiDisplayDonorGroupBox.Location = new System.Drawing.Point(12, 232);
            this.uiDisplayDonorGroupBox.Name = "uiDisplayDonorGroupBox";
            this.uiDisplayDonorGroupBox.Size = new System.Drawing.Size(414, 241);
            this.uiDisplayDonorGroupBox.TabIndex = 27;
            this.uiDisplayDonorGroupBox.TabStop = false;
            this.uiDisplayDonorGroupBox.Text = "groupBox3";
            // 
            // uiDonorNameTextBox
            // 
            this.uiDonorNameTextBox.Location = new System.Drawing.Point(76, 31);
            this.uiDonorNameTextBox.Name = "uiDonorNameTextBox";
            this.uiDonorNameTextBox.ReadOnly = true;
            this.uiDonorNameTextBox.Size = new System.Drawing.Size(121, 20);
            this.uiDonorNameTextBox.TabIndex = 28;
            // 
            // uiLastAmountLabel
            // 
            this.uiLastAmountLabel.AutoSize = true;
            this.uiLastAmountLabel.Location = new System.Drawing.Point(306, 54);
            this.uiLastAmountLabel.Name = "uiLastAmountLabel";
            this.uiLastAmountLabel.Size = new System.Drawing.Size(66, 13);
            this.uiLastAmountLabel.TabIndex = 30;
            this.uiLastAmountLabel.Text = "Last Amount";
            // 
            // uiTotalAmountTextbox
            // 
            this.uiTotalAmountTextbox.Location = new System.Drawing.Point(203, 70);
            this.uiTotalAmountTextbox.Name = "uiTotalAmountTextbox";
            this.uiTotalAmountTextbox.ReadOnly = true;
            this.uiTotalAmountTextbox.Size = new System.Drawing.Size(100, 20);
            this.uiTotalAmountTextbox.TabIndex = 31;
            // 
            // uiLastAmountTextbox
            // 
            this.uiLastAmountTextbox.Location = new System.Drawing.Point(308, 70);
            this.uiLastAmountTextbox.Name = "uiLastAmountTextbox";
            this.uiLastAmountTextbox.ReadOnly = true;
            this.uiLastAmountTextbox.Size = new System.Drawing.Size(100, 20);
            this.uiLastAmountTextbox.TabIndex = 32;
            // 
            // uiFirstDateLabel
            // 
            this.uiFirstDateLabel.AutoSize = true;
            this.uiFirstDateLabel.Location = new System.Drawing.Point(203, 93);
            this.uiFirstDateLabel.Name = "uiFirstDateLabel";
            this.uiFirstDateLabel.Size = new System.Drawing.Size(52, 13);
            this.uiFirstDateLabel.TabIndex = 33;
            this.uiFirstDateLabel.Text = "First Date";
            // 
            // uiLastDateLabel
            // 
            this.uiLastDateLabel.AutoSize = true;
            this.uiLastDateLabel.Location = new System.Drawing.Point(306, 93);
            this.uiLastDateLabel.Name = "uiLastDateLabel";
            this.uiLastDateLabel.Size = new System.Drawing.Size(53, 13);
            this.uiLastDateLabel.TabIndex = 34;
            this.uiLastDateLabel.Text = "Last Date";
            // 
            // uiFirstDateTextbox
            // 
            this.uiFirstDateTextbox.Location = new System.Drawing.Point(203, 109);
            this.uiFirstDateTextbox.Name = "uiFirstDateTextbox";
            this.uiFirstDateTextbox.ReadOnly = true;
            this.uiFirstDateTextbox.Size = new System.Drawing.Size(100, 20);
            this.uiFirstDateTextbox.TabIndex = 35;
            // 
            // uiLastDateTextbox
            // 
            this.uiLastDateTextbox.Location = new System.Drawing.Point(309, 109);
            this.uiLastDateTextbox.Name = "uiLastDateTextbox";
            this.uiLastDateTextbox.ReadOnly = true;
            this.uiLastDateTextbox.Size = new System.Drawing.Size(100, 20);
            this.uiLastDateTextbox.TabIndex = 36;
            // 
            // uiTotalAmountLabel
            // 
            this.uiTotalAmountLabel.AutoSize = true;
            this.uiTotalAmountLabel.Location = new System.Drawing.Point(203, 54);
            this.uiTotalAmountLabel.Name = "uiTotalAmountLabel";
            this.uiTotalAmountLabel.Size = new System.Drawing.Size(70, 13);
            this.uiTotalAmountLabel.TabIndex = 28;
            this.uiTotalAmountLabel.Text = "Total Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 483);
            this.Controls.Add(this.uiDonateDateTimePicker);
            this.Controls.Add(this.uiDisplayDonorsTitleLabel);
            this.Controls.Add(this.uiNewDonorTitleLabel);
            this.Controls.Add(this.uiDonateButton);
            this.Controls.Add(this.uiAmountTextBox);
            this.Controls.Add(this.uiDateLabel);
            this.Controls.Add(this.uiDonationIDLabel);
            this.Controls.Add(this.uiNewNameLabel);
            this.Controls.Add(this.uiNewNameTextbox);
            this.Controls.Add(this.uiNewDonorButton);
            this.Controls.Add(this.uiNameLabel);
            this.Controls.Add(this.uiCreateDonorGroupBox);
            this.Controls.Add(this.uiDonateGroupBox);
            this.Controls.Add(this.uiDisplayDonorGroupBox);
            this.Name = "Form1";
            this.Text = "The Sarre Windmill Trust";
            this.uiCreateDonorGroupBox.ResumeLayout(false);
            this.uiCreateDonorGroupBox.PerformLayout();
            this.uiDonateGroupBox.ResumeLayout(false);
            this.uiDonateGroupBox.PerformLayout();
            this.uiDisplayDonorGroupBox.ResumeLayout(false);
            this.uiDisplayDonorGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiNameLabel;
        private System.Windows.Forms.Label uiNumericRatingLabel;
        private System.Windows.Forms.Label uiAdjectiveRatingLabel;
        private System.Windows.Forms.Label uiDonorRatingLabel;
        private System.Windows.Forms.ComboBox uiDonorRatingComboBox;
        private System.Windows.Forms.TextBox uiDonorRatingTextBox;
        private System.Windows.Forms.Button uiNewDonorButton;
        private System.Windows.Forms.TextBox uiNewNameTextbox;
        private System.Windows.Forms.Label uiNewNameLabel;
        private System.Windows.Forms.Label uiUniqueIDLabel;
        private System.Windows.Forms.Label uiDonationIDLabel;
        private System.Windows.Forms.TextBox uiIDTextbox;
        private System.Windows.Forms.Label uiDateLabel;
        private System.Windows.Forms.Label uiAmountLabel;
        private System.Windows.Forms.TextBox uiAmountTextBox;
        private System.Windows.Forms.Button uiDonateButton;
        private System.Windows.Forms.Label uiNewDonorTitleLabel;
        private System.Windows.Forms.Label uiDonationTitleLabel;
        private System.Windows.Forms.Label uiDisplayDonorsTitleLabel;
        private System.Windows.Forms.TextBox uiNumericTextBox;
        private System.Windows.Forms.TextBox uiAdjectiveTextBox;
        private System.Windows.Forms.TextBox uiNewIDTextBox;
        private System.Windows.Forms.DateTimePicker uiDonateDateTimePicker;
        private System.Windows.Forms.GroupBox uiCreateDonorGroupBox;
        private System.Windows.Forms.GroupBox uiDonateGroupBox;
        private System.Windows.Forms.GroupBox uiDisplayDonorGroupBox;
        private System.Windows.Forms.TextBox uiDonorNameTextBox;
        private System.Windows.Forms.Label uiFirstDonationText;
        private System.Windows.Forms.TextBox uiFirstDonationAmountTextBox;
        private System.Windows.Forms.Label uiFirstDateText;
        private System.Windows.Forms.DateTimePicker uiFirstDatePicker;
        private System.Windows.Forms.Label uiTotalAmountLabel;
        private System.Windows.Forms.TextBox uiLastDateTextbox;
        private System.Windows.Forms.TextBox uiFirstDateTextbox;
        private System.Windows.Forms.Label uiLastDateLabel;
        private System.Windows.Forms.Label uiFirstDateLabel;
        private System.Windows.Forms.TextBox uiLastAmountTextbox;
        private System.Windows.Forms.TextBox uiTotalAmountTextbox;
        private System.Windows.Forms.Label uiLastAmountLabel;
    }
}

