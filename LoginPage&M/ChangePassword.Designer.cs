namespace LoginPage_M
{
    partial class ChangePassword
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
            this.txtCreatePass = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnCreatePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCreatePass
            // 
            this.txtCreatePass.Location = new System.Drawing.Point(314, 138);
            this.txtCreatePass.Name = "txtCreatePass";
            this.txtCreatePass.Size = new System.Drawing.Size(280, 26);
            this.txtCreatePass.TabIndex = 0;
            // 
            // txtBox2
            // 
            this.txtBox2.AutoSize = true;
            this.txtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2.Location = new System.Drawing.Point(69, 207);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(187, 25);
            this.txtBox2.TabIndex = 32;
            this.txtBox2.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Create New Password";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(314, 206);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(280, 26);
            this.txtConfirmPass.TabIndex = 34;
            // 
            // btnCreatePassword
            // 
            this.btnCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePassword.Location = new System.Drawing.Point(385, 284);
            this.btnCreatePassword.Name = "btnCreatePassword";
            this.btnCreatePassword.Size = new System.Drawing.Size(209, 35);
            this.btnCreatePassword.TabIndex = 35;
            this.btnCreatePassword.Text = "Create Password";
            this.btnCreatePassword.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 419);
            this.Controls.Add(this.btnCreatePassword);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtCreatePass);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCreatePass;
        private System.Windows.Forms.Label txtBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Button btnCreatePassword;
    }
}