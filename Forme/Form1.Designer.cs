namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.btnIncepe_teste = new System.Windows.Forms.Button();
            this.Lectii = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIncepe_teste
            // 
            this.btnIncepe_teste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncepe_teste.Location = new System.Drawing.Point(49, 90);
            this.btnIncepe_teste.Name = "btnIncepe_teste";
            this.btnIncepe_teste.Size = new System.Drawing.Size(173, 44);
            this.btnIncepe_teste.TabIndex = 0;
            this.btnIncepe_teste.Text = "Teste sumative";
            this.btnIncepe_teste.UseVisualStyleBackColor = true;
            this.btnIncepe_teste.Click += new System.EventHandler(this.btnIncepe_teste_Click);
            // 
            // Lectii
            // 
            this.Lectii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lectii.Location = new System.Drawing.Point(49, 40);
            this.Lectii.Name = "Lectii";
            this.Lectii.Size = new System.Drawing.Size(173, 44);
            this.Lectii.TabIndex = 1;
            this.Lectii.Text = "Vezi Lecțiile";
            this.Lectii.UseVisualStyleBackColor = true;
            this.Lectii.Click += new System.EventHandler(this.Lectii_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aplicații ale matematicii";
            // 
            // Autor
            // 
            this.Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.Location = new System.Drawing.Point(49, 140);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(173, 44);
            this.Autor.TabIndex = 3;
            this.Autor.Text = "Informații aplicație";
            this.Autor.UseVisualStyleBackColor = true;
            this.Autor.Click += new System.EventHandler(this.Autor_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(49, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Închide aplicația";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(271, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lectii);
            this.Controls.Add(this.btnIncepe_teste);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicatii ale matamaticii de Batalan Vlad";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncepe_teste;
        private System.Windows.Forms.Button Lectii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Autor;
        private System.Windows.Forms.Button button1;
    }
}

