namespace ejecicio_6
{
    partial class frmPerimetro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerimetro));
            this.btnBorrar = new System.Windows.Forms.Button();
            this.grbPerimetro = new System.Windows.Forms.GroupBox();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.grbPerimetro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(617, 175);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(109, 76);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // grbPerimetro
            // 
            this.grbPerimetro.Controls.Add(this.txtPerimetro);
            this.grbPerimetro.Controls.Add(this.lblPerimetro);
            this.grbPerimetro.Location = new System.Drawing.Point(74, 292);
            this.grbPerimetro.Name = "grbPerimetro";
            this.grbPerimetro.Size = new System.Drawing.Size(512, 100);
            this.grbPerimetro.TabIndex = 21;
            this.grbPerimetro.TabStop = false;
            this.grbPerimetro.Text = "Resultado";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(175, 46);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(100, 20);
            this.txtPerimetro.TabIndex = 9;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(23, 49);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(146, 13);
            this.lblPerimetro.TabIndex = 1;
            this.lblPerimetro.Text = "El Perimetro del Cuadrado es:";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(617, 306);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 76);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertir.Image")));
            this.btnConvertir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConvertir.Location = new System.Drawing.Point(617, 58);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(109, 76);
            this.btnConvertir.TabIndex = 19;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(80, 145);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(153, 13);
            this.lblLado.TabIndex = 23;
            this.lblLado.Text = "Ingrese un Lado del Cuadrado:";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(249, 142);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.txtLado.TabIndex = 24;
            // 
            // frmPerimetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.grbPerimetro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPerimetro";
            this.Text = "Calcular Perimetro";
            this.grbPerimetro.ResumeLayout(false);
            this.grbPerimetro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox grbPerimetro;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
    }
}

