
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
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.TbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gBPanes = new System.Windows.Forms.GroupBox();
            this.chBpe = new System.Windows.Forms.CheckBox();
            this.chBpn = new System.Windows.Forms.CheckBox();
            this.chBpa = new System.Windows.Forms.CheckBox();
            this.btnCerrarEmp = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tBcantidad = new System.Windows.Forms.TextBox();
            this.tBVentasP = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Dtpfecha = new System.Windows.Forms.DateTimePicker();
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
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(73, 12);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(168, 27);
            this.tBNombre.TabIndex = 1;
            // 
            // TbId
            // 
            this.TbId.Location = new System.Drawing.Point(319, 15);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(168, 27);
            this.TbId.TabIndex = 3;
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
            // gBPanes
            // 
            this.gBPanes.Controls.Add(this.chBpe);
            this.gBPanes.Controls.Add(this.chBpn);
            this.gBPanes.Controls.Add(this.chBpa);
            this.gBPanes.Location = new System.Drawing.Point(21, 98);
            this.gBPanes.Name = "gBPanes";
            this.gBPanes.Size = new System.Drawing.Size(171, 174);
            this.gBPanes.TabIndex = 7;
            this.gBPanes.TabStop = false;
            this.gBPanes.Text = "Tipo de pan";
            // 
            // chBpe
            // 
            this.chBpe.AutoSize = true;
            this.chBpe.Location = new System.Drawing.Point(20, 128);
            this.chBpe.Name = "chBpe";
            this.chBpe.Size = new System.Drawing.Size(112, 24);
            this.chBpe.TabIndex = 10;
            this.chBpe.Text = "Pan especial";
            this.chBpe.UseVisualStyleBackColor = true;
            // 
            // chBpn
            // 
            this.chBpn.AutoSize = true;
            this.chBpn.Location = new System.Drawing.Point(20, 84);
            this.chBpn.Name = "chBpn";
            this.chBpn.Size = new System.Drawing.Size(129, 24);
            this.chBpn.TabIndex = 9;
            this.chBpn.Text = "Pan no aliñado";
            this.chBpn.UseVisualStyleBackColor = true;
            // 
            // chBpa
            // 
            this.chBpa.AutoSize = true;
            this.chBpa.Location = new System.Drawing.Point(20, 41);
            this.chBpa.Name = "chBpa";
            this.chBpa.Size = new System.Drawing.Size(108, 24);
            this.chBpa.TabIndex = 8;
            this.chBpa.Text = "Pan aliñado";
            this.chBpa.UseVisualStyleBackColor = true;
            // 
            // btnCerrarEmp
            // 
            this.btnCerrarEmp.Location = new System.Drawing.Point(405, 372);
            this.btnCerrarEmp.Name = "btnCerrarEmp";
            this.btnCerrarEmp.Size = new System.Drawing.Size(183, 48);
            this.btnCerrarEmp.TabIndex = 8;
            this.btnCerrarEmp.Text = "Cerrar";
            this.btnCerrarEmp.UseVisualStyleBackColor = true;
            this.btnCerrarEmp.Click += new System.EventHandler(this.btnCerrarEmp_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(194, 372);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(183, 48);
            this.btnVender.TabIndex = 9;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(217, 139);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 20);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "cantidad:";
            this.lblCantidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBcantidad
            // 
            this.tBcantidad.Location = new System.Drawing.Point(220, 162);
            this.tBcantidad.Name = "tBcantidad";
            this.tBcantidad.Size = new System.Drawing.Size(68, 27);
            this.tBcantidad.TabIndex = 11;
            // 
            // tBVentasP
            // 
            this.tBVentasP.Location = new System.Drawing.Point(355, 105);
            this.tBVentasP.Multiline = true;
            this.tBVentasP.Name = "tBVentasP";
            this.tBVentasP.Size = new System.Drawing.Size(433, 234);
            this.tBVentasP.TabIndex = 12;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(222, 202);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(65, 34);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "precio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Dtpfecha
            // 
            this.Dtpfecha.Location = new System.Drawing.Point(525, 13);
            this.Dtpfecha.Name = "Dtpfecha";
            this.Dtpfecha.Size = new System.Drawing.Size(265, 27);
            this.Dtpfecha.TabIndex = 14;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dtpfecha);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tBVentasP);
            this.Controls.Add(this.tBcantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnCerrarEmp);
            this.Controls.Add(this.gBPanes);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tBNombre);
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
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox TbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gBPanes;
        private System.Windows.Forms.CheckBox chBpe;
        private System.Windows.Forms.CheckBox chBpn;
        private System.Windows.Forms.CheckBox chBpa;
        private System.Windows.Forms.Button btnCerrarEmp;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox tBcantidad;
        private System.Windows.Forms.TextBox tBVentasP;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DateTimePicker Dtpfecha;
    }
}