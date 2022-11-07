
namespace ComprasVista
{
    partial class Caja_Clientes
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
            this.Dgv_CajaClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CajaClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_CajaClientes
            // 
            this.Dgv_CajaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CajaClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Dgv_CajaClientes.Location = new System.Drawing.Point(0, 338);
            this.Dgv_CajaClientes.Name = "Dgv_CajaClientes";
            this.Dgv_CajaClientes.Size = new System.Drawing.Size(884, 223);
            this.Dgv_CajaClientes.TabIndex = 13;
            this.Dgv_CajaClientes.Tag = "tblcajaclientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.navegador1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 186);
            this.panel1.TabIndex = 12;
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(556, 273);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(257, 20);
            this.txtAbono.TabIndex = 50;
            this.txtAbono.Tag = "Abono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Abono";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(556, 216);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(257, 20);
            this.txtSaldo.TabIndex = 48;
            this.txtSaldo.Tag = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Saldo";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(146, 278);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(260, 20);
            this.txtIdCliente.TabIndex = 46;
            this.txtIdCliente.Tag = "FkId_Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Id_Cliente";
            // 
            // txtIdCaja
            // 
            this.txtIdCaja.Location = new System.Drawing.Point(146, 225);
            this.txtIdCaja.Name = "txtIdCaja";
            this.txtIdCaja.Size = new System.Drawing.Size(260, 20);
            this.txtIdCaja.TabIndex = 44;
            this.txtIdCaja.Tag = "PkId_CajaClientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Id_Caja";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(157, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // Caja_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdCaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_CajaClientes);
            this.Controls.Add(this.panel1);
            this.Name = "Caja_Clientes";
            this.Text = "Caja_Clientes";
            this.Load += new System.EventHandler(this.Caja_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CajaClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_CajaClientes;
        private System.Windows.Forms.Panel panel1;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCaja;
        private System.Windows.Forms.Label label1;
    }
}