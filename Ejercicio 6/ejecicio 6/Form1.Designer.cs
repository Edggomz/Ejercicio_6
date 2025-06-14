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
            this.btnBorrar.BackColor = System.Drawing.Color.Cornsilk;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrar.Location = new System.Drawing.Point(926, 215);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(164, 94);
            this.btnBorrar.TabIndex = 22;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // grbPerimetro
            // 
            this.grbPerimetro.Controls.Add(this.txtPerimetro);
            this.grbPerimetro.Controls.Add(this.lblPerimetro);
            this.grbPerimetro.Location = new System.Drawing.Point(111, 359);
            this.grbPerimetro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbPerimetro.Name = "grbPerimetro";
            this.grbPerimetro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbPerimetro.Size = new System.Drawing.Size(768, 123);
            this.grbPerimetro.TabIndex = 21;
            this.grbPerimetro.TabStop = false;
            this.grbPerimetro.Text = "Resultado";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.BackColor = System.Drawing.Color.Cornsilk;
            this.txtPerimetro.Location = new System.Drawing.Point(262, 57);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(148, 22);
            this.txtPerimetro.TabIndex = 9;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(34, 60);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(215, 16);
            this.lblPerimetro.TabIndex = 1;
            this.lblPerimetro.Text = "El Perimetro del Cuadrado es:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Cornsilk;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(926, 377);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(164, 94);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.Cornsilk;
            this.btnConvertir.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertir.Image")));
            this.btnConvertir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConvertir.Location = new System.Drawing.Point(926, 71);
            this.btnConvertir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(164, 94);
            this.btnConvertir.TabIndex = 19;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(120, 178);
            this.lblLado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(220, 16);
            this.lblLado.TabIndex = 23;
            this.lblLado.Text = "Ingrese un Lado del Cuadrado:";
            // 
            // txtLado
            // 
            this.txtLado.BackColor = System.Drawing.Color.Cornsilk;
            this.txtLado.Location = new System.Drawing.Point(374, 175);
            this.txtLado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(148, 22);
            this.txtLado.TabIndex = 24;
            // 
            // frmPerimetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.grbPerimetro);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConvertir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

