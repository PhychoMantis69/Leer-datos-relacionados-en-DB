namespace Conexion_base
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
            this.PokemosList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PokemosList)).BeginInit();
            this.SuspendLayout();
            // 
            // PokemosList
            // 
            this.PokemosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PokemosList.Location = new System.Drawing.Point(34, 36);
            this.PokemosList.Name = "PokemosList";
            this.PokemosList.Size = new System.Drawing.Size(431, 205);
            this.PokemosList.TabIndex = 0;
            this.PokemosList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PokemosList_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 290);
            this.Controls.Add(this.PokemosList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PokemosList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PokemosList;
    }
}

