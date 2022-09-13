namespace WhatsAppEscritorio
{
    partial class FrmVerVentas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label numLabel;
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label tOTALLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ventaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.ventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pruebaTikDataSet = new WhatsAppEscritorio.PruebaTikDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.ventaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventaDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALTextBox = new System.Windows.Forms.TextBox();
            this.ventaTableAdapter = new WhatsAppEscritorio.PruebaTikDataSetTableAdapters.VentaTableAdapter();
            this.tableAdapterManager = new WhatsAppEscritorio.PruebaTikDataSetTableAdapters.TableAdapterManager();
            this.ventaDetalleTableAdapter = new WhatsAppEscritorio.PruebaTikDataSetTableAdapters.VentaDetalleTableAdapter();
            this.fechaLabel1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            numLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            tOTALLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingNavigator)).BeginInit();
            this.ventaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaTikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(60, 55);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(22, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // numLabel
            // 
            numLabel.AutoSize = true;
            numLabel.Location = new System.Drawing.Point(405, 15);
            numLabel.Name = "numLabel";
            numLabel.Size = new System.Drawing.Size(39, 17);
            numLabel.TabIndex = 3;
            numLabel.Text = "Num:";
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new System.Drawing.Point(32, 102);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(50, 17);
            clienteLabel.TabIndex = 5;
            clienteLabel.Text = "Cliente:";
            // 
            // tOTALLabel
            // 
            tOTALLabel.AutoSize = true;
            tOTALLabel.Location = new System.Drawing.Point(387, 364);
            tOTALLabel.Name = "tOTALLabel";
            tOTALLabel.Size = new System.Drawing.Size(46, 17);
            tOTALLabel.TabIndex = 8;
            tOTALLabel.Text = "TOTAL:";
            // 
            // ventaBindingNavigator
            // 
            this.ventaBindingNavigator.AddNewItem = null;
            this.ventaBindingNavigator.BindingSource = this.ventaBindingSource;
            this.ventaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ventaBindingNavigator.DeleteItem = null;
            this.ventaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.ventaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ventaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ventaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ventaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ventaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ventaBindingNavigator.Name = "ventaBindingNavigator";
            this.ventaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ventaBindingNavigator.Size = new System.Drawing.Size(587, 25);
            this.ventaBindingNavigator.TabIndex = 0;
            this.ventaBindingNavigator.Text = "bindingNavigator1";
            // 
            // ventaBindingSource
            // 
            this.ventaBindingSource.DataMember = "Venta";
            this.ventaBindingSource.DataSource = this.pruebaTikDataSet;
            // 
            // pruebaTikDataSet
            // 
            this.pruebaTikDataSet.DataSetName = "PruebaTikDataSet";
            this.pruebaTikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(88, 52);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(67, 25);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numTextBox
            // 
            this.numTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Num", true));
            this.numTextBox.Location = new System.Drawing.Point(450, 12);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.ReadOnly = true;
            this.numTextBox.Size = new System.Drawing.Size(100, 25);
            this.numTextBox.TabIndex = 4;
            this.numTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.BackColor = System.Drawing.Color.White;
            this.clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Cliente", true));
            this.clienteTextBox.Location = new System.Drawing.Point(88, 99);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.ReadOnly = true;
            this.clienteTextBox.Size = new System.Drawing.Size(462, 25);
            this.clienteTextBox.TabIndex = 6;
            // 
            // ventaDetalleBindingSource
            // 
            this.ventaDetalleBindingSource.DataMember = "FK_VentaDetalle_Venta";
            this.ventaDetalleBindingSource.DataSource = this.ventaBindingSource;
            // 
            // ventaDetalleDataGridView
            // 
            this.ventaDetalleDataGridView.AllowUserToAddRows = false;
            this.ventaDetalleDataGridView.AllowUserToDeleteRows = false;
            this.ventaDetalleDataGridView.AutoGenerateColumns = false;
            this.ventaDetalleDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ventaDetalleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ventaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventaDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ventaDetalleDataGridView.DataSource = this.ventaDetalleBindingSource;
            this.ventaDetalleDataGridView.Enabled = false;
            this.ventaDetalleDataGridView.Location = new System.Drawing.Point(30, 155);
            this.ventaDetalleDataGridView.Name = "ventaDetalleDataGridView";
            this.ventaDetalleDataGridView.ReadOnly = true;
            this.ventaDetalleDataGridView.RowHeadersVisible = false;
            this.ventaDetalleDataGridView.Size = new System.Drawing.Size(520, 173);
            this.ventaDetalleDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdVenta";
            this.dataGridViewTextBoxColumn2.HeaderText = "IdVenta";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cantidad";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "Cant.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn4.HeaderText = "D  e  s  c  r  i  p  c  i  ó  n";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 266;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PrecioUnitario";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Importe";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn6.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tOTALTextBox
            // 
            this.tOTALTextBox.BackColor = System.Drawing.Color.LightGreen;
            this.tOTALTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "TOTAL", true));
            this.tOTALTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tOTALTextBox.Location = new System.Drawing.Point(450, 359);
            this.tOTALTextBox.Name = "tOTALTextBox";
            this.tOTALTextBox.ReadOnly = true;
            this.tOTALTextBox.Size = new System.Drawing.Size(100, 27);
            this.tOTALTextBox.TabIndex = 9;
            this.tOTALTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ventaTableAdapter
            // 
            this.ventaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WhatsAppEscritorio.PruebaTikDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentaDetalleTableAdapter = this.ventaDetalleTableAdapter;
            this.tableAdapterManager.VentaTableAdapter = this.ventaTableAdapter;
            // 
            // ventaDetalleTableAdapter
            // 
            this.ventaDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // fechaLabel1
            // 
            this.fechaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventaBindingSource, "Fecha", true));
            this.fechaLabel1.Location = new System.Drawing.Point(204, 51);
            this.fechaLabel1.Name = "fechaLabel1";
            this.fechaLabel1.Size = new System.Drawing.Size(346, 23);
            this.fechaLabel1.TabIndex = 11;
            this.fechaLabel1.Text = "-- / -- / ----";
            this.fechaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmVerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 431);
            this.Controls.Add(this.fechaLabel1);
            this.Controls.Add(tOTALLabel);
            this.Controls.Add(this.tOTALTextBox);
            this.Controls.Add(this.ventaDetalleDataGridView);
            this.Controls.Add(clienteLabel);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(numLabel);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.ventaBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVerVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  FrmVerVentas";
            this.Load += new System.EventHandler(this.FrmVerVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingNavigator)).EndInit();
            this.ventaBindingNavigator.ResumeLayout(false);
            this.ventaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaTikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventaDetalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PruebaTikDataSet pruebaTikDataSet;
        private System.Windows.Forms.BindingSource ventaBindingSource;
        private PruebaTikDataSetTableAdapters.VentaTableAdapter ventaTableAdapter;
        private PruebaTikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ventaBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private PruebaTikDataSetTableAdapters.VentaDetalleTableAdapter ventaDetalleTableAdapter;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.BindingSource ventaDetalleBindingSource;
        private System.Windows.Forms.DataGridView ventaDetalleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox tOTALTextBox;
        private System.Windows.Forms.Label fechaLabel1;
    }
}