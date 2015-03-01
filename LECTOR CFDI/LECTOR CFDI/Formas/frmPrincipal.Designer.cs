namespace LECTOR_CFDI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLeerCFDI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeerCFDI
            // 
            this.btnLeerCFDI.Location = new System.Drawing.Point(131, 255);
            this.btnLeerCFDI.Name = "btnLeerCFDI";
            this.btnLeerCFDI.Size = new System.Drawing.Size(161, 29);
            this.btnLeerCFDI.TabIndex = 0;
            this.btnLeerCFDI.Text = "Leer CFDI";
            this.btnLeerCFDI.UseVisualStyleBackColor = true;
            this.btnLeerCFDI.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 298);
            this.Controls.Add(this.btnLeerCFDI);
            this.Name = "Form1";
            this.Text = "LECTOR CFDI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeerCFDI;
    }
}

