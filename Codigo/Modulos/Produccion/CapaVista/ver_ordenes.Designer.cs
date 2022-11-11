
namespace CapaVistaProduccion
{
    partial class ver_ordenes
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
            this.num_orden = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fechainic = new System.Windows.Forms.TextBox();
            this.fechaent = new System.Windows.Forms.TextBox();
            this.prioridadtxt = new System.Windows.Forms.TextBox();
            this.fechacrea = new System.Windows.Forms.TextBox();
            this.detalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.prod_fabricar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_receta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // num_orden
            // 
            this.num_orden.Location = new System.Drawing.Point(219, 180);
            this.num_orden.Name = "num_orden";
            this.num_orden.Size = new System.Drawing.Size(100, 20);
            this.num_orden.TabIndex = 67;
            this.num_orden.Tag = "pk_idordenes_tbl_ordenes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label10.Location = new System.Drawing.Point(78, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "Numero de orden";
            // 
            // fechainic
            // 
            this.fechainic.Location = new System.Drawing.Point(555, 257);
            this.fechainic.Name = "fechainic";
            this.fechainic.Size = new System.Drawing.Size(115, 20);
            this.fechainic.TabIndex = 65;
            this.fechainic.Tag = "fechaini_tbl_ordenes";
            // 
            // fechaent
            // 
            this.fechaent.Location = new System.Drawing.Point(552, 301);
            this.fechaent.Name = "fechaent";
            this.fechaent.Size = new System.Drawing.Size(118, 20);
            this.fechaent.TabIndex = 64;
            this.fechaent.Tag = "fechaentrega_tbl_ordenes";
            // 
            // prioridadtxt
            // 
            this.prioridadtxt.Location = new System.Drawing.Point(430, 221);
            this.prioridadtxt.Name = "prioridadtxt";
            this.prioridadtxt.Size = new System.Drawing.Size(100, 20);
            this.prioridadtxt.TabIndex = 63;
            this.prioridadtxt.Tag = "prioridad_tbl_ordenes";
            // 
            // fechacrea
            // 
            this.fechacrea.Location = new System.Drawing.Point(564, 180);
            this.fechacrea.Name = "fechacrea";
            this.fechacrea.Size = new System.Drawing.Size(145, 20);
            this.fechacrea.TabIndex = 62;
            this.fechacrea.Tag = "fechacreacion_orden_tbl_ordenes";
            // 
            // detalle
            // 
            this.detalle.Location = new System.Drawing.Point(188, 351);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(482, 20);
            this.detalle.TabIndex = 61;
            this.detalle.Tag = "detalle_tbl_ordenes";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label9.Location = new System.Drawing.Point(73, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "Detalle Orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label1.Location = new System.Drawing.Point(328, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "Fecha de creacion de la orden";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, -19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Mantenimiento Ordenes";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 298);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 57;
            this.textBox4.Tag = "cantidad_tbl_ordenes";
            // 
            // prod_fabricar
            // 
            this.prod_fabricar.Location = new System.Drawing.Point(208, 251);
            this.prod_fabricar.Name = "prod_fabricar";
            this.prod_fabricar.Size = new System.Drawing.Size(100, 20);
            this.prod_fabricar.TabIndex = 56;
            this.prod_fabricar.Tag = "producto_fabricar_tbl_ordenes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label7.Location = new System.Drawing.Point(328, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "Fecha de entrega de la orden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label6.Location = new System.Drawing.Point(339, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Fecha de inicio de la orden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label5.Location = new System.Drawing.Point(97, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label4.Location = new System.Drawing.Point(51, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Producto a fabricar";
            // 
            // num_receta
            // 
            this.num_receta.Location = new System.Drawing.Point(219, 218);
            this.num_receta.Name = "num_receta";
            this.num_receta.Size = new System.Drawing.Size(100, 20);
            this.num_receta.TabIndex = 51;
            this.num_receta.Tag = "fk_idrecetas_tbl_recetas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label3.Location = new System.Drawing.Point(348, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Prioridad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label2.Location = new System.Drawing.Point(73, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Numero de receta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 399);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(785, 216);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.Tag = "tbl_ordenes";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(115, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(567, 152);
            this.navegador1.TabIndex = 68;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // ver_ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(138)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(810, 626);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.num_orden);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fechainic);
            this.Controls.Add(this.fechaent);
            this.Controls.Add(this.prioridadtxt);
            this.Controls.Add(this.fechacrea);
            this.Controls.Add(this.detalle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.prod_fabricar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_receta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ver_ordenes";
            this.Text = "ver_ordenes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num_orden;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fechainic;
        private System.Windows.Forms.TextBox fechaent;
        private System.Windows.Forms.TextBox prioridadtxt;
        private System.Windows.Forms.TextBox fechacrea;
        private System.Windows.Forms.TextBox detalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox prod_fabricar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox num_receta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private NavegadorVista.Navegador navegador1;
    }
}