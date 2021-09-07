
namespace OnlyPans
{
    partial class VentasEmpleados
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
            this.tbVenta = new System.Windows.Forms.TextBox();
            this.btnCerrarVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbVenta
            // 
            this.tbVenta.Location = new System.Drawing.Point(31, 23);
            this.tbVenta.Multiline = true;
            this.tbVenta.Name = "tbVenta";
            this.tbVenta.Size = new System.Drawing.Size(746, 353);
            this.tbVenta.TabIndex = 0;
            // 
            // btnCerrarVenta
            // 
            this.btnCerrarVenta.Location = new System.Drawing.Point(332, 397);
            this.btnCerrarVenta.Name = "btnCerrarVenta";
            this.btnCerrarVenta.Size = new System.Drawing.Size(147, 41);
            this.btnCerrarVenta.TabIndex = 1;
            this.btnCerrarVenta.Text = "Cerrar";
            this.btnCerrarVenta.UseVisualStyleBackColor = true;
            this.btnCerrarVenta.Click += new System.EventHandler(this.btnCerrarVenta_Click);
            // 
            // VentasEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarVenta);
            this.Controls.Add(this.tbVenta);
            this.Name = "VentasEmpleados";
            this.Text = "VentasEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVenta;
        private System.Windows.Forms.Button btnCerrarVenta;
    }
}