
namespace HM21044_practica4
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textcod2 = new System.Windows.Forms.TextBox();
            this.textnom2 = new System.Windows.Forms.TextBox();
            this.textedad2 = new System.Windows.Forms.TextBox();
            this.textapell2 = new System.Windows.Forms.TextBox();
            this.insertar2 = new System.Windows.Forms.Button();
            this.buscar2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textcod2
            // 
            this.textcod2.Location = new System.Drawing.Point(201, 115);
            this.textcod2.Name = "textcod2";
            this.textcod2.Size = new System.Drawing.Size(156, 22);
            this.textcod2.TabIndex = 0;
            // 
            // textnom2
            // 
            this.textnom2.Location = new System.Drawing.Point(201, 187);
            this.textnom2.Name = "textnom2";
            this.textnom2.Size = new System.Drawing.Size(156, 22);
            this.textnom2.TabIndex = 1;
            // 
            // textedad2
            // 
            this.textedad2.Location = new System.Drawing.Point(201, 310);
            this.textedad2.Name = "textedad2";
            this.textedad2.Size = new System.Drawing.Size(156, 22);
            this.textedad2.TabIndex = 2;
            // 
            // textapell2
            // 
            this.textapell2.Location = new System.Drawing.Point(201, 245);
            this.textapell2.Name = "textapell2";
            this.textapell2.Size = new System.Drawing.Size(156, 22);
            this.textapell2.TabIndex = 3;
            // 
            // insertar2
            // 
            this.insertar2.Location = new System.Drawing.Point(262, 378);
            this.insertar2.Name = "insertar2";
            this.insertar2.Size = new System.Drawing.Size(95, 32);
            this.insertar2.TabIndex = 4;
            this.insertar2.Text = "Insertar";
            this.insertar2.UseVisualStyleBackColor = true;
            this.insertar2.Click += new System.EventHandler(this.insertar2_Click);
            // 
            // buscar2
            // 
            this.buscar2.Location = new System.Drawing.Point(130, 378);
            this.buscar2.Name = "buscar2";
            this.buscar2.Size = new System.Drawing.Size(95, 32);
            this.buscar2.TabIndex = 5;
            this.buscar2.Text = "Buscar";
            this.buscar2.UseVisualStyleBackColor = true;
            this.buscar2.Click += new System.EventHandler(this.buscar2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apelido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Edad:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar2);
            this.Controls.Add(this.insertar2);
            this.Controls.Add(this.textapell2);
            this.Controls.Add(this.textedad2);
            this.Controls.Add(this.textnom2);
            this.Controls.Add(this.textcod2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textcod2;
        private System.Windows.Forms.TextBox textnom2;
        private System.Windows.Forms.TextBox textedad2;
        private System.Windows.Forms.TextBox textapell2;
        private System.Windows.Forms.Button insertar2;
        private System.Windows.Forms.Button buscar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}