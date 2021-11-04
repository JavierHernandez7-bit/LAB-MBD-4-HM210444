
namespace HM21044_practica4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textcod1 = new System.Windows.Forms.TextBox();
            this.textapell = new System.Windows.Forms.TextBox();
            this.textnom1 = new System.Windows.Forms.TextBox();
            this.textedad1 = new System.Windows.Forms.TextBox();
            this.buscar1 = new System.Windows.Forms.Button();
            this.modificar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textcod1
            // 
            this.textcod1.Location = new System.Drawing.Point(173, 116);
            this.textcod1.Name = "textcod1";
            this.textcod1.Size = new System.Drawing.Size(151, 22);
            this.textcod1.TabIndex = 0;
            // 
            // textapell
            // 
            this.textapell.Location = new System.Drawing.Point(173, 208);
            this.textapell.Name = "textapell";
            this.textapell.Size = new System.Drawing.Size(151, 22);
            this.textapell.TabIndex = 1;
            this.textapell.Visible = false;
            // 
            // textnom1
            // 
            this.textnom1.Location = new System.Drawing.Point(173, 155);
            this.textnom1.Name = "textnom1";
            this.textnom1.Size = new System.Drawing.Size(151, 22);
            this.textnom1.TabIndex = 2;
            this.textnom1.Visible = false;
            // 
            // textedad1
            // 
            this.textedad1.Location = new System.Drawing.Point(173, 252);
            this.textedad1.Name = "textedad1";
            this.textedad1.Size = new System.Drawing.Size(151, 22);
            this.textedad1.TabIndex = 3;
            this.textedad1.Visible = false;
            // 
            // buscar1
            // 
            this.buscar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar1.Location = new System.Drawing.Point(354, 50);
            this.buscar1.Name = "buscar1";
            this.buscar1.Size = new System.Drawing.Size(100, 34);
            this.buscar1.TabIndex = 4;
            this.buscar1.Text = "Buscar";
            this.buscar1.UseVisualStyleBackColor = true;
            this.buscar1.Click += new System.EventHandler(this.buscar1_Click);
            // 
            // modificar1
            // 
            this.modificar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar1.Location = new System.Drawing.Point(57, 354);
            this.modificar1.Name = "modificar1";
            this.modificar1.Size = new System.Drawing.Size(104, 40);
            this.modificar1.TabIndex = 5;
            this.modificar1.Text = "Modificar";
            this.modificar1.UseVisualStyleBackColor = true;
            this.modificar1.Visible = false;
            this.modificar1.Click += new System.EventHandler(this.modificar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Edad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 421);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modificar1);
            this.Controls.Add(this.buscar1);
            this.Controls.Add(this.textedad1);
            this.Controls.Add(this.textnom1);
            this.Controls.Add(this.textapell);
            this.Controls.Add(this.textcod1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textcod1;
        private System.Windows.Forms.TextBox textapell;
        private System.Windows.Forms.TextBox textnom1;
        private System.Windows.Forms.TextBox textedad1;
        private System.Windows.Forms.Button buscar1;
        private System.Windows.Forms.Button modificar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

