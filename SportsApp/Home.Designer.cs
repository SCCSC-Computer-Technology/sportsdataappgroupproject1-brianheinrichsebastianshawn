namespace sportsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.homePicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.registrationControl = new sportsApp.RegistrationControl();
            ((System.ComponentModel.ISupportInitialize)(this.homePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 99;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 100;
            this.label2.Text = "Password";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.Location = new System.Drawing.Point(102, 156);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(131, 23);
            this.emailTextbox.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(102, 215);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(131, 23);
            this.passwordTextbox.TabIndex = 1;
            // 
            // signInButton
            // 
            this.signInButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.Location = new System.Drawing.Point(129, 268);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(75, 23);
            this.signInButton.TabIndex = 2;
            this.signInButton.Text = "Sign In";
            this.toolTip1.SetToolTip(this.signInButton, "Press to Sign In");
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // registerLink
            // 
            this.registerLink.AutoSize = true;
            this.registerLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLink.Location = new System.Drawing.Point(119, 307);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(94, 15);
            this.registerLink.TabIndex = 3;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Click To Register";
            this.toolTip1.SetToolTip(this.registerLink, "Click To Register");
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // homePicture
            // 
            this.homePicture.Image = ((System.Drawing.Image)(resources.GetObject("homePicture.Image")));
            this.homePicture.Location = new System.Drawing.Point(-3, -9);
            this.homePicture.Name = "homePicture";
            this.homePicture.Size = new System.Drawing.Size(791, 534);
            this.homePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homePicture.TabIndex = 5;
            this.homePicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.signInButton);
            this.panel1.Controls.Add(this.passwordTextbox);
            this.panel1.Controls.Add(this.emailTextbox);
            this.panel1.Controls.Add(this.registerLink);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(468, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 450);
            this.panel1.TabIndex = 0;
            // 
            // registrationControl
            // 
            this.registrationControl.BackColor = System.Drawing.Color.White;
            this.registrationControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationControl.Location = new System.Drawing.Point(468, 0);
            this.registrationControl.Name = "registrationControl";
            this.registrationControl.Size = new System.Drawing.Size(332, 450);
            this.registrationControl.TabIndex = 6;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.homePicture);
            this.Controls.Add(this.registrationControl);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sports Stats";
            ((System.ComponentModel.ISupportInitialize)(this.homePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.PictureBox homePicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private RegistrationControl registrationControl;
    }
}

