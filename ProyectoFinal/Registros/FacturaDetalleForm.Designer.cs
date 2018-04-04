namespace ProyectoFinal.Registros
{
    partial class FacturaDetalleForm
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
            this.BuscarButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ObservacionesTextBox = new System.Windows.Forms.TextBox();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.PeliculaComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CantidadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FactIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(194, 10);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(69, 25);
            this.BuscarButton.TabIndex = 132;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 131;
            this.label7.Text = "Fecha";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Location = new System.Drawing.Point(322, 14);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaDateTimePicker.TabIndex = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 129;
            this.label5.Text = "Observaciones";
            // 
            // ObservacionesTextBox
            // 
            this.ObservacionesTextBox.Location = new System.Drawing.Point(136, 291);
            this.ObservacionesTextBox.Multiline = true;
            this.ObservacionesTextBox.Name = "ObservacionesTextBox";
            this.ObservacionesTextBox.Size = new System.Drawing.Size(213, 53);
            this.ObservacionesTextBox.TabIndex = 128;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(333, 84);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(73, 26);
            this.AgregarButton.TabIndex = 127;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // PeliculaComboBox
            // 
            this.PeliculaComboBox.FormattingEnabled = true;
            this.PeliculaComboBox.Location = new System.Drawing.Point(150, 88);
            this.PeliculaComboBox.Name = "PeliculaComboBox";
            this.PeliculaComboBox.Size = new System.Drawing.Size(80, 21);
            this.PeliculaComboBox.TabIndex = 126;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 125;
            this.label6.Text = "Total";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(398, 291);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(123, 20);
            this.TotalTextBox.TabIndex = 124;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(296, 379);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 122;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(205, 379);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 121;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(115, 379);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 120;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 119;
            this.label4.Text = "Cantidad";
            // 
            // CantidadNumericUpDown
            // 
            this.CantidadNumericUpDown.Location = new System.Drawing.Point(243, 88);
            this.CantidadNumericUpDown.Name = "CantidadNumericUpDown";
            this.CantidadNumericUpDown.Size = new System.Drawing.Size(84, 20);
            this.CantidadNumericUpDown.TabIndex = 118;
            // 
            // ClienteComboBox
            // 
            this.ClienteComboBox.FormattingEnabled = true;
            this.ClienteComboBox.Location = new System.Drawing.Point(63, 88);
            this.ClienteComboBox.Name = "ClienteComboBox";
            this.ClienteComboBox.Size = new System.Drawing.Size(79, 21);
            this.ClienteComboBox.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 116;
            this.label3.Text = "Pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Cliente ";
            // 
            // FDetalleDataGridView
            // 
            this.FDetalleDataGridView.AllowDrop = true;
            this.FDetalleDataGridView.AllowUserToOrderColumns = true;
            this.FDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FDetalleDataGridView.Location = new System.Drawing.Point(58, 127);
            this.FDetalleDataGridView.Name = "FDetalleDataGridView";
            this.FDetalleDataGridView.RowHeadersVisible = false;
            this.FDetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.FDetalleDataGridView.Size = new System.Drawing.Size(464, 146);
            this.FDetalleDataGridView.TabIndex = 114;
            this.FDetalleDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FDetalleDataGridView_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Factura Id";
            // 
            // FactIdNumericUpDown
            // 
            this.FactIdNumericUpDown.Location = new System.Drawing.Point(113, 14);
            this.FactIdNumericUpDown.Name = "FactIdNumericUpDown";
            this.FactIdNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.FactIdNumericUpDown.TabIndex = 112;
            // 
            // FacturaDetalleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 430);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ObservacionesTextBox);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.PeliculaComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CantidadNumericUpDown);
            this.Controls.Add(this.ClienteComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FDetalleDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FactIdNumericUpDown);
            this.Name = "FacturaDetalleForm";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FacturaDetalleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ObservacionesTextBox;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.ComboBox PeliculaComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown CantidadNumericUpDown;
        private System.Windows.Forms.ComboBox ClienteComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView FDetalleDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FactIdNumericUpDown;
    }
}