
namespace CapaVistaNomina
{
    partial class PrestacionesDeducciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtvalorfijo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtporcentaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttipoprestaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombreprestaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDprestaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 246);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prestaciones Y Deducciones";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtestado);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtvalorfijo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtporcentaje);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txttipoprestaciones);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtnombreprestaciones);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtIDprestaciones);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(41, 254);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 428);
            this.panel2.TabIndex = 2;
            // 
            // txtestado
            // 
            this.txtestado.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtestado.Location = new System.Drawing.Point(171, 316);
            this.txtestado.Margin = new System.Windows.Forms.Padding(4);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(105, 26);
            this.txtestado.TabIndex = 18;
            this.txtestado.Tag = "estado_prestdeduc";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(85, 316);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 21);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label8.Location = new System.Drawing.Point(21, 316);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Estado";
            // 
            // txtvalorfijo
            // 
            this.txtvalorfijo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtvalorfijo.Location = new System.Drawing.Point(21, 266);
            this.txtvalorfijo.Margin = new System.Windows.Forms.Padding(4);
            this.txtvalorfijo.Name = "txtvalorfijo";
            this.txtvalorfijo.Size = new System.Drawing.Size(255, 26);
            this.txtvalorfijo.TabIndex = 12;
            this.txtvalorfijo.Tag = "valorFijo_prestdeduc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label6.Location = new System.Drawing.Point(21, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 7;
            this.label6.Tag = "";
            this.label6.Text = "Valor Fijo";
            // 
            // txtporcentaje
            // 
            this.txtporcentaje.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtporcentaje.Location = new System.Drawing.Point(21, 207);
            this.txtporcentaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtporcentaje.Name = "txtporcentaje";
            this.txtporcentaje.Size = new System.Drawing.Size(255, 26);
            this.txtporcentaje.TabIndex = 13;
            this.txtporcentaje.Tag = "porcentaje_prestdeduc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label5.Location = new System.Drawing.Point(21, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 8;
            this.label5.Tag = "";
            this.label5.Text = "Porcentaje";
            // 
            // txttipoprestaciones
            // 
            this.txttipoprestaciones.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txttipoprestaciones.Location = new System.Drawing.Point(21, 148);
            this.txttipoprestaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txttipoprestaciones.Name = "txttipoprestaciones";
            this.txttipoprestaciones.Size = new System.Drawing.Size(255, 26);
            this.txttipoprestaciones.TabIndex = 14;
            this.txttipoprestaciones.Tag = "tipo_prestdeduc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label4.Location = new System.Drawing.Point(21, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 19);
            this.label4.TabIndex = 9;
            this.label4.Tag = "";
            this.label4.Text = "Tipo Prestacion Y Dedu.";
            // 
            // txtnombreprestaciones
            // 
            this.txtnombreprestaciones.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtnombreprestaciones.Location = new System.Drawing.Point(21, 89);
            this.txtnombreprestaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombreprestaciones.Name = "txtnombreprestaciones";
            this.txtnombreprestaciones.Size = new System.Drawing.Size(255, 26);
            this.txtnombreprestaciones.TabIndex = 15;
            this.txtnombreprestaciones.Tag = "nombre_prestdeduc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre Prestacion Y Dedu.";
            // 
            // txtIDprestaciones
            // 
            this.txtIDprestaciones.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtIDprestaciones.Location = new System.Drawing.Point(21, 30);
            this.txtIDprestaciones.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDprestaciones.Name = "txtIDprestaciones";
            this.txtIDprestaciones.Size = new System.Drawing.Size(255, 26);
            this.txtIDprestaciones.TabIndex = 5;
            this.txtIDprestaciones.Tag = "pk_id_prestdeduc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(21, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Prestaciones Y Deducciones";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(619, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "tbl_prestacionesydeducciones";
            // 
            // PrestacionesDeducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PrestacionesDeducciones";
            this.Text = "PrestacionesDeducciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtvalorfijo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtporcentaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttipoprestaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombreprestaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDprestaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}