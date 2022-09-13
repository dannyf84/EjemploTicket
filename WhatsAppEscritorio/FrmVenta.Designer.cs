namespace WhatsAppEscritorio
{
    partial class FrmVenta
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
            System.Windows.Forms.Label TipoArticuloLabel;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvTemp = new System.Windows.Forms.DataGridView();
            this.IdVenta_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAddProducto = new System.Windows.Forms.Panel();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.Nud1 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblTOTAL = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            TipoArticuloLabel = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTemp)).BeginInit();
            this.pnlAddProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoArticuloLabel
            // 
            TipoArticuloLabel.AutoSize = true;
            TipoArticuloLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TipoArticuloLabel.ForeColor = System.Drawing.Color.Navy;
            TipoArticuloLabel.Location = new System.Drawing.Point(161, 4);
            TipoArticuloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            TipoArticuloLabel.Name = "TipoArticuloLabel";
            TipoArticuloLabel.Size = new System.Drawing.Size(76, 17);
            TipoArticuloLabel.TabIndex = 357;
            TipoArticuloLabel.Text = "Descripción";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.ForeColor = System.Drawing.Color.Navy;
            label17.Location = new System.Drawing.Point(341, 4);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(44, 17);
            label17.TabIndex = 374;
            label17.Text = "Precio";
            // 
            // DgvTemp
            // 
            this.DgvTemp.AllowUserToAddRows = false;
            this.DgvTemp.AllowUserToDeleteRows = false;
            this.DgvTemp.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.DgvTemp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvTemp.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTemp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVenta_,
            this.Cantidad_,
            this.Descripcion_,
            this.Precio_,
            this.Importe_});
            this.DgvTemp.Location = new System.Drawing.Point(28, 182);
            this.DgvTemp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DgvTemp.Name = "DgvTemp";
            this.DgvTemp.ReadOnly = true;
            this.DgvTemp.RowHeadersVisible = false;
            this.DgvTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTemp.Size = new System.Drawing.Size(520, 173);
            this.DgvTemp.TabIndex = 401;
            // 
            // IdVenta_
            // 
            this.IdVenta_.DataPropertyName = "IdVenta";
            this.IdVenta_.HeaderText = "IdVenta";
            this.IdVenta_.Name = "IdVenta_";
            this.IdVenta_.ReadOnly = true;
            this.IdVenta_.Visible = false;
            // 
            // Cantidad_
            // 
            this.Cantidad_.DataPropertyName = "Cantidad";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad_.DefaultCellStyle = dataGridViewCellStyle9;
            this.Cantidad_.HeaderText = "Cant.";
            this.Cantidad_.Name = "Cantidad_";
            this.Cantidad_.ReadOnly = true;
            this.Cantidad_.Width = 50;
            // 
            // Descripcion_
            // 
            this.Descripcion_.DataPropertyName = "Descripcion";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Descripcion_.DefaultCellStyle = dataGridViewCellStyle10;
            this.Descripcion_.HeaderText = "D  e  s  c  r  i  p  c  i  ó  n";
            this.Descripcion_.Name = "Descripcion_";
            this.Descripcion_.ReadOnly = true;
            this.Descripcion_.Width = 266;
            // 
            // Precio_
            // 
            this.Precio_.DataPropertyName = "Precio";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Precio_.DefaultCellStyle = dataGridViewCellStyle11;
            this.Precio_.HeaderText = "Precio";
            this.Precio_.Name = "Precio_";
            this.Precio_.ReadOnly = true;
            // 
            // Importe_
            // 
            this.Importe_.DataPropertyName = "Importe";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Importe_.DefaultCellStyle = dataGridViewCellStyle12;
            this.Importe_.HeaderText = "Importe";
            this.Importe_.Name = "Importe_";
            this.Importe_.ReadOnly = true;
            // 
            // pnlAddProducto
            // 
            this.pnlAddProducto.BackColor = System.Drawing.SystemColors.Control;
            this.pnlAddProducto.Controls.Add(this.txtPrecio);
            this.pnlAddProducto.Controls.Add(label17);
            this.pnlAddProducto.Controls.Add(TipoArticuloLabel);
            this.pnlAddProducto.Controls.Add(this.txtDescripcion);
            this.pnlAddProducto.Controls.Add(this.Nud1);
            this.pnlAddProducto.Controls.Add(this.label16);
            this.pnlAddProducto.Controls.Add(this.btnAdd);
            this.pnlAddProducto.Location = new System.Drawing.Point(28, 103);
            this.pnlAddProducto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlAddProducto.Name = "pnlAddProducto";
            this.pnlAddProducto.Size = new System.Drawing.Size(523, 64);
            this.pnlAddProducto.TabIndex = 402;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BackColor = System.Drawing.Color.LightYellow;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(331, 28);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(60, 29);
            this.txtPrecio.TabIndex = 375;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.LightYellow;
            this.txtDescripcion.Location = new System.Drawing.Point(81, 31);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(231, 25);
            this.txtDescripcion.TabIndex = 371;
            // 
            // Nud1
            // 
            this.Nud1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.Nud1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nud1.Location = new System.Drawing.Point(15, 23);
            this.Nud1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Nud1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Nud1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud1.Name = "Nud1";
            this.Nud1.Size = new System.Drawing.Size(47, 33);
            this.Nud1.TabIndex = 304;
            this.Nud1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nud1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(12, 4);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 17);
            this.label16.TabIndex = 303;
            this.label16.Text = "Cantidad";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(411, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 40);
            this.btnAdd.TabIndex = 373;
            this.btnAdd.Text = "A&gregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 403;
            this.label1.Text = "CLIENTE:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(451, 18);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 25);
            this.txtNum.TabIndex = 404;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(109, 59);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(442, 25);
            this.txtCliente.TabIndex = 405;
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.BackColor = System.Drawing.Color.LightGreen;
            this.lblTOTAL.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOTAL.Location = new System.Drawing.Point(451, 379);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(100, 27);
            this.lblTOTAL.TabIndex = 406;
            this.lblTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(233, 373);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 40);
            this.btnGuardar.TabIndex = 407;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 431);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTOTAL);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlAddProducto);
            this.Controls.Add(this.DgvTemp);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Venta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTemp)).EndInit();
            this.pnlAddProducto.ResumeLayout(false);
            this.pnlAddProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenta_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe_;
        private System.Windows.Forms.Panel pnlAddProducto;
        internal System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown Nud1;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox lblTOTAL;
        private System.Windows.Forms.Button btnGuardar;
    }
}

