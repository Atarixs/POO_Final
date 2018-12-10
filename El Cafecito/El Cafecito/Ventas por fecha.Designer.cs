namespace El_Cafecito
{
    partial class Ventas_por_fecha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas_por_fecha));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listVentas = new System.Windows.Forms.ListBox();
            this.gbCriterio = new System.Windows.Forms.GroupBox();
            this.cmbPagofiltro = new System.Windows.Forms.ComboBox();
            this.chkPago = new System.Windows.Forms.CheckBox();
            this.cmbVendedorfiltro = new System.Windows.Forms.ComboBox();
            this.chkVendedor = new System.Windows.Forms.CheckBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.dtPick = new System.Windows.Forms.DateTimePicker();
            this.gbCriterio.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(534, 342);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(76, 26);
            this.textBox2.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(534, 301);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(76, 26);
            this.textBox1.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "del Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Ingreso Generado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ventas totales ";
            // 
            // listVentas
            // 
            this.listVentas.FormattingEnabled = true;
            this.listVentas.Location = new System.Drawing.Point(44, 151);
            this.listVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listVentas.Name = "listVentas";
            this.listVentas.Size = new System.Drawing.Size(351, 212);
            this.listVentas.TabIndex = 23;
            // 
            // gbCriterio
            // 
            this.gbCriterio.Controls.Add(this.cmbPagofiltro);
            this.gbCriterio.Controls.Add(this.chkPago);
            this.gbCriterio.Controls.Add(this.cmbVendedorfiltro);
            this.gbCriterio.Controls.Add(this.chkVendedor);
            this.gbCriterio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCriterio.Location = new System.Drawing.Point(406, 40);
            this.gbCriterio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCriterio.Name = "gbCriterio";
            this.gbCriterio.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCriterio.Size = new System.Drawing.Size(194, 224);
            this.gbCriterio.TabIndex = 19;
            this.gbCriterio.TabStop = false;
            this.gbCriterio.Text = "Filtrar por:";
            // 
            // cmbPagofiltro
            // 
            this.cmbPagofiltro.FormattingEnabled = true;
            this.cmbPagofiltro.Location = new System.Drawing.Point(28, 186);
            this.cmbPagofiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPagofiltro.Name = "cmbPagofiltro";
            this.cmbPagofiltro.Size = new System.Drawing.Size(153, 25);
            this.cmbPagofiltro.TabIndex = 4;
            // 
            // chkPago
            // 
            this.chkPago.AutoSize = true;
            this.chkPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPago.Location = new System.Drawing.Point(28, 154);
            this.chkPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPago.Name = "chkPago";
            this.chkPago.Size = new System.Drawing.Size(135, 22);
            this.chkPago.TabIndex = 3;
            this.chkPago.Text = "Método de pago";
            this.chkPago.UseVisualStyleBackColor = true;
            // 
            // cmbVendedorfiltro
            // 
            this.cmbVendedorfiltro.FormattingEnabled = true;
            this.cmbVendedorfiltro.Location = new System.Drawing.Point(28, 92);
            this.cmbVendedorfiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVendedorfiltro.Name = "cmbVendedorfiltro";
            this.cmbVendedorfiltro.Size = new System.Drawing.Size(153, 25);
            this.cmbVendedorfiltro.TabIndex = 2;
            // 
            // chkVendedor
            // 
            this.chkVendedor.AutoSize = true;
            this.chkVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVendedor.Location = new System.Drawing.Point(28, 59);
            this.chkVendedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkVendedor.Name = "chkVendedor";
            this.chkVendedor.Size = new System.Drawing.Size(90, 22);
            this.chkVendedor.TabIndex = 1;
            this.chkVendedor.Text = "Vendedor";
            this.chkVendedor.UseVisualStyleBackColor = true;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(44, 40);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(196, 21);
            this.cmbFilter.TabIndex = 29;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // dtPick
            // 
            this.dtPick.CustomFormat = "dd-MM-yy";
            this.dtPick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPick.Location = new System.Drawing.Point(330, 41);
            this.dtPick.Name = "dtPick";
            this.dtPick.Size = new System.Drawing.Size(65, 20);
            this.dtPick.TabIndex = 30;
            this.dtPick.Value = new System.DateTime(2018, 12, 10, 2, 39, 53, 0);
            this.dtPick.ValueChanged += new System.EventHandler(this.dtPick_ValueChanged);
            // 
            // Ventas_por_fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 407);
            this.Controls.Add(this.dtPick);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listVentas);
            this.Controls.Add(this.gbCriterio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ventas_por_fecha";
            this.Text = "Ventas_por_fecha";
            this.gbCriterio.ResumeLayout(false);
            this.gbCriterio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listVentas;
        private System.Windows.Forms.GroupBox gbCriterio;
        private System.Windows.Forms.ComboBox cmbPagofiltro;
        private System.Windows.Forms.CheckBox chkPago;
        private System.Windows.Forms.ComboBox cmbVendedorfiltro;
        private System.Windows.Forms.CheckBox chkVendedor;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.DateTimePicker dtPick;
    }
}