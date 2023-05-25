namespace AttendanceManagement.Interfaces
{
    partial class LoginForm
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
            circularPictureBox1 = new CustomControls.RJControls.CircularPictureBox();
            rjTextBox1 = new Krypton_Toolkit_Demo.RJTextBox();
            rjTextBox2 = new Krypton_Toolkit_Demo.RJTextBox();
            roundButton1 = new Krypton_Toolkit_Demo.RoundButton();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // circularPictureBox1
            // 
            circularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            circularPictureBox1.BorderColor = Color.RoyalBlue;
            circularPictureBox1.BorderColor2 = Color.HotPink;
            circularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            circularPictureBox1.BorderSize = 2;
            circularPictureBox1.GradientAngle = 50F;
            circularPictureBox1.Location = new Point(322, 12);
            circularPictureBox1.Name = "circularPictureBox1";
            circularPictureBox1.Size = new Size(149, 149);
            circularPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            circularPictureBox1.TabIndex = 0;
            circularPictureBox1.TabStop = false;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BorderColor = Color.MediumSlateBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 5;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Location = new Point(244, 220);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "Username";
            rjTextBox1.Size = new Size(312, 35);
            rjTextBox1.TabIndex = 1;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BorderColor = Color.MediumSlateBlue;
            rjTextBox2.BorderFocusColor = Color.HotPink;
            rjTextBox2.BorderRadius = 5;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Location = new Point(244, 272);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "Password";
            rjTextBox2.Size = new Size(312, 35);
            rjTextBox2.TabIndex = 2;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // roundButton1
            // 
            roundButton1.BackColor = Color.MediumSlateBlue;
            roundButton1.BackgroundColor = Color.MediumSlateBlue;
            roundButton1.BorderColor = Color.PaleVioletRed;
            roundButton1.BorderRadius = 5;
            roundButton1.BorderSize = 0;
            roundButton1.FlatAppearance.BorderSize = 0;
            roundButton1.FlatStyle = FlatStyle.Flat;
            roundButton1.ForeColor = Color.White;
            roundButton1.Location = new Point(338, 377);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(123, 50);
            roundButton1.TabIndex = 3;
            roundButton1.Text = "Login";
            roundButton1.TextColor = Color.White;
            roundButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(244, 324);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 4;
            label1.Text = "Forgot Password?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(roundButton1);
            Controls.Add(rjTextBox2);
            Controls.Add(rjTextBox1);
            Controls.Add(circularPictureBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)circularPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.CircularPictureBox circularPictureBox1;
        private Krypton_Toolkit_Demo.RJTextBox rjTextBox1;
        private Krypton_Toolkit_Demo.RJTextBox rjTextBox2;
        private Krypton_Toolkit_Demo.RoundButton roundButton1;
        private Label label1;
    }
}