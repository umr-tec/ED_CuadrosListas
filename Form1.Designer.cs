
namespace ED_Ejemplo4_Cuadros
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dibujarPanel1 = new ED_Ejemplo4_Cuadros.DibujarPanel();
            this.dibujarPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(176, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Aplicar DoubleBuffered";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dibujarPanel1
            // 
            this.dibujarPanel1.Controls.Add(this.checkBox1);
            this.dibujarPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dibujarPanel1.DoubleBuffered = false;
            this.dibujarPanel1.Location = new System.Drawing.Point(0, 0);
            this.dibujarPanel1.Name = "dibujarPanel1";
            this.dibujarPanel1.Size = new System.Drawing.Size(733, 686);
            this.dibujarPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 686);
            this.Controls.Add(this.dibujarPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cuadros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dibujarPanel1.ResumeLayout(false);
            this.dibujarPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DibujarPanel dibujarPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

