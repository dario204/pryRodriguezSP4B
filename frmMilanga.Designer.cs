namespace pryRodriguezSP4B
{
    partial class frmMilanga
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
            this.dgvMozos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnMozo = new System.Windows.Forms.Button();
            this.lblMozo = new System.Windows.Forms.Label();
            this.btnTotales = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbltotales = new System.Windows.Forms.Label();
            this.lblComidas = new System.Windows.Forms.Label();
            this.lblBebidasSin = new System.Windows.Forms.Label();
            this.lblBebidasCon = new System.Windows.Forms.Label();
            this.lblPostres = new System.Windows.Forms.Label();
            this.txtTotales = new System.Windows.Forms.TextBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtBebidasSin = new System.Windows.Forms.TextBox();
            this.txtBebidasCon = new System.Windows.Forms.TextBox();
            this.txtPostres = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMozos
            // 
            this.dgvMozos.AllowUserToAddRows = false;
            this.dgvMozos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMozos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Postres,
            this.Column4});
            this.dgvMozos.Location = new System.Drawing.Point(12, 48);
            this.dgvMozos.Name = "dgvMozos";
            this.dgvMozos.RowHeadersWidth = 51;
            this.dgvMozos.RowTemplate.Height = 24;
            this.dgvMozos.Size = new System.Drawing.Size(817, 274);
            this.dgvMozos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mozos";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Comidas";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bebidas con Alcohol";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Postres
            // 
            this.Postres.HeaderText = "Bebidas sin Alcohol";
            this.Postres.MinimumWidth = 6;
            this.Postres.Name = "Postres";
            this.Postres.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Postres";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(909, 128);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(140, 57);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar Datos";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // btnMozo
            // 
            this.btnMozo.Location = new System.Drawing.Point(12, 351);
            this.btnMozo.Name = "btnMozo";
            this.btnMozo.Size = new System.Drawing.Size(135, 69);
            this.btnMozo.TabIndex = 2;
            this.btnMozo.Text = "Mozo del Dia";
            this.btnMozo.UseVisualStyleBackColor = true;
            this.btnMozo.Click += new System.EventHandler(this.btnMozo_Click);
            // 
            // lblMozo
            // 
            this.lblMozo.AutoSize = true;
            this.lblMozo.Location = new System.Drawing.Point(191, 377);
            this.lblMozo.Name = "lblMozo";
            this.lblMozo.Size = new System.Drawing.Size(89, 16);
            this.lblMozo.TabIndex = 3;
            this.lblMozo.Text = "nombre mozo";
            // 
            // btnTotales
            // 
            this.btnTotales.Location = new System.Drawing.Point(529, 351);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(113, 69);
            this.btnTotales.TabIndex = 4;
            this.btnTotales.Text = "Totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(191, 433);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 16);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "total";
            // 
            // lbltotales
            // 
            this.lbltotales.AutoSize = true;
            this.lbltotales.Location = new System.Drawing.Point(711, 377);
            this.lbltotales.Name = "lbltotales";
            this.lbltotales.Size = new System.Drawing.Size(132, 16);
            this.lbltotales.TabIndex = 7;
            this.lbltotales.Text = "Importe total vendido";
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Location = new System.Drawing.Point(711, 433);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(61, 16);
            this.lblComidas.TabIndex = 8;
            this.lblComidas.Text = "Comidas";
            // 
            // lblBebidasSin
            // 
            this.lblBebidasSin.AutoSize = true;
            this.lblBebidasSin.Location = new System.Drawing.Point(711, 487);
            this.lblBebidasSin.Name = "lblBebidasSin";
            this.lblBebidasSin.Size = new System.Drawing.Size(126, 16);
            this.lblBebidasSin.TabIndex = 9;
            this.lblBebidasSin.Text = "Bebidas sin Alcohol";
            // 
            // lblBebidasCon
            // 
            this.lblBebidasCon.AutoSize = true;
            this.lblBebidasCon.Location = new System.Drawing.Point(711, 543);
            this.lblBebidasCon.Name = "lblBebidasCon";
            this.lblBebidasCon.Size = new System.Drawing.Size(130, 16);
            this.lblBebidasCon.TabIndex = 10;
            this.lblBebidasCon.Text = "Bebidas con alcohol";
            // 
            // lblPostres
            // 
            this.lblPostres.AutoSize = true;
            this.lblPostres.Location = new System.Drawing.Point(711, 597);
            this.lblPostres.Name = "lblPostres";
            this.lblPostres.Size = new System.Drawing.Size(53, 16);
            this.lblPostres.TabIndex = 11;
            this.lblPostres.Text = "Postres";
            // 
            // txtTotales
            // 
            this.txtTotales.Location = new System.Drawing.Point(897, 377);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.Size = new System.Drawing.Size(100, 22);
            this.txtTotales.TabIndex = 12;
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(897, 433);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(100, 22);
            this.txtComida.TabIndex = 13;
            // 
            // txtBebidasSin
            // 
            this.txtBebidasSin.Location = new System.Drawing.Point(897, 480);
            this.txtBebidasSin.Name = "txtBebidasSin";
            this.txtBebidasSin.Size = new System.Drawing.Size(100, 22);
            this.txtBebidasSin.TabIndex = 14;
            // 
            // txtBebidasCon
            // 
            this.txtBebidasCon.Location = new System.Drawing.Point(897, 536);
            this.txtBebidasCon.Name = "txtBebidasCon";
            this.txtBebidasCon.Size = new System.Drawing.Size(100, 22);
            this.txtBebidasCon.TabIndex = 15;
            // 
            // txtPostres
            // 
            this.txtPostres.Location = new System.Drawing.Point(897, 594);
            this.txtPostres.Name = "txtPostres";
            this.txtPostres.Size = new System.Drawing.Size(100, 22);
            this.txtPostres.TabIndex = 16;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1020, 677);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 63);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMilanga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 752);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtPostres);
            this.Controls.Add(this.txtBebidasCon);
            this.Controls.Add(this.txtBebidasSin);
            this.Controls.Add(this.txtComida);
            this.Controls.Add(this.txtTotales);
            this.Controls.Add(this.lblPostres);
            this.Controls.Add(this.lblBebidasCon);
            this.Controls.Add(this.lblBebidasSin);
            this.Controls.Add(this.lblComidas);
            this.Controls.Add(this.lbltotales);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.lblMozo);
            this.Controls.Add(this.btnMozo);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.dgvMozos);
            this.Name = "frmMilanga";
            this.Text = "Bar Milanga";
            this.Load += new System.EventHandler(this.frmMilanga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMozos;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Button btnMozo;
        private System.Windows.Forms.Label lblMozo;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lbltotales;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.Label lblBebidasSin;
        private System.Windows.Forms.Label lblBebidasCon;
        private System.Windows.Forms.Label lblPostres;
        private System.Windows.Forms.TextBox txtTotales;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtBebidasSin;
        private System.Windows.Forms.TextBox txtBebidasCon;
        private System.Windows.Forms.TextBox txtPostres;
        private System.Windows.Forms.Button btnSalir;
    }
}

