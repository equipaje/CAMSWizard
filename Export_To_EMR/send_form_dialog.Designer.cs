namespace Export_To_EMR
{
    partial class send_form_dialog
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
            this.lbl_header = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_field_description = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.lbl_print_header = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(26, 54);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(363, 32);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Send or Print Patient Documents";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(32, 141);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(333, 29);
            this.txt_email.TabIndex = 1;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // lbl_field_description
            // 
            this.lbl_field_description.AutoSize = true;
            this.lbl_field_description.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_field_description.Location = new System.Drawing.Point(31, 109);
            this.lbl_field_description.Name = "lbl_field_description";
            this.lbl_field_description.Size = new System.Drawing.Size(169, 17);
            this.lbl_field_description.TabIndex = 2;
            this.lbl_field_description.Text = "Enter patient\'s email address";
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(375, 141);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 29);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lbl_print_header
            // 
            this.lbl_print_header.AutoSize = true;
            this.lbl_print_header.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_print_header.Location = new System.Drawing.Point(30, 222);
            this.lbl_print_header.Name = "lbl_print_header";
            this.lbl_print_header.Size = new System.Drawing.Size(122, 21);
            this.lbl_print_header.TabIndex = 4;
            this.lbl_print_header.Text = "Print documents";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // send_form_dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_print_header);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.lbl_field_description);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_header);
            this.Name = "send_form_dialog";
            this.Text = "send_form_dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_field_description;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_print_header;
        private System.Windows.Forms.Button button1;
    }
}