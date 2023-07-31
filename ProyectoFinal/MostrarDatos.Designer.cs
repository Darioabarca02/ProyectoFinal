
namespace ProyectoFinal
{
    partial class MostrarDatos
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
            this.dgvDatosAlmacenados = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAlmacenados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosAlmacenados
            // 
            this.dgvDatosAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosAlmacenados.Location = new System.Drawing.Point(7, 129);
            this.dgvDatosAlmacenados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDatosAlmacenados.Name = "dgvDatosAlmacenados";
            this.dgvDatosAlmacenados.RowHeadersWidth = 51;
            this.dgvDatosAlmacenados.RowTemplate.Height = 24;
            this.dgvDatosAlmacenados.Size = new System.Drawing.Size(582, 226);
            this.dgvDatosAlmacenados.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(226, 35);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(130, 57);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Datos";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // MostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgvDatosAlmacenados);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MostrarDatos";
            this.Text = "MostrarDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosAlmacenados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosAlmacenados;
        private System.Windows.Forms.Button btnMostrar;
    }
}