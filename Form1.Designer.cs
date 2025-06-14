namespace Calcular_el_cambio_según_una_compra
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.txtDinero = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblDinero = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gbPrincipal.Controls.Add(this.lblError);
            this.gbPrincipal.Controls.Add(this.btnLimpiar);
            this.gbPrincipal.Controls.Add(this.btnComprar);
            this.gbPrincipal.Controls.Add(this.lblCambio);
            this.gbPrincipal.Controls.Add(this.txtCambio);
            this.gbPrincipal.Controls.Add(this.txtDinero);
            this.gbPrincipal.Controls.Add(this.txtCosto);
            this.gbPrincipal.Controls.Add(this.lblDinero);
            this.gbPrincipal.Controls.Add(this.lblCosto);
            this.gbPrincipal.Location = new System.Drawing.Point(201, 81);
            this.gbPrincipal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPrincipal.Size = new System.Drawing.Size(446, 217);
            this.gbPrincipal.TabIndex = 0;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Pantalla Principal";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(211, 176);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 30);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Error\r\n\r\n";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(280, 129);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(280, 70);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(22, 152);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(51, 15);
            this.lblCambio.TabIndex = 5;
            this.lblCambio.Text = "Cambio";
            // 
            // txtCambio
            // 
            this.txtCambio.Location = new System.Drawing.Point(20, 176);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(100, 22);
            this.txtCambio.TabIndex = 4;
            // 
            // txtDinero
            // 
            this.txtDinero.Location = new System.Drawing.Point(20, 120);
            this.txtDinero.Name = "txtDinero";
            this.txtDinero.Size = new System.Drawing.Size(140, 22);
            this.txtDinero.TabIndex = 3;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(20, 49);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 22);
            this.txtCosto.TabIndex = 2;
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Location = new System.Drawing.Point(17, 88);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(120, 15);
            this.lblDinero.TabIndex = 1;
            this.lblDinero.Text = "Cantidad de dinero:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(17, 31);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(113, 15);
            this.lblCosto.TabIndex = 0;
            this.lblCosto.Text = "Costo del Articulo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.gbPrincipal);
            this.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Calcular el cambio según una compra";
            this.gbPrincipal.ResumeLayout(false);
            this.gbPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.TextBox txtDinero;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label lblError;
    }
}

