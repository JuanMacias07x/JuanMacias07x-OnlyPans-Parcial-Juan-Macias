
namespace OnlyPans
{
    partial class Empleados
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.rbPa = new System.Windows.Forms.RadioButton();
            this.rbPn = new System.Windows.Forms.RadioButton();
            this.rbPe = new System.Windows.Forms.RadioButton();
            this.gBPanes = new System.Windows.Forms.GroupBox();
            this.gBPanes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(319, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 27);
            this.textBox2.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(263, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(58, 20);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Cédula:";
            // 
            // rbPa
            // 
            this.rbPa.AutoSize = true;
            this.rbPa.Location = new System.Drawing.Point(44, 43);
            this.rbPa.Name = "rbPa";
            this.rbPa.Size = new System.Drawing.Size(107, 24);
            this.rbPa.TabIndex = 4;
            this.rbPa.TabStop = true;
            this.rbPa.Text = "Pan aliñado";
            this.rbPa.UseVisualStyleBackColor = true;
            // 
            // rbPn
            // 
            this.rbPn.AutoSize = true;
            this.rbPn.Location = new System.Drawing.Point(44, 89);
            this.rbPn.Name = "rbPn";
            this.rbPn.Size = new System.Drawing.Size(128, 24);
            this.rbPn.TabIndex = 5;
            this.rbPn.TabStop = true;
            this.rbPn.Text = "Pan no aliñado";
            this.rbPn.UseVisualStyleBackColor = true;
            // 
            // rbPe
            // 
            this.rbPe.AutoSize = true;
            this.rbPe.Location = new System.Drawing.Point(44, 133);
            this.rbPe.Name = "rbPe";
            this.rbPe.Size = new System.Drawing.Size(111, 24);
            this.rbPe.TabIndex = 6;
            this.rbPe.TabStop = true;
            this.rbPe.Text = "Pan especial";
            this.rbPe.UseVisualStyleBackColor = true;
            // 
            // gBPanes
            // 
            this.gBPanes.Controls.Add(this.rbPe);
            this.gBPanes.Controls.Add(this.rbPn);
            this.gBPanes.Controls.Add(this.rbPa);
            this.gBPanes.Location = new System.Drawing.Point(12, 82);
            this.gBPanes.Name = "gBPanes";
            this.gBPanes.Size = new System.Drawing.Size(171, 174);
            this.gBPanes.TabIndex = 7;
            this.gBPanes.TabStop = false;
            this.gBPanes.Text = "Tipo de pan";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBPanes);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNombre);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.gBPanes.ResumeLayout(false);
            this.gBPanes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.RadioButton rbPa;
        private System.Windows.Forms.RadioButton rbPn;
        private System.Windows.Forms.RadioButton rbPe;
        private System.Windows.Forms.GroupBox gBPanes;
    }
}