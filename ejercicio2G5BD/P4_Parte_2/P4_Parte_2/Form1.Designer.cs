
namespace P4_Parte_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.textcod1 = new System.Windows.Forms.TextBox();
            this.textnom1 = new System.Windows.Forms.TextBox();
            this.textapel1 = new System.Windows.Forms.TextBox();
            this.textedad1 = new System.Windows.Forms.TextBox();
            this.modificar1 = new System.Windows.Forms.Button();
            this.buscar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.text.Location = new System.Drawing.Point(30, 196);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(57, 20);
            this.text.TabIndex = 3;
            this.text.Text = "Edad:";
            // 
            // textcod1
            // 
            this.textcod1.Location = new System.Drawing.Point(117, 39);
            this.textcod1.Name = "textcod1";
            this.textcod1.Size = new System.Drawing.Size(160, 22);
            this.textcod1.TabIndex = 4;
            // 
            // textnom1
            // 
            this.textnom1.Location = new System.Drawing.Point(117, 91);
            this.textnom1.Name = "textnom1";
            this.textnom1.Size = new System.Drawing.Size(160, 22);
            this.textnom1.TabIndex = 5;
            this.textnom1.Visible = false;
            // 
            // textapel1
            // 
            this.textapel1.Location = new System.Drawing.Point(117, 143);
            this.textapel1.Name = "textapel1";
            this.textapel1.Size = new System.Drawing.Size(160, 22);
            this.textapel1.TabIndex = 6;
            this.textapel1.Visible = false;
            // 
            // textedad1
            // 
            this.textedad1.Location = new System.Drawing.Point(117, 196);
            this.textedad1.Name = "textedad1";
            this.textedad1.Size = new System.Drawing.Size(160, 22);
            this.textedad1.TabIndex = 7;
            this.textedad1.Visible = false;
            // 
            // modificar1
            // 
            this.modificar1.BackColor = System.Drawing.Color.Yellow;
            this.modificar1.ForeColor = System.Drawing.Color.Red;
            this.modificar1.Location = new System.Drawing.Point(75, 255);
            this.modificar1.Name = "modificar1";
            this.modificar1.Size = new System.Drawing.Size(119, 33);
            this.modificar1.TabIndex = 8;
            this.modificar1.Text = "Modificar";
            this.modificar1.UseVisualStyleBackColor = false;
            this.modificar1.Visible = false;
            this.modificar1.Click += new System.EventHandler(this.modificar1_Click);
            // 
            // buscar1
            // 
            this.buscar1.BackColor = System.Drawing.Color.OrangeRed;
            this.buscar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar1.ForeColor = System.Drawing.Color.Black;
            this.buscar1.Location = new System.Drawing.Point(305, 39);
            this.buscar1.Name = "buscar1";
            this.buscar1.Size = new System.Drawing.Size(99, 39);
            this.buscar1.TabIndex = 9;
            this.buscar1.Text = "Buscar";
            this.buscar1.UseVisualStyleBackColor = false;
            this.buscar1.Click += new System.EventHandler(this.buscar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(454, 311);
            this.Controls.Add(this.buscar1);
            this.Controls.Add(this.modificar1);
            this.Controls.Add(this.textedad1);
            this.Controls.Add(this.textapel1);
            this.Controls.Add(this.textnom1);
            this.Controls.Add(this.textcod1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox textcod1;
        private System.Windows.Forms.TextBox textnom1;
        private System.Windows.Forms.TextBox textapel1;
        private System.Windows.Forms.TextBox textedad1;
        private System.Windows.Forms.Button modificar1;
        private System.Windows.Forms.Button buscar1;
    }
}

