namespace Ejercicio_04
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbCalculo1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCalculo4 = new System.Windows.Forms.TextBox();
            this.txbCalculo2 = new System.Windows.Forms.TextBox();
            this.txbCalculo3 = new System.Windows.Forms.TextBox();
            this.texto = new System.Windows.Forms.Label();
            this.listbArreglo = new System.Windows.Forms.ListBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbCalculo1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbCalculo4);
            this.groupBox1.Controls.Add(this.txbCalculo2);
            this.groupBox1.Controls.Add(this.txbCalculo3);
            this.groupBox1.Location = new System.Drawing.Point(183, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 249);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones con arreglo";
            // 
            // txbCalculo1
            // 
            this.txbCalculo1.Location = new System.Drawing.Point(181, 19);
            this.txbCalculo1.Name = "txbCalculo1";
            this.txbCalculo1.Size = new System.Drawing.Size(45, 20);
            this.txbCalculo1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mayor de los pares positivos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Número mayor de pares negativos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Promedio de impares positivos";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(62, 380);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Porcentaje de ceros en el arreglo";
            // 
            // txbCalculo4
            // 
            this.txbCalculo4.Location = new System.Drawing.Point(181, 200);
            this.txbCalculo4.Name = "txbCalculo4";
            this.txbCalculo4.Size = new System.Drawing.Size(45, 20);
            this.txbCalculo4.TabIndex = 9;
            // 
            // txbCalculo2
            // 
            this.txbCalculo2.Location = new System.Drawing.Point(180, 75);
            this.txbCalculo2.Name = "txbCalculo2";
            this.txbCalculo2.Size = new System.Drawing.Size(45, 20);
            this.txbCalculo2.TabIndex = 7;
            // 
            // txbCalculo3
            // 
            this.txbCalculo3.Location = new System.Drawing.Point(181, 140);
            this.txbCalculo3.Name = "txbCalculo3";
            this.txbCalculo3.Size = new System.Drawing.Size(45, 20);
            this.txbCalculo3.TabIndex = 8;
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(8, 44);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(129, 13);
            this.texto.TabIndex = 20;
            this.texto.Text = "Ingrese un valor al arreglo";
            // 
            // listbArreglo
            // 
            this.listbArreglo.FormattingEnabled = true;
            this.listbArreglo.Location = new System.Drawing.Point(35, 110);
            this.listbArreglo.Name = "listbArreglo";
            this.listbArreglo.Size = new System.Drawing.Size(120, 251);
            this.listbArreglo.TabIndex = 19;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(143, 39);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 20);
            this.txbNumero.TabIndex = 18;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(266, 39);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 17;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.listbArreglo);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btningresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbCalculo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCalculo4;
        private System.Windows.Forms.TextBox txbCalculo2;
        private System.Windows.Forms.TextBox txbCalculo3;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.ListBox listbArreglo;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Button btningresar;
    }
}

