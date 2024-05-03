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
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            Email = new Label();
            txtEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkMagenta;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Rockwell", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(461, 277);
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
            label2.Location = new Point(352, 181);
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
            txtPass.Location = new Point(495, 179);
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
            checkBox1.Location = new Point(495, 238);
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
            linkLabel1.Location = new Point(532, 342);
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
            button3.Location = new Point(627, 277);
            button3.Name = "button3";
            button3.Size = new Size(126, 48);
            button3.TabIndex = 9;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1031, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(700, 565);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(67, 566);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(778, 704);
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(905, 595);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(663, 523);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email.ForeColor = SystemColors.ButtonHighlight;
            Email.Location = new Point(352, 124);
            Email.Name = "Email";
            Email.Size = new Size(83, 29);
            Email.TabIndex = 13;
            Email.Text = "Email";
            Email.Click += Email_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(495, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 31);
            txtEmail.TabIndex = 14;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Magenta;
            ClientSize = new Size(798, 404);
            Controls.Add(txtEmail);
            Controls.Add(Email);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label Email;
        private TextBox txtEmail;
    }
}
