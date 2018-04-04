namespace ProyectoFinal.Consultas
{
    partial class CFacturaForm
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
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CriterioBusquedaTextBox = new System.Windows.Forms.TextBox();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CFiltrarComboBox = new System.Windows.Forms.ComboBox();
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Location = new System.Drawing.Point(35, 292);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(75, 38);
            this.ImprimirButton.TabIndex = 98;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.UseVisualStyleBackColor = true;
            this.ImprimirButton.Click += new System.EventHandler(this.ImprimirButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Criterio de busqueda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 94;
            this.label5.Text = "Campo a filtrar";
            // 
            // CriterioBusquedaTextBox
            // 
            this.CriterioBusquedaTextBox.Location = new System.Drawing.Point(156, 34);
            this.CriterioBusquedaTextBox.Name = "CriterioBusquedaTextBox";
            this.CriterioBusquedaTextBox.Size = new System.Drawing.Size(152, 20);
            this.CriterioBusquedaTextBox.TabIndex = 93;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Location = new System.Drawing.Point(73, 87);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.HastaDateTimePicker.TabIndex = 92;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(73, 64);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DesdeDateTimePicker.TabIndex = 91;
            // 
            // CFiltrarComboBox
            // 
            this.CFiltrarComboBox.FormattingEnabled = true;
            this.CFiltrarComboBox.Items.AddRange(new object[] {
            "Id",
            "Observaciones",
            "Fecha"});
            this.CFiltrarComboBox.Location = new System.Drawing.Point(32, 34);
            this.CFiltrarComboBox.Name = "CFiltrarComboBox";
            this.CFiltrarComboBox.Size = new System.Drawing.Size(102, 21);
            this.CFiltrarComboBox.TabIndex = 90;
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(32, 125);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.Size = new System.Drawing.Size(359, 150);
            this.ConsultaDataGridView.TabIndex = 89;
            // 
            // FiltrarButton
            // 
            this.FiltrarButton.Location = new System.Drawing.Point(316, 31);
            this.FiltrarButton.Name = "FiltrarButton";
            this.FiltrarButton.Size = new System.Drawing.Size(75, 25);
            this.FiltrarButton.TabIndex = 88;
            this.FiltrarButton.Text = "Filtrar";
            this.FiltrarButton.UseVisualStyleBackColor = true;
            this.FiltrarButton.Click += new System.EventHandler(this.FiltrarButton_Click);
            // 
            // CFacturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 345);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CriterioBusquedaTextBox);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.CFiltrarComboBox);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Controls.Add(this.FiltrarButton);
            this.Name = "CFacturaForm";
            this.Text = "Consultar factura";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CriterioBusquedaTextBox;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.ComboBox CFiltrarComboBox;
        private System.Windows.Forms.DataGridView ConsultaDataGridView;
        private System.Windows.Forms.Button FiltrarButton;
    }
}