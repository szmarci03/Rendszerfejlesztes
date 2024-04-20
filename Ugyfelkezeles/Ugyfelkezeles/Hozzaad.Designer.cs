namespace Ugyfelkezeles
{
    partial class Hozzaad
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
            this.richTextBoxid = new System.Windows.Forms.RichTextBox();
            this.username = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBoxfirstname = new System.Windows.Forms.RichTextBox();
            this.richTextBoxusername = new System.Windows.Forms.RichTextBox();
            this.id = new System.Windows.Forms.Label();
            this.richTextBoxlastname = new System.Windows.Forms.RichTextBox();
            this.email = new System.Windows.Forms.Label();
            this.richTextBoxemail = new System.Windows.Forms.RichTextBox();
            this.superuser = new System.Windows.Forms.RichTextBox();
            this.suser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxid
            // 
            this.richTextBoxid.Location = new System.Drawing.Point(350, 47);
            this.richTextBoxid.Name = "richTextBoxid";
            this.richTextBoxid.Size = new System.Drawing.Size(567, 51);
            this.richTextBoxid.TabIndex = 0;
            this.richTextBoxid.Text = "";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(127, 138);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(107, 25);
            this.username.TabIndex = 3;
            this.username.Text = "username";
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.Location = new System.Drawing.Point(127, 234);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(100, 25);
            this.firstname.TabIndex = 4;
            this.firstname.Text = "firstname";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.Location = new System.Drawing.Point(128, 337);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(99, 25);
            this.lastname.TabIndex = 5;
            this.lastname.Text = "lastname";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 67);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hozzáadás";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxfirstname
            // 
            this.richTextBoxfirstname.Location = new System.Drawing.Point(350, 221);
            this.richTextBoxfirstname.Name = "richTextBoxfirstname";
            this.richTextBoxfirstname.Size = new System.Drawing.Size(567, 51);
            this.richTextBoxfirstname.TabIndex = 7;
            this.richTextBoxfirstname.Text = "";
            // 
            // richTextBoxusername
            // 
            this.richTextBoxusername.Location = new System.Drawing.Point(350, 135);
            this.richTextBoxusername.Name = "richTextBoxusername";
            this.richTextBoxusername.Size = new System.Drawing.Size(567, 51);
            this.richTextBoxusername.TabIndex = 8;
            this.richTextBoxusername.Text = "";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(149, 47);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(29, 25);
            this.id.TabIndex = 9;
            this.id.Text = "id";
            // 
            // richTextBoxlastname
            // 
            this.richTextBoxlastname.Location = new System.Drawing.Point(350, 311);
            this.richTextBoxlastname.Name = "richTextBoxlastname";
            this.richTextBoxlastname.Size = new System.Drawing.Size(567, 51);
            this.richTextBoxlastname.TabIndex = 10;
            this.richTextBoxlastname.Text = "";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(128, 545);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(63, 25);
            this.email.TabIndex = 12;
            this.email.Text = "email";
            // 
            // richTextBoxemail
            // 
            this.richTextBoxemail.Location = new System.Drawing.Point(350, 519);
            this.richTextBoxemail.Name = "richTextBoxemail";
            this.richTextBoxemail.Size = new System.Drawing.Size(567, 51);
            this.richTextBoxemail.TabIndex = 14;
            this.richTextBoxemail.Text = "";
            // 
            // superuser
            // 
            this.superuser.Location = new System.Drawing.Point(350, 418);
            this.superuser.Name = "superuser";
            this.superuser.Size = new System.Drawing.Size(56, 51);
            this.superuser.TabIndex = 15;
            this.superuser.Text = "";
            // 
            // suser
            // 
            this.suser.AutoSize = true;
            this.suser.Location = new System.Drawing.Point(127, 434);
            this.suser.Name = "suser";
            this.suser.Size = new System.Drawing.Size(173, 25);
            this.suser.TabIndex = 16;
            this.suser.Text = "Superuser? (0,1)";
            // 
            // Hozzaad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 781);
            this.Controls.Add(this.suser);
            this.Controls.Add(this.superuser);
            this.Controls.Add(this.richTextBoxemail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.richTextBoxlastname);
            this.Controls.Add(this.id);
            this.Controls.Add(this.richTextBoxusername);
            this.Controls.Add(this.richTextBoxfirstname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.username);
            this.Controls.Add(this.richTextBoxid);
            this.Name = "Hozzaad";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxid;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBoxfirstname;
        private System.Windows.Forms.RichTextBox richTextBoxusername;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.RichTextBox richTextBoxlastname;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.RichTextBox richTextBoxemail;
        private System.Windows.Forms.RichTextBox superuser;
        private System.Windows.Forms.Label suser;
    }
}