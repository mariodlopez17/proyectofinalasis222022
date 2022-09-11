
namespace Capa_Vista
{
    partial class Busqueda_Avanzada
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.cbo_buscaren = new System.Windows.Forms.ComboBox();
            this.btn_cancelarBA = new FontAwesome.Sharp.IconButton();
            this.btn_buscarBA = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.btn_buscarBA);
            this.panel1.Controls.Add(this.cbo_buscaren);
            this.panel1.Controls.Add(this.btn_cancelarBA);
            this.panel1.Controls.Add(this.txt_buscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 230);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar En:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(148, 41);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(212, 20);
            this.txt_buscar.TabIndex = 2;
            // 
            // cbo_buscaren
            // 
            this.cbo_buscaren.FormattingEnabled = true;
            this.cbo_buscaren.Location = new System.Drawing.Point(148, 83);
            this.cbo_buscaren.Name = "cbo_buscaren";
            this.cbo_buscaren.Size = new System.Drawing.Size(212, 21);
            this.cbo_buscaren.TabIndex = 3;
            // 
            // btn_cancelarBA
            // 
            this.btn_cancelarBA.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btn_cancelarBA.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btn_cancelarBA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_cancelarBA.IconSize = 60;
            this.btn_cancelarBA.Location = new System.Drawing.Point(387, 149);
            this.btn_cancelarBA.Name = "btn_cancelarBA";
            this.btn_cancelarBA.Size = new System.Drawing.Size(64, 68);
            this.btn_cancelarBA.TabIndex = 23;
            this.btn_cancelarBA.Text = "Cancelar";
            this.btn_cancelarBA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelarBA.UseVisualStyleBackColor = true;
            // 
            // btn_buscarBA
            // 
            this.btn_buscarBA.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_buscarBA.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btn_buscarBA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_buscarBA.IconSize = 60;
            this.btn_buscarBA.Location = new System.Drawing.Point(317, 149);
            this.btn_buscarBA.Name = "btn_buscarBA";
            this.btn_buscarBA.Size = new System.Drawing.Size(64, 68);
            this.btn_buscarBA.TabIndex = 24;
            this.btn_buscarBA.Text = "Buscar";
            this.btn_buscarBA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscarBA.UseVisualStyleBackColor = true;
            // 
            // Busqueda_Avanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(487, 262);
            this.Controls.Add(this.panel1);
            this.Name = "Busqueda_Avanzada";
            this.Text = "Busqueda_Avanzada";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_buscaren;
        private System.Windows.Forms.TextBox txt_buscar;
        private FontAwesome.Sharp.IconButton btn_cancelarBA;
        private FontAwesome.Sharp.IconButton btn_buscarBA;
    }
}