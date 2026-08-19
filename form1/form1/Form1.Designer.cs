namespace form1
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
            label1 = new Label();
            label2 = new Label();
            txtFname = new TextBox();
            txtLname = new TextBox();
            btnFname = new Button();
            label3 = new Label();
            txtFullname = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(127, 31);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(123, 31);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(145, 86);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(238, 27);
            txtFname.TabIndex = 2;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(145, 131);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(238, 27);
            txtLname.TabIndex = 2;
            // 
            // btnFname
            // 
            btnFname.BackColor = SystemColors.ScrollBar;
            btnFname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFname.ForeColor = SystemColors.ActiveCaptionText;
            btnFname.Location = new Point(289, 176);
            btnFname.Name = "btnFname";
            btnFname.Size = new Size(94, 29);
            btnFname.TabIndex = 3;
            btnFname.Text = "Submit";
            btnFname.UseVisualStyleBackColor = false;
            btnFname.Click += btnFname_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.HotTrack;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(409, 61);
            label3.TabIndex = 4;
            label3.Text = "Full Name";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(145, 224);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(238, 27);
            txtFullname.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 220);
            label4.Name = "label4";
            label4.Size = new Size(119, 31);
            label4.TabIndex = 1;
            label4.Text = "Full Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 303);
            Controls.Add(label3);
            Controls.Add(btnFname);
            Controls.Add(txtFullname);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFname;
        private TextBox txtLname;
        private Button btnFname;
        private Label label3;
        private TextBox txtFullname;
        private Label label4;
    }
}
