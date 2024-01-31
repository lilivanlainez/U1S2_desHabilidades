namespace calDescuentos
{
    partial class showDescuento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dobleSalario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btGerente = new System.Windows.Forms.RadioButton();
            this.btSubGerente = new System.Windows.Forms.RadioButton();
            this.btSecretaria = new System.Windows.Forms.RadioButton();
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESCUENTOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(303, 98);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salario Bruto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dobleSalario
            // 
            this.dobleSalario.Location = new System.Drawing.Point(118, 178);
            this.dobleSalario.Name = "dobleSalario";
            this.dobleSalario.Size = new System.Drawing.Size(100, 20);
            this.dobleSalario.TabIndex = 6;
            this.dobleSalario.TextChanged += new System.EventHandler(this.dobleSalario_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Monto descuento:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Salario Neto:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 275);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btGerente
            // 
            this.btGerente.AutoSize = true;
            this.btGerente.Location = new System.Drawing.Point(250, 175);
            this.btGerente.Name = "btGerente";
            this.btGerente.Size = new System.Drawing.Size(63, 17);
            this.btGerente.TabIndex = 11;
            this.btGerente.TabStop = true;
            this.btGerente.Text = "Gerente";
            this.btGerente.UseVisualStyleBackColor = true;
            this.btGerente.CheckedChanged += new System.EventHandler(this.btGerente_CheckedChanged);
            // 
            // btSubGerente
            // 
            this.btSubGerente.AutoSize = true;
            this.btSubGerente.Location = new System.Drawing.Point(250, 199);
            this.btSubGerente.Name = "btSubGerente";
            this.btSubGerente.Size = new System.Drawing.Size(85, 17);
            this.btSubGerente.TabIndex = 12;
            this.btSubGerente.TabStop = true;
            this.btSubGerente.Text = "Sub Gerente";
            this.btSubGerente.UseVisualStyleBackColor = true;
            this.btSubGerente.CheckedChanged += new System.EventHandler(this.btSubGerente_CheckedChanged);
            // 
            // btSecretaria
            // 
            this.btSecretaria.AutoSize = true;
            this.btSecretaria.Location = new System.Drawing.Point(250, 223);
            this.btSecretaria.Name = "btSecretaria";
            this.btSecretaria.Size = new System.Drawing.Size(73, 17);
            this.btSecretaria.TabIndex = 13;
            this.btSecretaria.TabStop = true;
            this.btSecretaria.Text = "Secretaria";
            this.btSecretaria.UseVisualStyleBackColor = true;
            this.btSecretaria.CheckedChanged += new System.EventHandler(this.btSecretaria_CheckedChanged);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(284, 275);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 14;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // showDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 394);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.btSecretaria);
            this.Controls.Add(this.btSubGerente);
            this.Controls.Add(this.btGerente);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dobleSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "showDescuento";
            this.Text = "Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dobleSalario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton btGerente;
        private System.Windows.Forms.RadioButton btSubGerente;
        private System.Windows.Forms.RadioButton btSecretaria;
        private System.Windows.Forms.Button btCalcular;
    }
}

