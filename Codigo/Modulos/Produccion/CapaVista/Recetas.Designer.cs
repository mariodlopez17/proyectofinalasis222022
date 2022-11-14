
namespace CapaVistaProduccion
{
    partial class Recetas
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
            this.navegador1 = new NavegadorVista.Navegador();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxmedida = new System.Windows.Forms.TextBox();
            this.textBoxcantidad = new System.Windows.Forms.TextBox();
            this.textBoxmaterial = new System.Windows.Forms.TextBox();
            this.textBoxproducto = new System.Windows.Forms.TextBox();
            this.textBoxidreceta = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(138, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(247, 75);
            this.navegador1.TabIndex = 52;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label3.Location = new System.Drawing.Point(240, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Medida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label5.Location = new System.Drawing.Point(79, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label4.Location = new System.Drawing.Point(406, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label2.Location = new System.Drawing.Point(240, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "Numero de receta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(416, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(114, 70);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.Tag = "tbl_recetas";
            this.dataGridView1.Visible = false;
            // 
            // textBoxmedida
            // 
            this.textBoxmedida.Location = new System.Drawing.Point(320, 128);
            this.textBoxmedida.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxmedida.Name = "textBoxmedida";
            this.textBoxmedida.Size = new System.Drawing.Size(81, 20);
            this.textBoxmedida.TabIndex = 45;
            this.textBoxmedida.Tag = "medida_tbl_recetas";
            // 
            // textBoxcantidad
            // 
            this.textBoxcantidad.Location = new System.Drawing.Point(157, 128);
            this.textBoxcantidad.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxcantidad.Name = "textBoxcantidad";
            this.textBoxcantidad.Size = new System.Drawing.Size(68, 20);
            this.textBoxcantidad.TabIndex = 44;
            this.textBoxcantidad.Tag = "cantidad_tbl_recetas";
            // 
            // textBoxmaterial
            // 
            this.textBoxmaterial.Location = new System.Drawing.Point(478, 104);
            this.textBoxmaterial.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxmaterial.Name = "textBoxmaterial";
            this.textBoxmaterial.Size = new System.Drawing.Size(68, 20);
            this.textBoxmaterial.TabIndex = 43;
            this.textBoxmaterial.Tag = "nombre_material_tbl_recetas";
            // 
            // textBoxproducto
            // 
            this.textBoxproducto.Location = new System.Drawing.Point(320, 104);
            this.textBoxproducto.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxproducto.Name = "textBoxproducto";
            this.textBoxproducto.Size = new System.Drawing.Size(81, 20);
            this.textBoxproducto.TabIndex = 42;
            this.textBoxproducto.Tag = "producto_tbl_recetas";
            // 
            // textBoxidreceta
            // 
            this.textBoxidreceta.Location = new System.Drawing.Point(157, 101);
            this.textBoxidreceta.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxidreceta.Name = "textBoxidreceta";
            this.textBoxidreceta.Size = new System.Drawing.Size(68, 20);
            this.textBoxidreceta.TabIndex = 41;
            this.textBoxidreceta.Tag = "pk_idrecetas_tbl_recetas";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(224, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 71);
            this.panel1.TabIndex = 53;
            // 
            // Recetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(138)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(562, 172);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxmedida);
            this.Controls.Add(this.textBoxcantidad);
            this.Controls.Add(this.textBoxmaterial);
            this.Controls.Add(this.textBoxproducto);
            this.Controls.Add(this.textBoxidreceta);
            this.Name = "Recetas";
            this.Text = "Recetas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxmedida;
        private System.Windows.Forms.TextBox textBoxcantidad;
        private System.Windows.Forms.TextBox textBoxmaterial;
        private System.Windows.Forms.TextBox textBoxproducto;
        private System.Windows.Forms.TextBox textBoxidreceta;
        private System.Windows.Forms.Panel panel1;
    }
}