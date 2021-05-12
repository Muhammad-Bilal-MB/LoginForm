namespace Login_Form
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_button = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.close_label = new System.Windows.Forms.Label();
            this.help_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.New_user_label = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(372, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 345);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Product Sans Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.LightGray;
            this.login_button.Location = new System.Drawing.Point(415, 473);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(259, 46);
            this.login_button.TabIndex = 1;
            this.login_button.Text = "LOG IN";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_label.Font = new System.Drawing.Font("Product Sans Black", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.LightGray;
            this.welcome_label.Location = new System.Drawing.Point(325, 340);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(454, 101);
            this.welcome_label.TabIndex = 3;
            this.welcome_label.Text = "WELCOME";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Product Sans Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Location = new System.Drawing.Point(414, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "REGISTER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // close_label
            // 
            this.close_label.AutoSize = true;
            this.close_label.BackColor = System.Drawing.Color.Transparent;
            this.close_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_label.Font = new System.Drawing.Font("Product Sans Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_label.ForeColor = System.Drawing.Color.LightGray;
            this.close_label.Location = new System.Drawing.Point(1044, 8);
            this.close_label.Name = "close_label";
            this.close_label.Size = new System.Drawing.Size(24, 24);
            this.close_label.TabIndex = 5;
            this.close_label.Text = "X";
            this.close_label.Click += new System.EventHandler(this.close_label_Click);
            // 
            // help_label
            // 
            this.help_label.AutoSize = true;
            this.help_label.BackColor = System.Drawing.Color.Transparent;
            this.help_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_label.Font = new System.Drawing.Font("Product Sans Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help_label.ForeColor = System.Drawing.Color.LightGray;
            this.help_label.Location = new System.Drawing.Point(1016, 7);
            this.help_label.Name = "help_label";
            this.help_label.Size = new System.Drawing.Size(22, 25);
            this.help_label.TabIndex = 6;
            this.help_label.Text = "?";
            this.help_label.MouseHover += new System.EventHandler(this.help_label_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(414, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 3);
            this.panel1.TabIndex = 7;
            // 
            // New_user_label
            // 
            this.New_user_label.AutoSize = true;
            this.New_user_label.BackColor = System.Drawing.Color.Transparent;
            this.New_user_label.Font = new System.Drawing.Font("Product Sans Medium", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_user_label.ForeColor = System.Drawing.Color.White;
            this.New_user_label.Location = new System.Drawing.Point(617, 529);
            this.New_user_label.Name = "New_user_label";
            this.New_user_label.Size = new System.Drawing.Size(60, 14);
            this.New_user_label.TabIndex = 8;
            this.New_user_label.Text = "New User?";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.New_user_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.help_label);
            this.Controls.Add(this.close_label);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label close_label;
        private System.Windows.Forms.Label help_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label New_user_label;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

