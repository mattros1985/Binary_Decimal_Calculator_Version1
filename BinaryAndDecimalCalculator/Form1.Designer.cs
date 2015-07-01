namespace BinaryAndDecimalCalculator
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
            this.components = new System.ComponentModel.Container();
            this.input1TxtBox = new System.Windows.Forms.TextBox();
            this.result1TxtBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.input2TxtBox = new System.Windows.Forms.TextBox();
            this.result2TxtBox = new System.Windows.Forms.TextBox();
            this.enterButton2 = new System.Windows.Forms.Button();
            this.onButton = new System.Windows.Forms.Button();
            this.offButton = new System.Windows.Forms.Button();
            this.DecToBinLabel = new System.Windows.Forms.Label();
            this.binToDecLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.clearButton1 = new System.Windows.Forms.Button();
            this.clearButton2 = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.rulesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1TxtBox
            // 
            this.input1TxtBox.Location = new System.Drawing.Point(91, 62);
            this.input1TxtBox.Name = "input1TxtBox";
            this.input1TxtBox.Size = new System.Drawing.Size(100, 20);
            this.input1TxtBox.TabIndex = 0;
            this.input1TxtBox.TextChanged += new System.EventHandler(this.inputTxtBox_TextChanged);
            // 
            // result1TxtBox
            // 
            this.result1TxtBox.Location = new System.Drawing.Point(91, 88);
            this.result1TxtBox.Name = "result1TxtBox";
            this.result1TxtBox.Size = new System.Drawing.Size(100, 20);
            this.result1TxtBox.TabIndex = 2;
            this.result1TxtBox.TextChanged += new System.EventHandler(this.resultTxtBox_TextChanged);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(197, 85);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 3;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // input2TxtBox
            // 
            this.input2TxtBox.Location = new System.Drawing.Point(91, 172);
            this.input2TxtBox.Name = "input2TxtBox";
            this.input2TxtBox.Size = new System.Drawing.Size(100, 20);
            this.input2TxtBox.TabIndex = 4;
            this.input2TxtBox.TextChanged += new System.EventHandler(this.input2TxtBox_TextChanged);
            // 
            // result2TxtBox
            // 
            this.result2TxtBox.Location = new System.Drawing.Point(91, 196);
            this.result2TxtBox.Name = "result2TxtBox";
            this.result2TxtBox.Size = new System.Drawing.Size(100, 20);
            this.result2TxtBox.TabIndex = 5;
            this.result2TxtBox.TextChanged += new System.EventHandler(this.result2TxtBox_TextChanged);
            // 
            // enterButton2
            // 
            this.enterButton2.Location = new System.Drawing.Point(197, 193);
            this.enterButton2.Name = "enterButton2";
            this.enterButton2.Size = new System.Drawing.Size(75, 23);
            this.enterButton2.TabIndex = 6;
            this.enterButton2.Text = "Enter";
            this.enterButton2.UseVisualStyleBackColor = true;
            this.enterButton2.Click += new System.EventHandler(this.enterButton2_Click);
            // 
            // onButton
            // 
            this.onButton.Location = new System.Drawing.Point(1, 1);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(44, 34);
            this.onButton.TabIndex = 7;
            this.onButton.Text = "On";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.Click += new System.EventHandler(this.onButton_Click);
            // 
            // offButton
            // 
            this.offButton.Location = new System.Drawing.Point(51, 1);
            this.offButton.Name = "offButton";
            this.offButton.Size = new System.Drawing.Size(44, 34);
            this.offButton.TabIndex = 8;
            this.offButton.Text = "Off";
            this.offButton.UseVisualStyleBackColor = true;
            this.offButton.Click += new System.EventHandler(this.offButton_Click);
            // 
            // DecToBinLabel
            // 
            this.DecToBinLabel.Location = new System.Drawing.Point(88, 44);
            this.DecToBinLabel.Name = "DecToBinLabel";
            this.DecToBinLabel.Size = new System.Drawing.Size(100, 15);
            this.DecToBinLabel.TabIndex = 9;
            this.DecToBinLabel.Text = "Decimal To Binary";
            this.DecToBinLabel.Click += new System.EventHandler(this.DecToBin_Click);
            // 
            // binToDecLabel
            // 
            this.binToDecLabel.Location = new System.Drawing.Point(88, 154);
            this.binToDecLabel.Name = "binToDecLabel";
            this.binToDecLabel.Size = new System.Drawing.Size(100, 15);
            this.binToDecLabel.TabIndex = 10;
            this.binToDecLabel.Text = "Binary to Decimal";
            this.binToDecLabel.Click += new System.EventHandler(this.binToDec_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // clearButton1
            // 
            this.clearButton1.Location = new System.Drawing.Point(197, 60);
            this.clearButton1.Name = "clearButton1";
            this.clearButton1.Size = new System.Drawing.Size(75, 23);
            this.clearButton1.TabIndex = 11;
            this.clearButton1.Text = "Clear";
            this.clearButton1.UseVisualStyleBackColor = true;
            this.clearButton1.Click += new System.EventHandler(this.clearButton1_Click);
            // 
            // clearButton2
            // 
            this.clearButton2.Location = new System.Drawing.Point(196, 166);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(75, 23);
            this.clearButton2.TabIndex = 12;
            this.clearButton2.Text = "Clear";
            this.clearButton2.UseVisualStyleBackColor = true;
            this.clearButton2.Click += new System.EventHandler(this.clearButton2_Click);
            // 
            // rulesButton
            // 
            this.rulesButton.Location = new System.Drawing.Point(318, 12);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(75, 23);
            this.rulesButton.TabIndex = 13;
            this.rulesButton.Text = "Rules";
            this.rulesButton.UseVisualStyleBackColor = true;
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(405, 313);
            this.Controls.Add(this.rulesButton);
            this.Controls.Add(this.clearButton2);
            this.Controls.Add(this.clearButton1);
            this.Controls.Add(this.binToDecLabel);
            this.Controls.Add(this.DecToBinLabel);
            this.Controls.Add(this.offButton);
            this.Controls.Add(this.onButton);
            this.Controls.Add(this.enterButton2);
            this.Controls.Add(this.result2TxtBox);
            this.Controls.Add(this.input2TxtBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.result1TxtBox);
            this.Controls.Add(this.input1TxtBox);
            this.Name = "Form1";
            this.Text = "Binary and Decimal Calculator";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1TxtBox;
        private System.Windows.Forms.TextBox result1TxtBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox input2TxtBox;
        private System.Windows.Forms.TextBox result2TxtBox;
        private System.Windows.Forms.Button enterButton2;
        private System.Windows.Forms.Button onButton;
        private System.Windows.Forms.Button offButton;
        private System.Windows.Forms.Label DecToBinLabel;
        private System.Windows.Forms.Label binToDecLabel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button clearButton1;
        private System.Windows.Forms.Button clearButton2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button rulesButton;
    }
}

