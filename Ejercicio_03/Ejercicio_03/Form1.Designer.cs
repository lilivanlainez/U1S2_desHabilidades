namespace Ejercicio_03
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
            this.btnconvertir = new System.Windows.Forms.Button();
            this.lbresultado = new System.Windows.Forms.Label();
            this.txbresultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtemperatura = new System.Windows.Forms.RadioButton();
            this.rblongitud = new System.Windows.Forms.RadioButton();
            this.rbpeso = new System.Windows.Forms.RadioButton();
            this.lblvalor = new System.Windows.Forms.Label();
            this.txbvalor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnconvertir
            // 
            this.btnconvertir.Location = new System.Drawing.Point(100, 201);
            this.btnconvertir.Name = "btnconvertir";
            this.btnconvertir.Size = new System.Drawing.Size(94, 23);
            this.btnconvertir.TabIndex = 0;
            this.btnconvertir.Text = "CONVERTIR";
            this.btnconvertir.UseVisualStyleBackColor = true;
            this.btnconvertir.Click += new System.EventHandler(this.btnconvertir_Click);
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(37, 165);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(55, 13);
            this.lbresultado.TabIndex = 1;
            this.lbresultado.Text = "Resultado";
            this.lbresultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbresultado
            // 
            this.txbresultado.Location = new System.Drawing.Point(100, 162);
            this.txbresultado.Name = "txbresultado";
            this.txbresultado.Size = new System.Drawing.Size(100, 20);
            this.txbresultado.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "SISTEMA DE CONVERSIONES";
            // 
            // rbtemperatura
            // 
            this.rbtemperatura.AutoSize = true;
            this.rbtemperatura.Location = new System.Drawing.Point(218, 102);
            this.rbtemperatura.Name = "rbtemperatura";
            this.rbtemperatura.Size = new System.Drawing.Size(81, 17);
            this.rbtemperatura.TabIndex = 8;
            this.rbtemperatura.TabStop = true;
            this.rbtemperatura.Text = "temperatura";
            this.rbtemperatura.UseVisualStyleBackColor = true;
            // 
            // rblongitud
            // 
            this.rblongitud.AutoSize = true;
            this.rblongitud.Location = new System.Drawing.Point(218, 128);
            this.rblongitud.Name = "rblongitud";
            this.rblongitud.Size = new System.Drawing.Size(62, 17);
            this.rblongitud.TabIndex = 9;
            this.rblongitud.TabStop = true;
            this.rblongitud.Text = "longitud";
            this.rblongitud.UseVisualStyleBackColor = true;
            // 
            // rbpeso
            // 
            this.rbpeso.AutoSize = true;
            this.rbpeso.Location = new System.Drawing.Point(218, 164);
            this.rbpeso.Name = "rbpeso";
            this.rbpeso.Size = new System.Drawing.Size(48, 17);
            this.rbpeso.TabIndex = 10;
            this.rbpeso.TabStop = true;
            this.rbpeso.Text = "peso";
            this.rbpeso.UseVisualStyleBackColor = true;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(9, 106);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(83, 13);
            this.lblvalor.TabIndex = 11;
            this.lblvalor.Text = "valor a convertir";
            // 
            // txbvalor
            // 
            this.txbvalor.Location = new System.Drawing.Point(100, 103);
            this.txbvalor.Name = "txbvalor";
            this.txbvalor.Size = new System.Drawing.Size(100, 20);
            this.txbvalor.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ingrese cantidades en (celcius, metros o kilogramos)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbvalor);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.rbpeso);
            this.Controls.Add(this.rblongitud);
            this.Controls.Add(this.rbtemperatura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbresultado);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.btnconvertir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconvertir;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.TextBox txbresultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtemperatura;
        private System.Windows.Forms.RadioButton rblongitud;
        private System.Windows.Forms.RadioButton rbpeso;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txbvalor;
        private System.Windows.Forms.Label label1;
    }
}

