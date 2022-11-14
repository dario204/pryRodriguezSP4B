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
            this.btnValidar = new System.Windows.Forms.Button();
            this.btnMozo = new System.Windows.Forms.Button();
            this.lblMozo = new System.Windows.Forms.Label();
            this.btnTotales = new System.Windows.Forms.Button();
            this.lblTotales = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dgvMozos.Size = new System.Drawing.Size(860, 365);
            this.dgvMozos.TabIndex = 0;
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
            this.btnMozo.Location = new System.Drawing.Point(12, 481);
            this.btnMozo.Name = "btnMozo";
            this.btnMozo.Size = new System.Drawing.Size(135, 69);
            this.btnMozo.TabIndex = 2;
            this.btnMozo.Text = "Mozo del Dia";
            this.btnMozo.UseVisualStyleBackColor = true;
            // 
            // lblMozo
            // 
            this.lblMozo.AutoSize = true;
            this.lblMozo.Location = new System.Drawing.Point(181, 499);
            this.lblMozo.Name = "lblMozo";
            this.lblMozo.Size = new System.Drawing.Size(10, 16);
            this.lblMozo.TabIndex = 3;
            this.lblMozo.Text = ".";
            // 
            // btnTotales
            // 
            this.btnTotales.Location = new System.Drawing.Point(492, 481);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(113, 69);
            this.btnTotales.TabIndex = 4;
            this.btnTotales.Text = "Totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Location = new System.Drawing.Point(669, 499);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(44, 16);
            this.lblTotales.TabIndex = 5;
            this.lblTotales.Text = "label1";
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
            // frmMilanga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 565);
            this.Controls.Add(this.lblTotales);
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
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

