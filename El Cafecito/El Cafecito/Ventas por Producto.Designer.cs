namespace El_Cafecito
{
    partial class Ventas_por_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas_por_Producto));
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbIngreso = new System.Windows.Forms.RadioButton();
            this.rdbNoIngreso = new System.Windows.Forms.RadioButton();
            this.rdbNoVendido = new System.Windows.Forms.RadioButton();
            this.rdbVendido = new System.Windows.Forms.RadioButton();
            this.cmbVendidos = new System.Windows.Forms.ComboBox();
            this.cmbIngresogen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbProd
            // 
            this.cmbProd.Font = new System.Drawing.Font("Gotcha Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(30, 188);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(353, 43);
            this.cmbProd.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gotcha Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ingreso Generado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gotcha Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vendidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gotcha Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Producto:";
            // 
            // rdbIngreso
            // 
            this.rdbIngreso.AutoSize = true;
            this.rdbIngreso.Font = new System.Drawing.Font("Gotcha Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIngreso.Location = new System.Drawing.Point(228, 40);
            this.rdbIngreso.Name = "rdbIngreso";
            this.rdbIngreso.Size = new System.Drawing.Size(155, 35);
            this.rdbIngreso.TabIndex = 14;
            this.rdbIngreso.TabStop = true;
            this.rdbIngreso.Text = "Mayor Ingreso";
            this.rdbIngreso.UseVisualStyleBackColor = true;
            this.rdbIngreso.CheckedChanged += new System.EventHandler(this.rdbIngreso_CheckedChanged);
            // 
            // rdbNoIngreso
            // 
            this.rdbNoIngreso.AutoSize = true;
            this.rdbNoIngreso.Font = new System.Drawing.Font("Gotcha Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNoIngreso.Location = new System.Drawing.Point(228, 98);
            this.rdbNoIngreso.Name = "rdbNoIngreso";
            this.rdbNoIngreso.Size = new System.Drawing.Size(157, 35);
            this.rdbNoIngreso.TabIndex = 13;
            this.rdbNoIngreso.TabStop = true;
            this.rdbNoIngreso.Text = "Menor Ingreso";
            this.rdbNoIngreso.UseVisualStyleBackColor = true;
            this.rdbNoIngreso.CheckedChanged += new System.EventHandler(this.rdbNoIngreso_CheckedChanged);
            // 
            // rdbNoVendido
            // 
            this.rdbNoVendido.AutoSize = true;
            this.rdbNoVendido.Font = new System.Drawing.Font("Gotcha Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNoVendido.Location = new System.Drawing.Point(52, 98);
            this.rdbNoVendido.Name = "rdbNoVendido";
            this.rdbNoVendido.Size = new System.Drawing.Size(164, 35);
            this.rdbNoVendido.TabIndex = 12;
            this.rdbNoVendido.TabStop = true;
            this.rdbNoVendido.Text = "Menos Vendido";
            this.rdbNoVendido.UseVisualStyleBackColor = true;
            this.rdbNoVendido.CheckedChanged += new System.EventHandler(this.rdbNoVendido_CheckedChanged);
            // 
            // rdbVendido
            // 
            this.rdbVendido.AutoSize = true;
            this.rdbVendido.Font = new System.Drawing.Font("Gotcha Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVendido.Location = new System.Drawing.Point(52, 40);
            this.rdbVendido.Name = "rdbVendido";
            this.rdbVendido.Size = new System.Drawing.Size(143, 35);
            this.rdbVendido.TabIndex = 11;
            this.rdbVendido.TabStop = true;
            this.rdbVendido.Text = "Más Vendido";
            this.rdbVendido.UseVisualStyleBackColor = true;
            this.rdbVendido.CheckedChanged += new System.EventHandler(this.rdbVendido_CheckedChanged);
            // 
            // cmbVendidos
            // 
            this.cmbVendidos.Font = new System.Drawing.Font("Gotcha Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVendidos.FormattingEnabled = true;
            this.cmbVendidos.Location = new System.Drawing.Point(219, 263);
            this.cmbVendidos.Name = "cmbVendidos";
            this.cmbVendidos.Size = new System.Drawing.Size(116, 43);
            this.cmbVendidos.TabIndex = 23;
            // 
            // cmbIngresogen
            // 
            this.cmbIngresogen.Font = new System.Drawing.Font("Gotcha Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIngresogen.FormattingEnabled = true;
            this.cmbIngresogen.Location = new System.Drawing.Point(219, 334);
            this.cmbIngresogen.Name = "cmbIngresogen";
            this.cmbIngresogen.Size = new System.Drawing.Size(116, 43);
            this.cmbIngresogen.TabIndex = 24;
            // 
            // Ventas_por_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 413);
            this.Controls.Add(this.cmbIngresogen);
            this.Controls.Add(this.cmbVendidos);
            this.Controls.Add(this.cmbProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbIngreso);
            this.Controls.Add(this.rdbNoIngreso);
            this.Controls.Add(this.rdbNoVendido);
            this.Controls.Add(this.rdbVendido);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventas_por_Producto";
            this.Text = "Ventas_por_Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbIngreso;
        private System.Windows.Forms.RadioButton rdbNoIngreso;
        private System.Windows.Forms.RadioButton rdbNoVendido;
        private System.Windows.Forms.RadioButton rdbVendido;
        private System.Windows.Forms.ComboBox cmbVendidos;
        private System.Windows.Forms.ComboBox cmbIngresogen;
    }
}