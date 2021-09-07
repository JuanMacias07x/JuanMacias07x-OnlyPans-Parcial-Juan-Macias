
namespace OnlyPans
{
    partial class OnlyPans
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntIngresar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.tBUser = new System.Windows.Forms.TextBox();
            this.tBPssw = new System.Windows.Forms.TextBox();
            this.lblPssw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnlyPans.Properties.Resources.OnlyPans_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bntIngresar
            // 
            this.bntIngresar.Location = new System.Drawing.Point(87, 289);
            this.bntIngresar.Name = "bntIngresar";
            this.bntIngresar.Size = new System.Drawing.Size(140, 44);
            this.bntIngresar.TabIndex = 1;
            this.bntIngresar.Text = "Ingresar";
            this.bntIngresar.UseVisualStyleBackColor = true;
            this.bntIngresar.Click += new System.EventHandler(this.bntIngresar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(248, 289);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 44);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
            this.lblUser.Location = new System.Drawing.Point(87, 35);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(62, 20);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuario:";
            // 
            // tBUser
            // 
            this.tBUser.Location = new System.Drawing.Point(87, 58);
            this.tBUser.Name = "tBUser";
            this.tBUser.Size = new System.Drawing.Size(308, 27);
            this.tBUser.TabIndex = 4;
            // 
            // tBPssw
            // 
            this.tBPssw.Location = new System.Drawing.Point(87, 125);
            this.tBPssw.Name = "tBPssw";
            this.tBPssw.Size = new System.Drawing.Size(308, 27);
            this.tBPssw.TabIndex = 6;
            this.tBPssw.UseSystemPasswordChar = true;
            // 
            // lblPssw
            // 
            this.lblPssw.AutoSize = true;
            this.lblPssw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(226)))), ((int)(((byte)(222)))));
            this.lblPssw.Location = new System.Drawing.Point(87, 102);
            this.lblPssw.Name = "lblPssw";
            this.lblPssw.Size = new System.Drawing.Size(86, 20);
            this.lblPssw.TabIndex = 5;
            this.lblPssw.Text = "Contraseña:";
            // 
            // OnlyPans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 388);
            this.Controls.Add(this.tBPssw);
            this.Controls.Add(this.lblPssw);
            this.Controls.Add(this.tBUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.bntIngresar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OnlyPans";
            this.Text = "OnlyPans";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bntIngresar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox tBUser;
        private System.Windows.Forms.TextBox tBPssw;
        private System.Windows.Forms.Label lblPssw;
    }
}

