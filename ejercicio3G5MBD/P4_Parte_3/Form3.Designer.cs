
namespace P4_Parte_3
{
    partial class Form3
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
            this.lbNombreC = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.nUDcant = new System.Windows.Forms.NumericUpDown();
            this.dTime1 = new System.Windows.Forms.DateTimePicker();
            this.btnIngresarP = new System.Windows.Forms.Button();
            this.btnLimpiarP = new System.Windows.Forms.Button();
            this.btnVolverP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDcant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de libros:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre:";
            // 
            // lbNombreC
            // 
            this.lbNombreC.AutoSize = true;
            this.lbNombreC.Location = new System.Drawing.Point(407, 144);
            this.lbNombreC.Name = "lbNombreC";
            this.lbNombreC.Size = new System.Drawing.Size(46, 17);
            this.lbNombreC.TabIndex = 5;
            this.lbNombreC.Text = "label6";
            this.lbNombreC.Visible = false;
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(153, 85);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(175, 24);
            this.cbCliente.TabIndex = 6;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // nUDcant
            // 
            this.nUDcant.Location = new System.Drawing.Point(153, 139);
            this.nUDcant.Name = "nUDcant";
            this.nUDcant.Size = new System.Drawing.Size(49, 22);
            this.nUDcant.TabIndex = 7;
            // 
            // dTime1
            // 
            this.dTime1.Location = new System.Drawing.Point(74, 186);
            this.dTime1.Name = "dTime1";
            this.dTime1.Size = new System.Drawing.Size(254, 22);
            this.dTime1.TabIndex = 8;
            // 
            // btnIngresarP
            // 
            this.btnIngresarP.Location = new System.Drawing.Point(59, 268);
            this.btnIngresarP.Name = "btnIngresarP";
            this.btnIngresarP.Size = new System.Drawing.Size(75, 41);
            this.btnIngresarP.TabIndex = 9;
            this.btnIngresarP.Text = "Ingresar";
            this.btnIngresarP.UseVisualStyleBackColor = true;
            this.btnIngresarP.Click += new System.EventHandler(this.btnIngresarP_Click);
            // 
            // btnLimpiarP
            // 
            this.btnLimpiarP.Location = new System.Drawing.Point(217, 268);
            this.btnLimpiarP.Name = "btnLimpiarP";
            this.btnLimpiarP.Size = new System.Drawing.Size(75, 41);
            this.btnLimpiarP.TabIndex = 10;
            this.btnLimpiarP.Text = "Limpiar";
            this.btnLimpiarP.UseVisualStyleBackColor = true;
            this.btnLimpiarP.Click += new System.EventHandler(this.btnLimpiarP_Click);
            // 
            // btnVolverP
            // 
            this.btnVolverP.Location = new System.Drawing.Point(490, 264);
            this.btnVolverP.Name = "btnVolverP";
            this.btnVolverP.Size = new System.Drawing.Size(75, 45);
            this.btnVolverP.TabIndex = 11;
            this.btnVolverP.Text = "Volver";
            this.btnVolverP.UseVisualStyleBackColor = true;
            this.btnVolverP.Click += new System.EventHandler(this.btnVolverP_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 344);
            this.Controls.Add(this.btnVolverP);
            this.Controls.Add(this.btnLimpiarP);
            this.Controls.Add(this.btnIngresarP);
            this.Controls.Add(this.dTime1);
            this.Controls.Add(this.nUDcant);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.lbNombreC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDcant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNombreC;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.NumericUpDown nUDcant;
        private System.Windows.Forms.DateTimePicker dTime1;
        private System.Windows.Forms.Button btnIngresarP;
        private System.Windows.Forms.Button btnLimpiarP;
        private System.Windows.Forms.Button btnVolverP;
    }
}