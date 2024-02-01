namespace Ejercicio_01
{
    partial class Form1
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.txbnombre = new System.Windows.Forms.TextBox();
            this.txbsalario = new System.Windows.Forms.TextBox();
            this.txbdescuento = new System.Windows.Forms.TextBox();
            this.txbneto = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.Label();
            this.txtdescuento = new System.Windows.Forms.Label();
            this.txtneto = new System.Windows.Forms.Label();
            this.rbtgerente = new System.Windows.Forms.RadioButton();
            this.rbtsubgerente = new System.Windows.Forms.RadioButton();
            this.rbtsecretaria = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(313, 200);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txbnombre
            // 
            this.txbnombre.Location = new System.Drawing.Point(99, 88);
            this.txbnombre.Name = "txbnombre";
            this.txbnombre.Size = new System.Drawing.Size(100, 20);
            this.txbnombre.TabIndex = 1;
            // 
            // txbsalario
            // 
            this.txbsalario.Location = new System.Drawing.Point(108, 155);
            this.txbsalario.Name = "txbsalario";
            this.txbsalario.Size = new System.Drawing.Size(100, 20);
            this.txbsalario.TabIndex = 2;
            // 
            // txbdescuento
            // 
            this.txbdescuento.Location = new System.Drawing.Point(108, 204);
            this.txbdescuento.Name = "txbdescuento";
            this.txbdescuento.ReadOnly = true;
            this.txbdescuento.Size = new System.Drawing.Size(100, 20);
            this.txbdescuento.TabIndex = 3;
            // 
            // txbneto
            // 
            this.txbneto.Location = new System.Drawing.Point(108, 255);
            this.txbneto.Name = "txbneto";
            this.txbneto.ReadOnly = true;
            this.txbneto.Size = new System.Drawing.Size(100, 20);
            this.txbneto.TabIndex = 4;
            // 
            // txtsalario
            // 
            this.txtsalario.AutoSize = true;
            this.txtsalario.Location = new System.Drawing.Point(14, 161);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(67, 13);
            this.txtsalario.TabIndex = 5;
            this.txtsalario.Text = "Salario Bruto";
            // 
            // txtdescuento
            // 
            this.txtdescuento.AutoSize = true;
            this.txtdescuento.Location = new System.Drawing.Point(17, 210);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(90, 13);
            this.txtdescuento.TabIndex = 6;
            this.txtdescuento.Text = "Monto descuento";
            // 
            // txtneto
            // 
            this.txtneto.AutoSize = true;
            this.txtneto.Location = new System.Drawing.Point(20, 261);
            this.txtneto.Name = "txtneto";
            this.txtneto.Size = new System.Drawing.Size(65, 13);
            this.txtneto.TabIndex = 7;
            this.txtneto.Text = "Salario Neto";
            // 
            // rbtgerente
            // 
            this.rbtgerente.AutoSize = true;
            this.rbtgerente.Location = new System.Drawing.Point(227, 167);
            this.rbtgerente.Name = "rbtgerente";
            this.rbtgerente.Size = new System.Drawing.Size(63, 17);
            this.rbtgerente.TabIndex = 8;
            this.rbtgerente.TabStop = true;
            this.rbtgerente.Text = "Gerente";
            this.rbtgerente.UseVisualStyleBackColor = true;
            // 
            // rbtsubgerente
            // 
            this.rbtsubgerente.AutoSize = true;
            this.rbtsubgerente.Location = new System.Drawing.Point(227, 204);
            this.rbtsubgerente.Name = "rbtsubgerente";
            this.rbtsubgerente.Size = new System.Drawing.Size(80, 17);
            this.rbtsubgerente.TabIndex = 9;
            this.rbtsubgerente.TabStop = true;
            this.rbtsubgerente.Text = "Subgerente";
            this.rbtsubgerente.UseVisualStyleBackColor = true;
            // 
            // rbtsecretaria
            // 
            this.rbtsecretaria.AutoSize = true;
            this.rbtsecretaria.Location = new System.Drawing.Point(227, 245);
            this.rbtsecretaria.Name = "rbtsecretaria";
            this.rbtsecretaria.Size = new System.Drawing.Size(73, 17);
            this.rbtsecretaria.TabIndex = 10;
            this.rbtsecretaria.TabStop = true;
            this.rbtsecretaria.Text = "Secretaria";
            this.rbtsecretaria.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(263, 88);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // txtnombre
            // 
            this.txtnombre.AutoSize = true;
            this.txtnombre.Location = new System.Drawing.Point(21, 88);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(42, 13);
            this.txtnombre.TabIndex = 12;
            this.txtnombre.Text = "nombre";
            // 
            // txtapellido
            // 
            this.txtapellido.AutoSize = true;
            this.txtapellido.Location = new System.Drawing.Point(214, 88);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(43, 13);
            this.txtapellido.TabIndex = 13;
            this.txtapellido.Text = "apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "DESCUENTOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 366);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.rbtsecretaria);
            this.Controls.Add(this.rbtsubgerente);
            this.Controls.Add(this.rbtgerente);
            this.Controls.Add(this.txtneto);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.txbneto);
            this.Controls.Add(this.txbdescuento);
            this.Controls.Add(this.txbsalario);
            this.Controls.Add(this.txbnombre);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txbnombre;
        private System.Windows.Forms.TextBox txbsalario;
        private System.Windows.Forms.TextBox txbdescuento;
        private System.Windows.Forms.TextBox txbneto;
        private System.Windows.Forms.Label txtsalario;
        private System.Windows.Forms.Label txtdescuento;
        private System.Windows.Forms.Label txtneto;
        private System.Windows.Forms.RadioButton rbtgerente;
        private System.Windows.Forms.RadioButton rbtsubgerente;
        private System.Windows.Forms.RadioButton rbtsecretaria;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label txtnombre;
        private System.Windows.Forms.Label txtapellido;
        private System.Windows.Forms.Label label6;
    }
}

