namespace CS162_Practice9.Problems
{
    partial class VendingMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendingMachine));
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            inventory1Label = new Label();
            pepsiPictureBox = new PictureBox();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            label3 = new Label();
            groupBox4 = new GroupBox();
            inventory2Label = new Label();
            drPeperPictureBox = new PictureBox();
            panel3 = new Panel();
            groupBox5 = new GroupBox();
            label5 = new Label();
            groupBox6 = new GroupBox();
            inventory3Label = new Label();
            rootbearPictureBox = new PictureBox();
            panel4 = new Panel();
            groupBox7 = new GroupBox();
            label7 = new Label();
            groupBox8 = new GroupBox();
            inventory4Label = new Label();
            cokePictureBox = new PictureBox();
            groupBox9 = new GroupBox();
            totalSalesLabel = new Label();
            closeButton = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pepsiPictureBox).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)drPeperPictureBox).BeginInit();
            panel3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rootbearPictureBox).BeginInit();
            panel4.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cokePictureBox).BeginInit();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(pepsiPictureBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 126);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(132, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(127, 54);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cost";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(115, 23);
            label1.TabIndex = 0;
            label1.Text = "$1.00";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(inventory1Label);
            groupBox1.Location = new Point(132, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(127, 54);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Drinks Left";
            // 
            // inventory1Label
            // 
            inventory1Label.BackColor = SystemColors.ControlLight;
            inventory1Label.Location = new Point(6, 19);
            inventory1Label.Name = "inventory1Label";
            inventory1Label.Size = new Size(115, 23);
            inventory1Label.TabIndex = 0;
            inventory1Label.Text = "20";
            inventory1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pepsiPictureBox
            // 
            pepsiPictureBox.Image = (Image)resources.GetObject("pepsiPictureBox.Image");
            pepsiPictureBox.Location = new Point(3, 3);
            pepsiPictureBox.Name = "pepsiPictureBox";
            pepsiPictureBox.Size = new Size(123, 114);
            pepsiPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pepsiPictureBox.TabIndex = 0;
            pepsiPictureBox.TabStop = false;
            pepsiPictureBox.Click += pepsiClicked;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(drPeperPictureBox);
            panel2.Location = new Point(12, 144);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 126);
            panel2.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(132, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(127, 54);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cost";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(115, 23);
            label3.TabIndex = 0;
            label3.Text = "$1.25";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(inventory2Label);
            groupBox4.Location = new Point(132, 63);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(127, 54);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Drinks Left";
            // 
            // inventory2Label
            // 
            inventory2Label.BackColor = SystemColors.ControlLight;
            inventory2Label.Location = new Point(6, 19);
            inventory2Label.Name = "inventory2Label";
            inventory2Label.Size = new Size(115, 23);
            inventory2Label.TabIndex = 0;
            inventory2Label.Text = "20";
            inventory2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // drPeperPictureBox
            // 
            drPeperPictureBox.Image = (Image)resources.GetObject("drPeperPictureBox.Image");
            drPeperPictureBox.Location = new Point(3, 3);
            drPeperPictureBox.Name = "drPeperPictureBox";
            drPeperPictureBox.Size = new Size(123, 114);
            drPeperPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            drPeperPictureBox.TabIndex = 0;
            drPeperPictureBox.TabStop = false;
            drPeperPictureBox.Click += drPepperClicked;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(groupBox5);
            panel3.Controls.Add(groupBox6);
            panel3.Controls.Add(rootbearPictureBox);
            panel3.Location = new Point(12, 276);
            panel3.Name = "panel3";
            panel3.Size = new Size(269, 126);
            panel3.TabIndex = 4;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label5);
            groupBox5.Location = new Point(132, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(127, 54);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Cost";
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ControlLight;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(115, 23);
            label5.TabIndex = 0;
            label5.Text = "$1.50";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(inventory3Label);
            groupBox6.Location = new Point(132, 63);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(127, 54);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "Drinks Left";
            // 
            // inventory3Label
            // 
            inventory3Label.BackColor = SystemColors.ControlLight;
            inventory3Label.Location = new Point(6, 19);
            inventory3Label.Name = "inventory3Label";
            inventory3Label.Size = new Size(115, 23);
            inventory3Label.TabIndex = 0;
            inventory3Label.Text = "20";
            inventory3Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rootbearPictureBox
            // 
            rootbearPictureBox.Image = (Image)resources.GetObject("rootbearPictureBox.Image");
            rootbearPictureBox.Location = new Point(3, 3);
            rootbearPictureBox.Name = "rootbearPictureBox";
            rootbearPictureBox.Size = new Size(123, 114);
            rootbearPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            rootbearPictureBox.TabIndex = 0;
            rootbearPictureBox.TabStop = false;
            rootbearPictureBox.Click += rootbeerClicked;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(groupBox7);
            panel4.Controls.Add(groupBox8);
            panel4.Controls.Add(cokePictureBox);
            panel4.Location = new Point(12, 408);
            panel4.Name = "panel4";
            panel4.Size = new Size(269, 126);
            panel4.TabIndex = 4;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(label7);
            groupBox7.Location = new Point(132, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(127, 54);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "Cost";
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ControlLight;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(115, 23);
            label7.TabIndex = 0;
            label7.Text = "$1.75";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(inventory4Label);
            groupBox8.Location = new Point(132, 63);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(127, 54);
            groupBox8.TabIndex = 2;
            groupBox8.TabStop = false;
            groupBox8.Text = "Drinks Left";
            // 
            // inventory4Label
            // 
            inventory4Label.BackColor = SystemColors.ControlLight;
            inventory4Label.Location = new Point(6, 19);
            inventory4Label.Name = "inventory4Label";
            inventory4Label.Size = new Size(115, 23);
            inventory4Label.TabIndex = 0;
            inventory4Label.Text = "20";
            inventory4Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cokePictureBox
            // 
            cokePictureBox.Image = (Image)resources.GetObject("cokePictureBox.Image");
            cokePictureBox.Location = new Point(3, 3);
            cokePictureBox.Name = "cokePictureBox";
            cokePictureBox.Size = new Size(123, 114);
            cokePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cokePictureBox.TabIndex = 0;
            cokePictureBox.TabStop = false;
            cokePictureBox.Click += cokeClicked;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(totalSalesLabel);
            groupBox9.Location = new Point(12, 540);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(269, 52);
            groupBox9.TabIndex = 5;
            groupBox9.TabStop = false;
            groupBox9.Text = "Total Sales";
            // 
            // totalSalesLabel
            // 
            totalSalesLabel.BackColor = SystemColors.ControlLight;
            totalSalesLabel.Location = new Point(6, 19);
            totalSalesLabel.Name = "totalSalesLabel";
            totalSalesLabel.Size = new Size(257, 23);
            totalSalesLabel.TabIndex = 0;
            totalSalesLabel.Text = "$00.00";
            totalSalesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.IndianRed;
            closeButton.ForeColor = SystemColors.Control;
            closeButton.Location = new Point(12, 598);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(269, 23);
            closeButton.TabIndex = 6;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // VendingMachine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 635);
            Controls.Add(closeButton);
            Controls.Add(groupBox9);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VendingMachine";
            Text = "VendingMachine";
            Load += form_OnLoad;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pepsiPictureBox).EndInit();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)drPeperPictureBox).EndInit();
            panel3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rootbearPictureBox).EndInit();
            panel4.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)cokePictureBox).EndInit();
            groupBox9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox1;
        private Label inventory1Label;
        private PictureBox pepsiPictureBox;
        private Panel panel2;
        private GroupBox groupBox3;
        private Label label3;
        private GroupBox groupBox4;
        private Label inventory2Label;
        private PictureBox drPeperPictureBox;
        private Panel panel3;
        private GroupBox groupBox5;
        private Label label5;
        private GroupBox groupBox6;
        private Label inventory3Label;
        private PictureBox rootbearPictureBox;
        private Panel panel4;
        private GroupBox groupBox7;
        private Label label7;
        private GroupBox groupBox8;
        private Label inventory4Label;
        private PictureBox cokePictureBox;
        private GroupBox groupBox9;
        private Label totalSalesLabel;
        private Button closeButton;
    }
}