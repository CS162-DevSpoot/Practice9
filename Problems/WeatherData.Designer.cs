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
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dateLabel = new Label();
            groupBox4 = new GroupBox();
            percerptationLabel = new Label();
            groupBox5 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 54);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select A Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateLabel);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(12, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(215, 54);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Date";
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
            // dateLabel
            // 
            dateLabel.BackColor = SystemColors.ControlLight;
            dateLabel.Location = new Point(6, 19);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(200, 23);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "label1";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(percerptationLabel);
            groupBox4.Controls.Add(groupBox5);
            groupBox4.Location = new Point(12, 117);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(215, 54);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Perveptation";
            // 
            // percerptationLabel
            // 
            percerptationLabel.BackColor = SystemColors.ControlLight;
            percerptationLabel.Location = new Point(6, 19);
            percerptationLabel.Name = "percerptationLabel";
            percerptationLabel.Size = new Size(200, 23);
            percerptationLabel.TabIndex = 3;
            percerptationLabel.Text = "label2";
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
            // WeatherData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "WeatherData";
            Text = "WeatherData";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private Label dateLabel;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label percerptationLabel;
        private GroupBox groupBox5;
    }
}