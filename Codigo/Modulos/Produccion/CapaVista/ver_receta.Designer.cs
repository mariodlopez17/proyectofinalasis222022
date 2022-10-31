
namespace CapaVistaProduccion
{
    partial class ver_receta
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
            this.textBoxidreceta = new System.Windows.Forms.TextBox();
            this.textBoxproducto = new System.Windows.Forms.TextBox();
            this.textBoxmaterial = new System.Windows.Forms.TextBox();
            this.textBoxcantidad = new System.Windows.Forms.TextBox();
            this.textBoxmedida = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxidreceta
            // 
            this.textBoxidreceta.Location = new System.Drawing.Point(168, 252);
            this.textBoxidreceta.Name = "textBoxidreceta";
            this.textBoxidreceta.Size = new System.Drawing.Size(100, 26);
            this.textBoxidreceta.TabIndex = 0;
            this.textBoxidreceta.Tag = "pk_idrecetas_tbl_recetas";
            // 
            // textBoxproducto
            // 
            this.textBoxproducto.Location = new System.Drawing.Point(384, 253);
            this.textBoxproducto.Name = "textBoxproducto";
            this.textBoxproducto.Size = new System.Drawing.Size(100, 26);
            this.textBoxproducto.TabIndex = 1;
            this.textBoxproducto.Tag = "producto_tbl_recetas";
            // 
            // textBoxmaterial
            // 
            this.textBoxmaterial.Location = new System.Drawing.Point(605, 255);
            this.textBoxmaterial.Name = "textBoxmaterial";
            this.textBoxmaterial.Size = new System.Drawing.Size(100, 26);
            this.textBoxmaterial.TabIndex = 2;
            this.textBoxmaterial.Tag = "nombre_material_tbl_recetas";
            // 
            // textBoxcantidad
            // 
            this.textBoxcantidad.Location = new System.Drawing.Point(168, 299);
            this.textBoxcantidad.Name = "textBoxcantidad";
            this.textBoxcantidad.Size = new System.Drawing.Size(100, 26);
            this.textBoxcantidad.TabIndex = 3;
            this.textBoxcantidad.Tag = "cantidad_tbl_recetas";
            // 
            // textBoxmedida
            // 
            this.textBoxmedida.Location = new System.Drawing.Point(384, 302);
            this.textBoxmedida.Name = "textBoxmedida";
            this.textBoxmedida.Size = new System.Drawing.Size(100, 26);
            this.textBoxmedida.TabIndex = 4;
            this.textBoxmedida.Tag = "medida_tbl_recetas";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 337);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(859, 211);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Tag = "tbl_recetas";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(29, 14);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(859, 231);
            this.navegador1.TabIndex = 6;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero de receta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Medida";
            // 
            // ver_receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 560);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxmedida);
            this.Controls.Add(this.textBoxcantidad);
            this.Controls.Add(this.textBoxmaterial);
            this.Controls.Add(this.textBoxproducto);
            this.Controls.Add(this.textBoxidreceta);
            this.Name = "ver_receta";
            this.Text = "ver_receta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxidreceta;
        private System.Windows.Forms.TextBox textBoxproducto;
        private System.Windows.Forms.TextBox textBoxmaterial;
        private System.Windows.Forms.TextBox textBoxcantidad;
        private System.Windows.Forms.TextBox textBoxmedida;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
    }
}