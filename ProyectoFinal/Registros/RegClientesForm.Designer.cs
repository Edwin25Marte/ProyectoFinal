namespace ProyectoFinal
{
    partial class RegClientesForm
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
            this.ClienteIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ApellidosTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CelularTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ClienteIdNumericUpDown
            // 
            this.ClienteIdNumericUpDown.Location = new System.Drawing.Point(110, 29);
            this.ClienteIdNumericUpDown.Name = "ClienteIdNumericUpDown";
            this.ClienteIdNumericUpDown.Size = new System.Drawing.Size(119, 20);
            this.ClienteIdNumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente ID";
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(110, 76);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(200, 20);
            this.NombresTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(235, 26);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 4;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(110, 302);
            this.DireccionTextBox.Multiline = true;
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(200, 56);
            this.DireccionTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nacimiento";
            // 
            // NacimientoDateTimePicker
            // 
            this.NacimientoDateTimePicker.Location = new System.Drawing.Point(110, 151);
            this.NacimientoDateTimePicker.Name = "NacimientoDateTimePicker";
            this.NacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.NacimientoDateTimePicker.TabIndex = 8;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(45, 390);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 9;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(139, 390);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(235, 390);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 11;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Apellidos";
            // 
            // ApellidosTextBox
            // 
            this.ApellidosTextBox.Location = new System.Drawing.Point(110, 112);
            this.ApellidosTextBox.Name = "ApellidosTextBox";
            this.ApellidosTextBox.Size = new System.Drawing.Size(200, 20);
            this.ApellidosTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Celular";
            // 
            // CelularTextBox
            // 
            this.CelularTextBox.Location = new System.Drawing.Point(110, 222);
            this.CelularTextBox.Name = "CelularTextBox";
            this.CelularTextBox.Size = new System.Drawing.Size(200, 20);
            this.CelularTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefono";
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(110, 186);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.TelefonoTextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(110, 259);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(200, 20);
            this.EmailTextBox.TabIndex = 18;
            // 
            // RegClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 433);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CelularTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ApellidosTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.NacimientoDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClienteIdNumericUpDown);
            this.Name = "RegClientesForm";
            this.Text = "Registro de clientes";
            this.Load += new System.EventHandler(this.RegClientesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteIdNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ClienteIdNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker NacimientoDateTimePicker;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ApellidosTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CelularTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EmailTextBox;
    }
}

