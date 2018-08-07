namespace WindowsFormsApplication1
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
            this.Lectie1 = new System.Windows.Forms.Button();
            this.Lectie2 = new System.Windows.Forms.Button();
            this.Lectie3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comenziRapideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiLaMeniulPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inapoiLaMeniulLectiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchideAplicatiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lectie1
            // 
            this.Lectie1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Lectie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lectie1.Location = new System.Drawing.Point(12, 61);
            this.Lectie1.Name = "Lectie1";
            this.Lectie1.Size = new System.Drawing.Size(283, 34);
            this.Lectie1.TabIndex = 0;
            this.Lectie1.Text = "Introducere";
            this.Lectie1.UseVisualStyleBackColor = true;
            this.Lectie1.Click += new System.EventHandler(this.Lectie1_Click);
            // 
            // Lectie2
            // 
            this.Lectie2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Lectie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lectie2.Location = new System.Drawing.Point(12, 110);
            this.Lectie2.Name = "Lectie2";
            this.Lectie2.Size = new System.Drawing.Size(283, 34);
            this.Lectie2.TabIndex = 1;
            this.Lectie2.Text = "Cazuri de congruență";
            this.Lectie2.UseVisualStyleBackColor = true;
            this.Lectie2.Click += new System.EventHandler(this.Lectie2_Click);
            // 
            // Lectie3
            // 
            this.Lectie3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Lectie3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lectie3.Location = new System.Drawing.Point(12, 160);
            this.Lectie3.Name = "Lectie3";
            this.Lectie3.Size = new System.Drawing.Size(283, 34);
            this.Lectie3.TabIndex = 2;
            this.Lectie3.Text = "Congruența triunghiurilor dreptunghice";
            this.Lectie3.UseVisualStyleBackColor = true;
            this.Lectie3.Click += new System.EventHandler(this.Lectie3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cogruența triunghiurilor";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Înapoi la meniul pricipal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comenziRapideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 24);
            this.menuStrip1.TabIndex = 27;
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
            this.inapoiLaMeniulLectiiToolStripMenuItem.Enabled = false;
            this.inapoiLaMeniulLectiiToolStripMenuItem.Name = "inapoiLaMeniulLectiiToolStripMenuItem";
            this.inapoiLaMeniulLectiiToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.inapoiLaMeniulLectiiToolStripMenuItem.Text = "Inapoi la meniul lectii";
            // 
            // inchideAplicatiaToolStripMenuItem
            // 
            this.inchideAplicatiaToolStripMenuItem.Name = "inchideAplicatiaToolStripMenuItem";
            this.inchideAplicatiaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.inchideAplicatiaToolStripMenuItem.Text = "Inchide aplicatia";
            this.inchideAplicatiaToolStripMenuItem.Click += new System.EventHandler(this.inchideAplicatiaToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(307, 264);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lectie3);
            this.Controls.Add(this.Lectie2);
            this.Controls.Add(this.Lectie1);
            this.MaximumSize = new System.Drawing.Size(323, 302);
            this.MinimumSize = new System.Drawing.Size(323, 302);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lectii";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lectie1;
        private System.Windows.Forms.Button Lectie2;
        private System.Windows.Forms.Button Lectie3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comenziRapideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiLaMeniulPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inapoiLaMeniulLectiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchideAplicatiaToolStripMenuItem;
    }
}