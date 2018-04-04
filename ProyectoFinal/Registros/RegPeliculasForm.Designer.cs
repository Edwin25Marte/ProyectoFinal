namespace ProyectoFinal.Registros
{
    partial class RegPeliculasForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.SipnosisTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PeliculaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.FechaSalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.PelDataGridView = new System.Windows.Forms.DataGridView();
            this.GenerosComboBox = new System.Windows.Forms.ComboBox();
            this.ActoresComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PeliculaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sipnosis";
            // 
            // SipnosisTextBox
            // 
            this.SipnosisTextBox.Location = new System.Drawing.Point(111, 148);
            this.SipnosisTextBox.Multiline = true;
            this.SipnosisTextBox.Name = "SipnosisTextBox";
            this.SipnosisTextBox.Size = new System.Drawing.Size(195, 59);
            this.SipnosisTextBox.TabIndex = 19;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(203, 27);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 18;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(111, 77);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(195, 20);
            this.NombreTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pelicula ID";
            // 
            // PeliculaIdNumericUpDown
            // 
            this.PeliculaIdNumericUpDown.Location = new System.Drawing.Point(111, 30);
            this.PeliculaIdNumericUpDown.Name = "PeliculaIdNumericUpDown";
            this.PeliculaIdNumericUpDown.Size = new System.Drawing.Size(77, 20);
            this.PeliculaIdNumericUpDown.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Precio";
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(380, 78);
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.PrecioNumericUpDown.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Fecha salida";
            // 
            // FechaSalDateTimePicker
            // 
            this.FechaSalDateTimePicker.Location = new System.Drawing.Point(111, 113);
            this.FechaSalDateTimePicker.Name = "FechaSalDateTimePicker";
            this.FechaSalDateTimePicker.Size = new System.Drawing.Size(195, 20);
            this.FechaSalDateTimePicker.TabIndex = 24;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(327, 358);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 27;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(231, 358);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 26;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(137, 358);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 25;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // PelDataGridView
            // 
            this.PelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PelDataGridView.Location = new System.Drawing.Point(111, 227);
            this.PelDataGridView.Name = "PelDataGridView";
            this.PelDataGridView.Size = new System.Drawing.Size(304, 100);
            this.PelDataGridView.TabIndex = 28;
            // 
            // GenerosComboBox
            // 
            this.GenerosComboBox.FormattingEnabled = true;
            this.GenerosComboBox.Location = new System.Drawing.Point(380, 116);
            this.GenerosComboBox.Name = "GenerosComboBox";
            this.GenerosComboBox.Size = new System.Drawing.Size(74, 21);
            this.GenerosComboBox.TabIndex = 29;
            // 
            // ActoresComboBox
            // 
            this.ActoresComboBox.FormattingEnabled = true;
            this.ActoresComboBox.Location = new System.Drawing.Point(380, 151);
            this.ActoresComboBox.Name = "ActoresComboBox";
            this.ActoresComboBox.Size = new System.Drawing.Size(74, 21);
            this.ActoresComboBox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Generos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Actores";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(330, 178);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(124, 29);
            this.AgregarButton.TabIndex = 33;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // RegPeliculasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 407);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ActoresComboBox);
            this.Controls.Add(this.GenerosComboBox);
            this.Controls.Add(this.PelDataGridView);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.FechaSalDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SipnosisTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeliculaIdNumericUpDown);
            this.Name = "RegPeliculasForm";
            this.Text = "Registro de peliculas";
            this.Load += new System.EventHandler(this.RegPeliculasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeliculaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SipnosisTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PeliculaIdNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker FechaSalDateTimePicker;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.DataGridView PelDataGridView;
        private System.Windows.Forms.ComboBox GenerosComboBox;
        private System.Windows.Forms.ComboBox ActoresComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AgregarButton;
    }
}