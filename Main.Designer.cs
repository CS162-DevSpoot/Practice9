namespace CS162_Practice9
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            weatherDataButton = new Button();
            vendingMachineButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // weatherDataButton
            // 
            weatherDataButton.Location = new Point(12, 12);
            weatherDataButton.Name = "weatherDataButton";
            weatherDataButton.Size = new Size(146, 23);
            weatherDataButton.TabIndex = 0;
            weatherDataButton.Text = "Weather Data";
            weatherDataButton.UseVisualStyleBackColor = true;
            // 
            // vendingMachineButton
            // 
            vendingMachineButton.Location = new Point(12, 41);
            vendingMachineButton.Name = "vendingMachineButton";
            vendingMachineButton.Size = new Size(146, 23);
            vendingMachineButton.TabIndex = 1;
            vendingMachineButton.Text = "Vending Machine";
            vendingMachineButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Tomato;
            exitButton.ForeColor = SystemColors.ButtonFace;
            exitButton.Location = new Point(12, 70);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(146, 23);
            exitButton.TabIndex = 2;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(vendingMachineButton);
            Controls.Add(weatherDataButton);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button weatherDataButton;
        private Button vendingMachineButton;
        private Button exitButton;
    }
}
