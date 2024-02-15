namespace ContactFormatter
{
    partial class Form1
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
            txtEmailAddress = new TextBox();
            txtCity = new TextBox();
            txtState = new TextBox();
            txtZip = new TextBox();
            btnParse = new Button();
            btnFormat = new Button();
            btnExit = new Button();
            lblEmailAddress = new Label();
            lblCity = new Label();
            lblState = new Label();
            lblZip = new Label();
            SuspendLayout();
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(140, 28);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(100, 23);
            txtEmailAddress.TabIndex = 0;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(140, 69);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(100, 23);
            txtCity.TabIndex = 1;
            // 
            // txtState
            // 
            txtState.Location = new Point(140, 111);
            txtState.Name = "txtState";
            txtState.Size = new Size(100, 23);
            txtState.TabIndex = 2;
            // 
            // txtZip
            // 
            txtZip.Location = new Point(140, 154);
            txtZip.Name = "txtZip";
            txtZip.Size = new Size(100, 23);
            txtZip.TabIndex = 3;
            // 
            // btnParse
            // 
            btnParse.Location = new Point(284, 27);
            btnParse.Name = "btnParse";
            btnParse.Size = new Size(75, 23);
            btnParse.TabIndex = 4;
            btnParse.Text = "Parse";
            btnParse.UseVisualStyleBackColor = true;
            btnParse.Click += btnParse_Click;
            // 
            // btnFormat
            // 
            btnFormat.Location = new Point(284, 110);
            btnFormat.Name = "btnFormat";
            btnFormat.Size = new Size(75, 23);
            btnFormat.TabIndex = 5;
            btnFormat.Text = "Format";
            btnFormat.UseVisualStyleBackColor = true;
            btnFormat.Click += btnFormat_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(284, 153);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Location = new Point(31, 31);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(84, 15);
            lblEmailAddress.TabIndex = 7;
            lblEmailAddress.Text = "Email Address:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(31, 72);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 8;
            lblCity.Text = "City:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Location = new Point(31, 114);
            lblState.Name = "lblState";
            lblState.Size = new Size(36, 15);
            lblState.TabIndex = 9;
            lblState.Text = "State:";
            // 
            // lblZip
            // 
            lblZip.AutoSize = true;
            lblZip.Location = new Point(31, 157);
            lblZip.Name = "lblZip";
            lblZip.Size = new Size(27, 15);
            lblZip.TabIndex = 10;
            lblZip.Text = "Zip:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(401, 220);
            Controls.Add(lblZip);
            Controls.Add(lblState);
            Controls.Add(lblCity);
            Controls.Add(lblEmailAddress);
            Controls.Add(btnExit);
            Controls.Add(btnFormat);
            Controls.Add(btnParse);
            Controls.Add(txtZip);
            Controls.Add(txtState);
            Controls.Add(txtCity);
            Controls.Add(txtEmailAddress);
            Name = "Form1";
            Text = "Contact Formatter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmailAddress;
        private TextBox txtCity;
        private TextBox txtState;
        private TextBox txtZip;
        private Button btnParse;
        private Button btnFormat;
        private Button btnExit;
        private Label lblEmailAddress;
        private Label lblCity;
        private Label lblState;
        private Label lblZip;
    }
}