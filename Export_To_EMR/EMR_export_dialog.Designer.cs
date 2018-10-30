using System.Windows.Forms;

namespace Export_To_EMR
{
    partial class EMR_export_dialog
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
            this.btn_PDF = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_step1_description = new System.Windows.Forms.Label();
            this.lbl_step1 = new System.Windows.Forms.Label();
            this.lbl_step2 = new System.Windows.Forms.Label();
            this.lbl_step2_description = new System.Windows.Forms.Label();
            this.lbl_step3 = new System.Windows.Forms.Label();
            this.lbl_step3_description = new System.Windows.Forms.Label();
            this.txtbx_EMR_Data = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_PDF
            // 
            this.btn_PDF.Font = new System.Drawing.Font("Segoe UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PDF.Location = new System.Drawing.Point(42, 109);
            this.btn_PDF.Name = "btn_PDF";
            this.btn_PDF.Size = new System.Drawing.Size(88, 83);
            this.btn_PDF.TabIndex = 0;
            this.btn_PDF.Text = "Save as PDF";
            this.btn_PDF.UseVisualStyleBackColor = true;
            this.btn_PDF.Click += new System.EventHandler(this.btn_PDF_Click);
            // 
            // btn_next
            // 
            this.btn_next.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(475, 237);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(85, 34);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_step1_description
            // 
            this.lbl_step1_description.AutoSize = true;
            this.lbl_step1_description.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step1_description.Location = new System.Drawing.Point(37, 60);
            this.lbl_step1_description.Name = "lbl_step1_description";
            this.lbl_step1_description.Size = new System.Drawing.Size(308, 25);
            this.lbl_step1_description.TabIndex = 2;
            this.lbl_step1_description.Text = "Save the Handwritten Form as a PDF";
            this.lbl_step1_description.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_step1
            // 
            this.lbl_step1.AutoSize = true;
            this.lbl_step1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step1.Location = new System.Drawing.Point(36, 18);
            this.lbl_step1.Name = "lbl_step1";
            this.lbl_step1.Size = new System.Drawing.Size(82, 32);
            this.lbl_step1.TabIndex = 3;
            this.lbl_step1.Text = "Step 1";
            // 
            // lbl_step2
            // 
            this.lbl_step2.AutoSize = true;
            this.lbl_step2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step2.Location = new System.Drawing.Point(36, 18);
            this.lbl_step2.Name = "lbl_step2";
            this.lbl_step2.Size = new System.Drawing.Size(82, 32);
            this.lbl_step2.TabIndex = 4;
            this.lbl_step2.Text = "Step 2";
            this.lbl_step2.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_step2_description
            // 
            this.lbl_step2_description.AutoSize = true;
            this.lbl_step2_description.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step2_description.Location = new System.Drawing.Point(37, 60);
            this.lbl_step2_description.Name = "lbl_step2_description";
            this.lbl_step2_description.Size = new System.Drawing.Size(375, 25);
            this.lbl_step2_description.TabIndex = 5;
            this.lbl_step2_description.Text = "Convert handwriting to text in the Word app.";
            // 
            // lbl_step3
            // 
            this.lbl_step3.AutoSize = true;
            this.lbl_step3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step3.Location = new System.Drawing.Point(36, 18);
            this.lbl_step3.Name = "lbl_step3";
            this.lbl_step3.Size = new System.Drawing.Size(82, 32);
            this.lbl_step3.TabIndex = 6;
            this.lbl_step3.Text = "Step 3";
            // 
            // lbl_step3_description
            // 
            this.lbl_step3_description.AutoSize = true;
            this.lbl_step3_description.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_step3_description.Location = new System.Drawing.Point(37, 60);
            this.lbl_step3_description.Name = "lbl_step3_description";
            this.lbl_step3_description.Size = new System.Drawing.Size(405, 25);
            this.lbl_step3_description.TabIndex = 7;
            this.lbl_step3_description.Text = "Copy and paste plain text into your EMR system.";
            // 
            // txtbx_EMR_Data
            // 
            this.txtbx_EMR_Data.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_EMR_Data.Location = new System.Drawing.Point(42, 109);
            this.txtbx_EMR_Data.Multiline = true;
            this.txtbx_EMR_Data.Name = "txtbx_EMR_Data";
            this.txtbx_EMR_Data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_EMR_Data.Size = new System.Drawing.Size(495, 103);
            this.txtbx_EMR_Data.TabIndex = 8;
            // 
            // dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 292);
            this.Controls.Add(this.lbl_step1);
            this.Controls.Add(this.lbl_step1_description);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_PDF);
            this.Controls.Add(this.lbl_step2);
            this.Controls.Add(this.lbl_step2_description);
            this.Controls.Add(this.lbl_step3);
            this.Controls.Add(this.lbl_step3_description);
            this.Controls.Add(this.txtbx_EMR_Data);
            this.Name = "dialog";
            this.Text = "Export to EMR";
            this.Load += new System.EventHandler(this.EMR_export_dialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PDF;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_step1_description;
        private System.Windows.Forms.Label lbl_step1;
        private Label lbl_step2;
        private Label lbl_step2_description;
        private Label lbl_step3;
        private Label lbl_step3_description;
        private TextBox txtbx_EMR_Data;
    }

    
}