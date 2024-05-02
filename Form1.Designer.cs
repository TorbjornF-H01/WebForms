namespace WebForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkMagenta;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(459, 240);
            button1.Name = "button1";
            button1.Size = new Size(126, 48);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(352, 72);
            label1.Name = "label1";
            label1.Size = new Size(137, 29);
            label1.TabIndex = 2;
            label1.Text = "UserName";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(352, 126);
            label2.Name = "label2";
            label2.Size = new Size(127, 29);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(495, 70);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(244, 31);
            txtUser.TabIndex = 4;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(495, 124);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '⨷';
            txtPass.Size = new Size(244, 31);
            txtPass.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkMagenta;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(495, 182);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(221, 33);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Rockwell", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(64, 0, 0);
            linkLabel1.Location = new Point(522, 312);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(184, 25);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password";
            // 
            // button3
            // 
            button3.BackColor = Color.MediumVioletRed;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(626, 240);
            button3.Name = "button3";
            button3.Size = new Size(126, 48);
            button3.TabIndex = 9;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Magenta;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Login Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPass;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Button button3;
    }
}
