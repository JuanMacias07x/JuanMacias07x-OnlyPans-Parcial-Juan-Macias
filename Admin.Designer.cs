
namespace OnlyPans
{
    partial class Admin
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
            this.btnCerrarAdmin = new System.Windows.Forms.Button();
            this.rtbAdmin = new System.Windows.Forms.RichTextBox();
            this.btnAbrirrtxAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCerrarAdmin
            // 
            this.btnCerrarAdmin.Location = new System.Drawing.Point(443, 388);
            this.btnCerrarAdmin.Name = "btnCerrarAdmin";
            this.btnCerrarAdmin.Size = new System.Drawing.Size(166, 50);
            this.btnCerrarAdmin.TabIndex = 0;
            this.btnCerrarAdmin.Text = "Cerrar";
            this.btnCerrarAdmin.UseVisualStyleBackColor = true;
            this.btnCerrarAdmin.Click += new System.EventHandler(this.btnCerrarAdmin_Click);
            // 
            // rtbAdmin
            // 
            this.rtbAdmin.Location = new System.Drawing.Point(14, 13);
            this.rtbAdmin.Name = "rtbAdmin";
            this.rtbAdmin.Size = new System.Drawing.Size(773, 358);
            this.rtbAdmin.TabIndex = 1;
            this.rtbAdmin.Text = "";
            this.rtbAdmin.TextChanged += new System.EventHandler(this.rtbAdmin_TextChanged);
            // 
            // btnAbrirrtxAdmin
            // 
            this.btnAbrirrtxAdmin.Location = new System.Drawing.Point(200, 388);
            this.btnAbrirrtxAdmin.Name = "btnAbrirrtxAdmin";
            this.btnAbrirrtxAdmin.Size = new System.Drawing.Size(166, 50);
            this.btnAbrirrtxAdmin.TabIndex = 2;
            this.btnAbrirrtxAdmin.Text = "Abrir";
            this.btnAbrirrtxAdmin.UseVisualStyleBackColor = true;
            this.btnAbrirrtxAdmin.Click += new System.EventHandler(this.btnAbrirrtxAdmin_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrirrtxAdmin);
            this.Controls.Add(this.rtbAdmin);
            this.Controls.Add(this.btnCerrarAdmin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarAdmin;
        private System.Windows.Forms.RichTextBox rtbAdmin;
        private System.Windows.Forms.Button btnAbrirrtxAdmin;
    }
}