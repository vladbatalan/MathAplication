namespace WindowsFormsApplication1
{
    partial class Form6
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
            this.Inapoi_La_Lectii = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comenziRapideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiLaMeniulPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiLaMeniulLectiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchideAplicatiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Inapoi_La_Lectii
            // 
            this.Inapoi_La_Lectii.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Inapoi_La_Lectii.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inapoi_La_Lectii.Location = new System.Drawing.Point(21, 632);
            this.Inapoi_La_Lectii.Name = "Inapoi_La_Lectii";
            this.Inapoi_La_Lectii.Size = new System.Drawing.Size(283, 35);
            this.Inapoi_La_Lectii.TabIndex = 8;
            this.Inapoi_La_Lectii.Text = "Inapoi la lista cu lectii";
            this.Inapoi_La_Lectii.UseVisualStyleBackColor = true;
            this.Inapoi_La_Lectii.Click += new System.EventHandler(this.Inapoi_La_Lectii_Click);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(389, 632);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(147, 35);
            this.Next.TabIndex = 9;
            this.Next.Text = "Urmatorul";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comenziRapideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 23;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Cazuri_Congruenta1;
            this.pictureBox1.Location = new System.Drawing.Point(21, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(515, 664);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(558, 678);
            this.ControlBox = false;
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Inapoi_La_Lectii);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(574, 717);
            this.MinimumSize = new System.Drawing.Size(574, 717);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lectie 2 Cazurile de congruenta ala triunghiurilor Pagina 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inapoi_La_Lectii;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comenziRapideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiLaMeniulPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiLaMeniulLectiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchideAplicatiaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}