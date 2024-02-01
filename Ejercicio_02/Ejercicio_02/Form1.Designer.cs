namespace Ejercicio_02
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
            this.lbla = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lblx1 = new System.Windows.Forms.Label();
            this.lblx2 = new System.Windows.Forms.Label();
            this.txba = new System.Windows.Forms.TextBox();
            this.txbb = new System.Windows.Forms.TextBox();
            this.txbc = new System.Windows.Forms.TextBox();
            this.txbx1 = new System.Windows.Forms.TextBox();
            this.txbx2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(87, 263);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.Location = new System.Drawing.Point(68, 73);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(13, 13);
            this.lbla.TabIndex = 1;
            this.lbla.Text = "a";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.Location = new System.Drawing.Point(68, 99);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(13, 13);
            this.lblb.TabIndex = 2;
            this.lblb.Text = "b";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(68, 122);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(13, 13);
            this.lblc.TabIndex = 3;
            this.lblc.Text = "c";
            // 
            // lblx1
            // 
            this.lblx1.AutoSize = true;
            this.lblx1.Location = new System.Drawing.Point(35, 170);
            this.lblx1.Name = "lblx1";
            this.lblx1.Size = new System.Drawing.Size(18, 13);
            this.lblx1.TabIndex = 4;
            this.lblx1.Text = "x1";
            // 
            // lblx2
            // 
            this.lblx2.AutoSize = true;
            this.lblx2.Location = new System.Drawing.Point(35, 207);
            this.lblx2.Name = "lblx2";
            this.lblx2.Size = new System.Drawing.Size(18, 13);
            this.lblx2.TabIndex = 5;
            this.lblx2.Text = "x2";
            // 
            // txba
            // 
            this.txba.Location = new System.Drawing.Point(87, 70);
            this.txba.Name = "txba";
            this.txba.Size = new System.Drawing.Size(100, 20);
            this.txba.TabIndex = 6;
            // 
            // txbb
            // 
            this.txbb.Location = new System.Drawing.Point(87, 96);
            this.txbb.Name = "txbb";
            this.txbb.Size = new System.Drawing.Size(100, 20);
            this.txbb.TabIndex = 7;
            // 
            // txbc
            // 
            this.txbc.Location = new System.Drawing.Point(87, 122);
            this.txbc.Name = "txbc";
            this.txbc.Size = new System.Drawing.Size(100, 20);
            this.txbc.TabIndex = 8;
            // 
            // txbx1
            // 
            this.txbx1.Location = new System.Drawing.Point(87, 170);
            this.txbx1.Name = "txbx1";
            this.txbx1.Size = new System.Drawing.Size(100, 20);
            this.txbx1.TabIndex = 9;
            // 
            // txbx2
            // 
            this.txbx2.Location = new System.Drawing.Point(87, 207);
            this.txbx2.Name = "txbx2";
            this.txbx2.Size = new System.Drawing.Size(100, 20);
            this.txbx2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Formula cuadrática";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx2);
            this.Controls.Add(this.txbx1);
            this.Controls.Add(this.txbc);
            this.Controls.Add(this.txbb);
            this.Controls.Add(this.txba);
            this.Controls.Add(this.lblx2);
            this.Controls.Add(this.lblx1);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lblb);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lblx1;
        private System.Windows.Forms.Label lblx2;
        private System.Windows.Forms.TextBox txba;
        private System.Windows.Forms.TextBox txbb;
        private System.Windows.Forms.TextBox txbc;
        private System.Windows.Forms.TextBox txbx1;
        private System.Windows.Forms.TextBox txbx2;
        private System.Windows.Forms.Label label1;
    }
}

