namespace WindowsFormsApplication1
{
    partial class Form7
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt11 = new System.Windows.Forms.TextBox();
            this.txt12 = new System.Windows.Forms.TextBox();
            this.txt14 = new System.Windows.Forms.TextBox();
            this.txt13 = new System.Windows.Forms.TextBox();
            this.txt16 = new System.Windows.Forms.TextBox();
            this.txt15 = new System.Windows.Forms.TextBox();
            this.txt17 = new System.Windows.Forms.TextBox();
            this.txt18 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Verifica1 = new System.Windows.Forms.Button();
            this.txt28 = new System.Windows.Forms.TextBox();
            this.txt27 = new System.Windows.Forms.TextBox();
            this.txt23 = new System.Windows.Forms.TextBox();
            this.txt26 = new System.Windows.Forms.TextBox();
            this.txt24 = new System.Windows.Forms.TextBox();
            this.txt22 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt21 = new System.Windows.Forms.TextBox();
            this.txt25 = new System.Windows.Forms.TextBox();
            this.Verifica2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(405, 583);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(147, 35);
            this.Next.TabIndex = 11;
            this.Next.Text = "Urmatorul";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Inapoi_La_Lectii
            // 
            this.Inapoi_La_Lectii.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Inapoi_La_Lectii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inapoi_La_Lectii.Location = new System.Drawing.Point(0, 583);
            this.Inapoi_La_Lectii.Name = "Inapoi_La_Lectii";
            this.Inapoi_La_Lectii.Size = new System.Drawing.Size(163, 35);
            this.Inapoi_La_Lectii.TabIndex = 10;
            this.Inapoi_La_Lectii.Text = "Anterior";
            this.Inapoi_La_Lectii.UseVisualStyleBackColor = true;
            this.Inapoi_La_Lectii.Click += new System.EventHandler(this.Inapoi_La_Lectii_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comenziRapideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 24;
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
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "AB",
            "BC",
            "AC",
            "MN",
            "NP",
            "MP",
            "ABC",
            "ACB",
            "BAC",
            "BCA",
            "CAB",
            "CBA",
            "MNP",
            "MPN",
            "NMP",
            "NPM",
            "PMN",
            "PNM"});
            this.listBox1.Location = new System.Drawing.Point(534, 185);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(42, 292);
            this.listBox1.TabIndex = 25;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // txt11
            // 
            this.txt11.AllowDrop = true;
            this.txt11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt11.Location = new System.Drawing.Point(37, 24);
            this.txt11.Name = "txt11";
            this.txt11.ReadOnly = true;
            this.txt11.Size = new System.Drawing.Size(26, 20);
            this.txt11.TabIndex = 26;
            this.txt11.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt11_DragEnter);
            // 
            // txt12
            // 
            this.txt12.AllowDrop = true;
            this.txt12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt12.Location = new System.Drawing.Point(81, 24);
            this.txt12.Name = "txt12";
            this.txt12.ReadOnly = true;
            this.txt12.Size = new System.Drawing.Size(27, 20);
            this.txt12.TabIndex = 27;
            this.txt12.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt11_DragEnter);
            // 
            // txt14
            // 
            this.txt14.AllowDrop = true;
            this.txt14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt14.Location = new System.Drawing.Point(82, 44);
            this.txt14.Name = "txt14";
            this.txt14.ReadOnly = true;
            this.txt14.Size = new System.Drawing.Size(27, 20);
            this.txt14.TabIndex = 29;
            this.txt14.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt11_DragEnter);
            // 
            // txt13
            // 
            this.txt13.AllowDrop = true;
            this.txt13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt13.Location = new System.Drawing.Point(36, 44);
            this.txt13.Name = "txt13";
            this.txt13.ReadOnly = true;
            this.txt13.Size = new System.Drawing.Size(27, 20);
            this.txt13.TabIndex = 28;
            this.txt13.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt11_DragEnter);
            // 
            // txt16
            // 
            this.txt16.AllowDrop = true;
            this.txt16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt16.Location = new System.Drawing.Point(90, 64);
            this.txt16.Name = "txt16";
            this.txt16.ReadOnly = true;
            this.txt16.Size = new System.Drawing.Size(27, 20);
            this.txt16.TabIndex = 31;
            this.txt16.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt11_DragEnter);
            // 
            // txt15
            // 
            this.txt15.AllowDrop = true;
            this.txt15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt15.Location = new System.Drawing.Point(40, 64);
            this.txt15.Name = "txt15";
            this.txt15.ReadOnly = true;
            this.txt15.Size = new System.Drawing.Size(27, 20);
            this.txt15.TabIndex = 32;
            this.txt15.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt11_DragEnter);
            // 
            // txt17
            // 
            this.txt17.AllowDrop = true;
            this.txt17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt17.Location = new System.Drawing.Point(189, 43);
            this.txt17.Name = "txt17";
            this.txt17.ReadOnly = true;
            this.txt17.Size = new System.Drawing.Size(36, 20);
            this.txt17.TabIndex = 34;
            this.txt17.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt11_DragEnter);
            // 
            // txt18
            // 
            this.txt18.AllowDrop = true;
            this.txt18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt18.Location = new System.Drawing.Point(254, 44);
            this.txt18.Name = "txt18";
            this.txt18.ReadOnly = true;
            this.txt18.Size = new System.Drawing.Size(36, 20);
            this.txt18.TabIndex = 33;
            this.txt18.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt11_DragEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt18);
            this.groupBox1.Controls.Add(this.txt17);
            this.groupBox1.Controls.Add(this.txt11);
            this.groupBox1.Controls.Add(this.txt12);
            this.groupBox1.Controls.Add(this.txt15);
            this.groupBox1.Controls.Add(this.txt13);
            this.groupBox1.Controls.Add(this.txt16);
            this.groupBox1.Controls.Add(this.txt14);
            this.groupBox1.Location = new System.Drawing.Point(81, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 93);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Muta Obiectele din casuta";
            // 
            // Verifica1
            // 
            this.Verifica1.Enabled = false;
            this.Verifica1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verifica1.Location = new System.Drawing.Point(442, 254);
            this.Verifica1.Name = "Verifica1";
            this.Verifica1.Size = new System.Drawing.Size(85, 27);
            this.Verifica1.TabIndex = 36;
            this.Verifica1.Text = "Verifica";
            this.Verifica1.UseVisualStyleBackColor = true;
            this.Verifica1.Click += new System.EventHandler(this.Verifica1_Click);
            // 
            // txt28
            // 
            this.txt28.AllowDrop = true;
            this.txt28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt28.Location = new System.Drawing.Point(260, 42);
            this.txt28.Name = "txt28";
            this.txt28.ReadOnly = true;
            this.txt28.Size = new System.Drawing.Size(36, 20);
            this.txt28.TabIndex = 33;
            this.txt28.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt28_DragEnter);
            // 
            // txt27
            // 
            this.txt27.AllowDrop = true;
            this.txt27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt27.Location = new System.Drawing.Point(191, 43);
            this.txt27.Name = "txt27";
            this.txt27.ReadOnly = true;
            this.txt27.Size = new System.Drawing.Size(36, 20);
            this.txt27.TabIndex = 34;
            this.txt27.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt28_DragEnter);
            // 
            // txt23
            // 
            this.txt23.AllowDrop = true;
            this.txt23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt23.Location = new System.Drawing.Point(42, 44);
            this.txt23.Name = "txt23";
            this.txt23.ReadOnly = true;
            this.txt23.Size = new System.Drawing.Size(27, 20);
            this.txt23.TabIndex = 28;
            this.txt23.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt28_DragEnter);
            // 
            // txt26
            // 
            this.txt26.AllowDrop = true;
            this.txt26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt26.Location = new System.Drawing.Point(92, 64);
            this.txt26.Name = "txt26";
            this.txt26.ReadOnly = true;
            this.txt26.Size = new System.Drawing.Size(27, 20);
            this.txt26.TabIndex = 31;
            this.txt26.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt28_DragEnter);
            // 
            // txt24
            // 
            this.txt24.AllowDrop = true;
            this.txt24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt24.Location = new System.Drawing.Point(87, 43);
            this.txt24.Name = "txt24";
            this.txt24.ReadOnly = true;
            this.txt24.Size = new System.Drawing.Size(27, 20);
            this.txt24.TabIndex = 29;
            this.txt24.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt28_DragEnter);
            // 
            // txt22
            // 
            this.txt22.AllowDrop = true;
            this.txt22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt22.Location = new System.Drawing.Point(87, 22);
            this.txt22.Name = "txt22";
            this.txt22.ReadOnly = true;
            this.txt22.Size = new System.Drawing.Size(27, 20);
            this.txt22.TabIndex = 27;
            this.txt22.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt28_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt28);
            this.groupBox2.Controls.Add(this.txt27);
            this.groupBox2.Controls.Add(this.txt21);
            this.groupBox2.Controls.Add(this.txt22);
            this.groupBox2.Controls.Add(this.txt25);
            this.groupBox2.Controls.Add(this.txt23);
            this.groupBox2.Controls.Add(this.txt26);
            this.groupBox2.Controls.Add(this.txt24);
            this.groupBox2.Location = new System.Drawing.Point(75, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 104);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Muta Obiectele din casuta";
            // 
            // txt21
            // 
            this.txt21.AllowDrop = true;
            this.txt21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt21.Location = new System.Drawing.Point(42, 23);
            this.txt21.Name = "txt21";
            this.txt21.ReadOnly = true;
            this.txt21.Size = new System.Drawing.Size(27, 20);
            this.txt21.TabIndex = 26;
            this.txt21.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt28_DragEnter);
            // 
            // txt25
            // 
            this.txt25.AllowDrop = true;
            this.txt25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txt25.Location = new System.Drawing.Point(46, 63);
            this.txt25.Name = "txt25";
            this.txt25.ReadOnly = true;
            this.txt25.Size = new System.Drawing.Size(27, 20);
            this.txt25.TabIndex = 32;
            this.txt25.DragEnter += new System.Windows.Forms.DragEventHandler(this.txt28_DragEnter);
            // 
            // Verifica2
            // 
            this.Verifica2.Enabled = false;
            this.Verifica2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Verifica2.Location = new System.Drawing.Point(412, 373);
            this.Verifica2.Name = "Verifica2";
            this.Verifica2.Size = new System.Drawing.Size(85, 27);
            this.Verifica2.TabIndex = 37;
            this.Verifica2.Text = "Verifica";
            this.Verifica2.UseVisualStyleBackColor = true;
            this.Verifica2.Click += new System.EventHandler(this.Verifica2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Cazuri_Congruenta2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Verifica2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.Inapoi_La_Lectii);
            this.panel1.Location = new System.Drawing.Point(21, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 665);
            this.panel1.TabIndex = 39;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(595, 657);
            this.ControlBox = false;
            this.Controls.Add(this.Verifica1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(611, 696);
            this.MinimumSize = new System.Drawing.Size(611, 696);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lectie 2 Cazurile de congruenta ala triunghiurilor Pagina 2";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt11;
        private System.Windows.Forms.TextBox txt12;
        private System.Windows.Forms.TextBox txt14;
        private System.Windows.Forms.TextBox txt13;
        private System.Windows.Forms.TextBox txt16;
        private System.Windows.Forms.TextBox txt15;
        private System.Windows.Forms.TextBox txt17;
        private System.Windows.Forms.TextBox txt18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Verifica1;
        private System.Windows.Forms.TextBox txt28;
        private System.Windows.Forms.TextBox txt27;
        private System.Windows.Forms.TextBox txt23;
        private System.Windows.Forms.TextBox txt26;
        private System.Windows.Forms.TextBox txt24;
        private System.Windows.Forms.TextBox txt22;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt21;
        private System.Windows.Forms.TextBox txt25;
        private System.Windows.Forms.Button Verifica2;
        private System.Windows.Forms.Panel panel1;
    }
}