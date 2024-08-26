
namespace _06Publicaciones.Views.Trabajos
{
    partial class frm_trabajo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIdTrabajo = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxNMinimo = new System.Windows.Forms.TextBox();
            this.textBoxNMaximo = new System.Windows.Forms.TextBox();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.lst_Trabajos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID TRABAJO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIPCION DEL TRABAJO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIVEL MINIMO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "NIVEL MAXIMO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "GESTION DE TRABAJOS";
            // 
            // textBoxIdTrabajo
            // 
            this.textBoxIdTrabajo.Location = new System.Drawing.Point(289, 59);
            this.textBoxIdTrabajo.Name = "textBoxIdTrabajo";
            this.textBoxIdTrabajo.Size = new System.Drawing.Size(100, 26);
            this.textBoxIdTrabajo.TabIndex = 5;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(289, 107);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 26);
            this.textBoxDescripcion.TabIndex = 6;
            // 
            // textBoxNMinimo
            // 
            this.textBoxNMinimo.Location = new System.Drawing.Point(289, 160);
            this.textBoxNMinimo.Name = "textBoxNMinimo";
            this.textBoxNMinimo.Size = new System.Drawing.Size(100, 26);
            this.textBoxNMinimo.TabIndex = 7;
            // 
            // textBoxNMaximo
            // 
            this.textBoxNMaximo.Location = new System.Drawing.Point(289, 204);
            this.textBoxNMaximo.Name = "textBoxNMaximo";
            this.textBoxNMaximo.Size = new System.Drawing.Size(100, 26);
            this.textBoxNMaximo.TabIndex = 8;
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(138, 287);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(122, 79);
            this.btn_insertar.TabIndex = 9;
            this.btn_insertar.Text = "GUARDAR";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(375, 287);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(129, 79);
            this.btn_Limpiar.TabIndex = 10;
            this.btn_Limpiar.Text = "LIMPIAR";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // lst_Trabajos
            // 
            this.lst_Trabajos.FormattingEnabled = true;
            this.lst_Trabajos.ItemHeight = 20;
            this.lst_Trabajos.Location = new System.Drawing.Point(583, 77);
            this.lst_Trabajos.Name = "lst_Trabajos";
            this.lst_Trabajos.Size = new System.Drawing.Size(205, 264);
            this.lst_Trabajos.TabIndex = 11;
            this.lst_Trabajos.DoubleClick += new System.EventHandler(this.lst_Trabajos_DoubleClick);
            // 
            // frm_trabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_Trabajos);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.textBoxNMaximo);
            this.Controls.Add(this.textBoxNMinimo);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxIdTrabajo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_trabajo";
            this.Text = "frm_trabajo";
            this.Load += new System.EventHandler(this.frm_trabajo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIdTrabajo;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxNMinimo;
        private System.Windows.Forms.TextBox textBoxNMaximo;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.ListBox lst_Trabajos;
    }
}