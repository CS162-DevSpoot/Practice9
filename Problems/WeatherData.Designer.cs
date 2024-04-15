namespace CS162_Practice9.Problems
{
    partial class WeatherData
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
            groupBox1 = new GroupBox();
            dateTimePicker = new DateTimePicker();
            groupBox2 = new GroupBox();
            dateLabel = new Label();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            precipitationLabel = new Label();
            groupBox5 = new GroupBox();
            closeButton = new Button();
            groupBox6 = new GroupBox();
            highTempLabel = new Label();
            groupBox7 = new GroupBox();
            groupBox8 = new GroupBox();
            lowestTempLabel = new Label();
            groupBox9 = new GroupBox();
            searchButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 54);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select A Date";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(6, 22);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateLabel);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(12, 101);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(215, 54);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Date";
            // 
            // dateLabel
            // 
            dateLabel.BackColor = SystemColors.ControlLight;
            dateLabel.Location = new Point(6, 19);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(200, 23);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "label1";
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(0, 60);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(215, 54);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(precipitationLabel);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(12, 146);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(215, 54);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Precipitation";
            // 
            // precipitationLabel
            // 
            precipitationLabel.BackColor = SystemColors.ControlLight;
            precipitationLabel.Location = new Point(6, 19);
            precipitationLabel.Name = "precipitationLabel";
            precipitationLabel.Size = new Size(200, 23);
            precipitationLabel.TabIndex = 3;
            precipitationLabel.Text = "label2";
            // 
            // groupBox5
            // 
            groupBox5.Location = new Point(0, 60);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(215, 54);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "groupBox5";
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.IndianRed;
            closeButton.ForeColor = SystemColors.Control;
            closeButton.Location = new Point(12, 314);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(215, 23);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Cliked;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(highTempLabel);
            groupBox6.Controls.Add(groupBox7);
            groupBox6.Location = new Point(12, 200);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(215, 54);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Highest Temp";
            // 
            // highTempLabel
            // 
            highTempLabel.BackColor = SystemColors.ControlLight;
            highTempLabel.Location = new Point(6, 19);
            highTempLabel.Name = "highTempLabel";
            highTempLabel.Size = new Size(200, 23);
            highTempLabel.TabIndex = 3;
            highTempLabel.Text = "label2";
            // 
            // groupBox7
            // 
            groupBox7.Location = new Point(0, 60);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(215, 54);
            groupBox7.TabIndex = 2;
            groupBox7.TabStop = false;
            groupBox7.Text = "groupBox7";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(lowestTempLabel);
            groupBox8.Controls.Add(groupBox9);
            groupBox8.Location = new Point(12, 254);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(215, 54);
            groupBox8.TabIndex = 6;
            groupBox8.TabStop = false;
            groupBox8.Text = "Lowest Temp";
            // 
            // lowestTempLabel
            // 
            lowestTempLabel.BackColor = SystemColors.ControlLight;
            lowestTempLabel.Location = new Point(6, 19);
            lowestTempLabel.Name = "lowestTempLabel";
            lowestTempLabel.Size = new Size(200, 23);
            lowestTempLabel.TabIndex = 3;
            lowestTempLabel.Text = "label2";
            // 
            // groupBox9
            // 
            groupBox9.Location = new Point(0, 60);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(215, 54);
            groupBox9.TabIndex = 2;
            groupBox9.TabStop = false;
            groupBox9.Text = "groupBox9";
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.RoyalBlue;
            searchButton.ForeColor = SystemColors.Control;
            searchButton.Location = new Point(18, 72);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(200, 23);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += datetimePicker_Changed;
            // 
            // WeatherData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 348);
            Controls.Add(searchButton);
            Controls.Add(groupBox8);
            Controls.Add(groupBox6);
            Controls.Add(closeButton);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "WeatherData";
            Text = "WeatherData";
            Load += form_OnLoad;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker;
        private GroupBox groupBox2;
        private Label dateLabel;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label precipitationLabel;
        private GroupBox groupBox5;
        private Button closeButton;
        private GroupBox groupBox6;
        private Label highTempLabel;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private Label lowestTempLabel;
        private GroupBox groupBox9;
        private Button searchButton;
    }
}