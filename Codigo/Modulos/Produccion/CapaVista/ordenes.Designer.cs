
namespace CapaVistaProduccion
{
    partial class ordenes
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
            this.label8 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            this.num_orden = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fechainic = new System.Windows.Forms.TextBox();
            this.fechaent = new System.Windows.Forms.TextBox();
            this.prioridadtxt = new System.Windows.Forms.TextBox();
            this.fechacrea = new System.Windows.Forms.TextBox();
            this.detalle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(247, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Realizar Orden";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(209, 63);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(253, 78);
            this.navegador1.TabIndex = 88;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load_2);
            // 
            // num_orden
            // 
            this.num_orden.Location = new System.Drawing.Point(182, 168);
            this.num_orden.Name = "num_orden";
            this.num_orden.Size = new System.Drawing.Size(100, 20);
            this.num_orden.TabIndex = 87;
            this.num_orden.Tag = "pk_idordenes_tbl_ordenes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label10.Location = new System.Drawing.Point(41, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 86;
            this.label10.Text = "Numero de orden";
            // 
            // fechainic
            // 
            this.fechainic.Location = new System.Drawing.Point(938, 256);
            this.fechainic.Name = "fechainic";
            this.fechainic.Size = new System.Drawing.Size(115, 20);
            this.fechainic.TabIndex = 85;
            this.fechainic.Tag = "fechaini_tbl_ordenes";
            // 
            // fechaent
            // 
            this.fechaent.Location = new System.Drawing.Point(935, 300);
            this.fechaent.Name = "fechaent";
            this.fechaent.Size = new System.Drawing.Size(118, 20);
            this.fechaent.TabIndex = 84;
            this.fechaent.Tag = "fechaentrega_tbl_ordenes";
            // 
            // prioridadtxt
            // 
            this.prioridadtxt.Location = new System.Drawing.Point(953, 220);
            this.prioridadtxt.Name = "prioridadtxt";
            this.prioridadtxt.Size = new System.Drawing.Size(100, 20);
            this.prioridadtxt.TabIndex = 83;
            this.prioridadtxt.Tag = "prioridad_tbl_ordenes";
            // 
            // fechacrea
            // 
            this.fechacrea.Location = new System.Drawing.Point(908, 185);
            this.fechacrea.Name = "fechacrea";
            this.fechacrea.Size = new System.Drawing.Size(145, 20);
            this.fechacrea.TabIndex = 82;
            this.fechacrea.Tag = "fechacreacion_orden_tbl_ordenes";
            // 
            // detalle
            // 
            this.detalle.Location = new System.Drawing.Point(151, 339);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(482, 20);
            this.detalle.TabIndex = 81;
            this.detalle.Tag = "detalle_tbl_ordenes";
            this.detalle.TextChanged += new System.EventHandler(this.detalle_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label9.Location = new System.Drawing.Point(36, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 80;
            this.label9.Text = "Detalle Orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label1.Location = new System.Drawing.Point(672, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 79;
            this.label1.Text = "Fecha de creacion de la orden";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 286);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 78;
            this.textBox4.Tag = "cantidad_tbl_ordenes";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // prod_fabricar
            // 
            this.prod_fabricar.Location = new System.Drawing.Point(171, 239);
            this.prod_fabricar.Name = "prod_fabricar";
            this.prod_fabricar.Size = new System.Drawing.Size(100, 20);
            this.prod_fabricar.TabIndex = 77;
            this.prod_fabricar.Tag = "producto_fabricar_tbl_ordenes";
            this.prod_fabricar.TextChanged += new System.EventHandler(this.prod_fabricar_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label7.Location = new System.Drawing.Point(711, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 17);
            this.label7.TabIndex = 76;
            this.label7.Text = "Fecha de entrega de la orden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label6.Location = new System.Drawing.Point(722, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "Fecha de inicio de la orden";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label5.Location = new System.Drawing.Point(60, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 74;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label4.Location = new System.Drawing.Point(14, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "Producto a fabricar";
            // 
            // num_receta
            // 
            this.num_receta.Location = new System.Drawing.Point(182, 206);
            this.num_receta.Name = "num_receta";
            this.num_receta.Size = new System.Drawing.Size(100, 20);
            this.num_receta.TabIndex = 72;
            this.num_receta.Tag = "fk_idrecetas_tbl_recetas";
            this.num_receta.TextChanged += new System.EventHandler(this.num_receta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label3.Location = new System.Drawing.Point(871, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Prioridad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label2.Location = new System.Drawing.Point(36, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Numero de receta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(564, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(105, 45);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.Tag = "tbl_ordenes";
            this.dataGridView1.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(524, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker1.TabIndex = 89;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label11.Location = new System.Drawing.Point(288, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(230, 17);
            this.label11.TabIndex = 90;
            this.label11.Text = "Fecha de creacion de la orden";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label12.Location = new System.Drawing.Point(288, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 91;
            this.label12.Text = "Prioridad";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Normal",
            "Urgente"});
            this.comboBox1.Location = new System.Drawing.Point(370, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 92;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label13.Location = new System.Drawing.Point(314, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 17);
            this.label13.TabIndex = 93;
            this.label13.Text = "Fecha de inicio de la orden";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(524, 242);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker2.TabIndex = 94;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label14.Location = new System.Drawing.Point(296, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(222, 17);
            this.label14.TabIndex = 95;
            this.label14.Text = "Fecha de entrega de la orden";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(524, 283);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(132, 20);
            this.dateTimePicker3.TabIndex = 96;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(296, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(77, 74);
            this.panel1.TabIndex = 97;
            // 
            // ordenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(138)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(669, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
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
            this.Controls.Add(this.label8);
            this.Name = "ordenes";
            this.Text = "ordenes";
            this.Load += new System.EventHandler(this.ordenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox num_orden;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fechainic;
        private System.Windows.Forms.TextBox fechaent;
        private System.Windows.Forms.TextBox prioridadtxt;
        private System.Windows.Forms.TextBox fechacrea;
        private System.Windows.Forms.TextBox detalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Panel panel1;
    }
}