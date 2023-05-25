namespace AttendanceManagement
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            rjTextBox1 = new Krypton_Toolkit_Demo.RJTextBox();
            dgvAttendanceRecords = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendanceRecords).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 38);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1063, 551);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1055, 518);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Attendance Marking";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvAttendanceRecords);
            tabPage2.Controls.Add(rjTextBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1055, 518);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Attendance Records";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1055, 518);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Student Information";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1055, 518);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Reports";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BorderColor = Color.MediumSlateBlue;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 15;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Location = new Point(717, 26);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "Search...";
            rjTextBox1.Size = new Size(235, 35);
            rjTextBox1.TabIndex = 0;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // dgvAttendanceRecords
            // 
            dgvAttendanceRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendanceRecords.Location = new Point(4, 79);
            dgvAttendanceRecords.Name = "dgvAttendanceRecords";
            dgvAttendanceRecords.RowHeadersWidth = 51;
            dgvAttendanceRecords.RowTemplate.Height = 29;
            dgvAttendanceRecords.Size = new Size(1045, 422);
            dgvAttendanceRecords.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1063, 589);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAttendanceRecords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Krypton_Toolkit_Demo.RJTextBox rjTextBox1;
        private DataGridView dgvAttendanceRecords;
    }
}