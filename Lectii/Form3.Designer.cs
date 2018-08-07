namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Inapoi_La_Lectii = new System.Windows.Forms.Button();
            this.btnUrmatoarea_Pagina = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.Inapoi_La_Lectii, "Inapoi_La_Lectii");
            this.Inapoi_La_Lectii.Name = "Inapoi_La_Lectii";
            this.Inapoi_La_Lectii.UseVisualStyleBackColor = true;
            this.Inapoi_La_Lectii.Click += new System.EventHandler(this.Inapoi_La_Lectii_Click);
            // 
            // btnUrmatoarea_Pagina
            // 
            resources.ApplyResources(this.btnUrmatoarea_Pagina, "btnUrmatoarea_Pagina");
            this.btnUrmatoarea_Pagina.Name = "btnUrmatoarea_Pagina";
            this.btnUrmatoarea_Pagina.UseVisualStyleBackColor = true;
            this.btnUrmatoarea_Pagina.Click += new System.EventHandler(this.btnUrmatoarea_Pagina_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comenziRapideToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // comenziRapideToolStripMenuItem
            // 
            this.comenziRapideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inapoiLaMeniulPrincipalToolStripMenuItem,
            this.inapoiLaMeniulLectiiToolStripMenuItem,
            this.inchideAplicatiaToolStripMenuItem});
            this.comenziRapideToolStripMenuItem.Name = "comenziRapideToolStripMenuItem";
            resources.ApplyResources(this.comenziRapideToolStripMenuItem, "comenziRapideToolStripMenuItem");
            // 
            // inapoiLaMeniulPrincipalToolStripMenuItem
            // 
            this.inapoiLaMeniulPrincipalToolStripMenuItem.Name = "inapoiLaMeniulPrincipalToolStripMenuItem";
            resources.ApplyResources(this.inapoiLaMeniulPrincipalToolStripMenuItem, "inapoiLaMeniulPrincipalToolStripMenuItem");
            this.inapoiLaMeniulPrincipalToolStripMenuItem.Click += new System.EventHandler(this.inapoiLaMeniulPrincipalToolStripMenuItem_Click);
            // 
            // inapoiLaMeniulLectiiToolStripMenuItem
            // 
            this.inapoiLaMeniulLectiiToolStripMenuItem.Name = "inapoiLaMeniulLectiiToolStripMenuItem";
            resources.ApplyResources(this.inapoiLaMeniulLectiiToolStripMenuItem, "inapoiLaMeniulLectiiToolStripMenuItem");
            this.inapoiLaMeniulLectiiToolStripMenuItem.Click += new System.EventHandler(this.inapoiLaMeniulLectiiToolStripMenuItem_Click);
            // 
            // inchideAplicatiaToolStripMenuItem
            // 
            this.inchideAplicatiaToolStripMenuItem.Name = "inchideAplicatiaToolStripMenuItem";
            resources.ApplyResources(this.inchideAplicatiaToolStripMenuItem, "inchideAplicatiaToolStripMenuItem");
            this.inchideAplicatiaToolStripMenuItem.Click += new System.EventHandler(this.inchideAplicatiaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Congruenta_triunghiurilor1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.btnUrmatoarea_Pagina);
            this.Controls.Add(this.Inapoi_La_Lectii);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Inapoi_La_Lectii;
        private System.Windows.Forms.Button btnUrmatoarea_Pagina;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comenziRapideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiLaMeniulPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiLaMeniulLectiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchideAplicatiaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}