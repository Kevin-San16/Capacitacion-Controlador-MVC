namespace CapaVista
{
    partial class Consulta
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
            this.Dgv_Registro = new System.Windows.Forms.DataGridView();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Registro)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Registro
            // 
            this.Dgv_Registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Registro.Location = new System.Drawing.Point(12, 171);
            this.Dgv_Registro.Name = "Dgv_Registro";
            this.Dgv_Registro.RowHeadersWidth = 51;
            this.Dgv_Registro.RowTemplate.Height = 24;
            this.Dgv_Registro.Size = new System.Drawing.Size(714, 248);
            this.Dgv_Registro.TabIndex = 0;
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Location = new System.Drawing.Point(555, 12);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(133, 112);
            this.Btn_Consultar.TabIndex = 1;
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.Dgv_Registro);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Registro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Registro;
        private System.Windows.Forms.Button Btn_Consultar;
    }
}