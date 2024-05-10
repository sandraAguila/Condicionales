namespace Condicionales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnElevar = new System.Windows.Forms.Button();
            this.btnCalcularInteres = new System.Windows.Forms.Button();
            this.btnClasificarCalificacion = new System.Windows.Forms.Button();
            this.btnCalculoY = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(137, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cálculos Secuenciales";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(166, 271);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 36);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnElevar
            // 
            this.btnElevar.Location = new System.Drawing.Point(265, 227);
            this.btnElevar.Name = "btnElevar";
            this.btnElevar.Size = new System.Drawing.Size(100, 36);
            this.btnElevar.TabIndex = 2;
            this.btnElevar.Text = "Elevar";
            this.btnElevar.UseVisualStyleBackColor = true;
            this.btnElevar.Click += new System.EventHandler(this.btnElevar_Click);
            // 
            // btnCalcularInteres
            // 
            this.btnCalcularInteres.Location = new System.Drawing.Point(49, 172);
            this.btnCalcularInteres.Name = "btnCalcularInteres";
            this.btnCalcularInteres.Size = new System.Drawing.Size(100, 36);
            this.btnCalcularInteres.TabIndex = 3;
            this.btnCalcularInteres.Text = "Cálcular interés";
            this.btnCalcularInteres.UseVisualStyleBackColor = true;
            this.btnCalcularInteres.Click += new System.EventHandler(this.btnCalcularInteres_Click);
            // 
            // btnClasificarCalificacion
            // 
            this.btnClasificarCalificacion.Location = new System.Drawing.Point(277, 172);
            this.btnClasificarCalificacion.Name = "btnClasificarCalificacion";
            this.btnClasificarCalificacion.Size = new System.Drawing.Size(100, 36);
            this.btnClasificarCalificacion.TabIndex = 4;
            this.btnClasificarCalificacion.Text = "Clasificar Calificación";
            this.btnClasificarCalificacion.UseVisualStyleBackColor = true;
            this.btnClasificarCalificacion.Click += new System.EventHandler(this.btnClasificarCalificacion_Click);
            // 
            // btnCalculoY
            // 
            this.btnCalculoY.Location = new System.Drawing.Point(49, 227);
            this.btnCalculoY.Name = "btnCalculoY";
            this.btnCalculoY.Size = new System.Drawing.Size(100, 30);
            this.btnCalculoY.TabIndex = 5;
            this.btnCalculoY.Text = "Cálcula Y";
            this.btnCalculoY.UseVisualStyleBackColor = true;
            this.btnCalculoY.Click += new System.EventHandler(this.btnCalculoY_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese el Valor :";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(149, 96);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(91, 20);
            this.txtValor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "El resultado es:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(146, 332);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(94, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculoY);
            this.Controls.Add(this.btnClasificarCalificacion);
            this.Controls.Add(this.btnCalcularInteres);
            this.Controls.Add(this.btnElevar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnElevar;
        private System.Windows.Forms.Button btnCalcularInteres;
        private System.Windows.Forms.Button btnClasificarCalificacion;
        private System.Windows.Forms.Button btnCalculoY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

