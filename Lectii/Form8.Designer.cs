namespace WindowsFormsApplication1
{
    partial class Form8
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
            this.Next = new System.Windows.Forms.Button();
            this.Inapoi_La_Lectii = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comenziRapideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiLaMeniulPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiLaMeniulLectiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchideAplicatiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.Verifica2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(453, 623);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(147, 35);
            this.Next.TabIndex = 13;
            this.Next.Text = "Urmatorul";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click_1);
            // 
            // Inapoi_La_Lectii
            // 
            this.Inapoi_La_Lectii.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Inapoi_La_Lectii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inapoi_La_Lectii.Location = new System.Drawing.Point(21, 623);
            this.Inapoi_La_Lectii.Name = "Inapoi_La_Lectii";
            this.Inapoi_La_Lectii.Size = new System.Drawing.Size(163, 35);
            this.Inapoi_La_Lectii.TabIndex = 14;
            this.Inapoi_La_Lectii.Text = "Anterior";
            this.Inapoi_La_Lectii.UseVisualStyleBackColor = true;
            this.Inapoi_La_Lectii.Click += new System.EventHandler(this.Inapoi_La_Lectii_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comenziRapideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comenziRapideToolStripMenuItem
            // 
            this.comenziRapideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiLaMeniulPrincipalToolStripMenuItem,
            this.inapoiLaMeniulLectiiToolStripMenuItem,
            this.inchideAplicatiaToolStripMenuItem});
            this.comenziRapideToolStripMenuItem.Name = "comenziRapideToolStripMenuItem";
            this.comenziRapideToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.comenziRapideToolStripMenuItem.Text = "Comenzi rapide";
            // 
            // inapoiLaMeniulPrincipalToolStripMenuItem
            // 
            this.inapoiLaMeniulPrincipalToolStripMenuItem.Name = "inapoiLaMeniulPrincipalToolStripMenuItem";
            this.inapoiLaMeniulPrincipalToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.inapoiLaMeniulPrincipalToolStripMenuItem.Text = "Inapoi la meniul principal";
            this.inapoiLaMeniulPrincipalToolStripMenuItem.Click += new System.EventHandler(this.inapoiLaMeniulPrincipalToolStripMenuItem_Click);
            // 
            // inapoiLaMeniulLectiiToolStripMenuItem
            // 
            this.inapoiLaMeniulLectiiToolStripMenuItem.Name = "inapoiLaMeniulLectiiToolStripMenuItem";
            this.inapoiLaMeniulLectiiToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.inapoiLaMeniulLectiiToolStripMenuItem.Text = "Inapoi la meniul lectii";
            this.inapoiLaMeniulLectiiToolStripMenuItem.Click += new System.EventHandler(this.inapoiLaMeniulLectiiToolStripMenuItem_Click);
            // 
            // inchideAplicatiaToolStripMenuItem
            // 
            this.inchideAplicatiaToolStripMenuItem.Name = "inchideAplicatiaToolStripMenuItem";
            this.inchideAplicatiaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.inchideAplicatiaToolStripMenuItem.Text = "Inchide aplicatia";
            this.inchideAplicatiaToolStripMenuItem.Click += new System.EventHandler(this.inchideAplicatiaToolStripMenuItem_Click);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(154, 585);
            this.txt1.MaxLength = 3;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(38, 21);
            this.txt1.TabIndex = 26;
            this.txt1.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(223, 585);
            this.txt2.MaxLength = 3;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(38, 21);
            this.txt2.TabIndex = 27;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // Verifica2
            // 
            this.Verifica2.Enabled = false;
            this.Verifica2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verifica2.Location = new System.Drawing.Point(370, 583);
            this.Verifica2.Name = "Verifica2";
            this.Verifica2.Size = new System.Drawing.Size(85, 27);
            this.Verifica2.TabIndex = 38;
            this.Verifica2.Text = "Verifica";
            this.Verifica2.UseVisualStyleBackColor = true;
            this.Verifica2.Click += new System.EventHandler(this.Verifica2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Cazuri_Congruenta3;
            this.pictureBox1.Location = new System.Drawing.Point(21, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 666);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(620, 668);
            this.ControlBox = false;
            this.Controls.Add(this.Verifica2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Inapoi_La_Lectii);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(636, 707);
            this.MinimumSize = new System.Drawing.Size(636, 707);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lectie 2 Cazurile de congruenta ala triunghiurilor Pagina 3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Inapoi_La_Lectii;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comenziRapideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiLaMeniulPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiLaMeniulLectiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchideAplicatiaToolStripMenuItem;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button Verifica2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}