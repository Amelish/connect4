namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
         
        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {   
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesSpielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mittelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schwerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entwicklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Spalte_0 = new System.Windows.Forms.Button();
            this.btn_Spalte_1 = new System.Windows.Forms.Button();
            this.btn_Spalte_2 = new System.Windows.Forms.Button();
            this.btn_Spalte_3 = new System.Windows.Forms.Button();
            this.btn_Spalte_4 = new System.Windows.Forms.Button();
            this.btn_Spalte_5 = new System.Windows.Forms.Button();
            this.btn_Spalte_6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesSpielToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // neuesSpielToolStripMenuItem
            // 
            this.neuesSpielToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leichtToolStripMenuItem,
            this.mittelToolStripMenuItem,
            this.schwerToolStripMenuItem});
            this.neuesSpielToolStripMenuItem.Name = "neuesSpielToolStripMenuItem";
            this.neuesSpielToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.neuesSpielToolStripMenuItem.Text = "Neues Spiel";
            this.neuesSpielToolStripMenuItem.Click += new System.EventHandler(this.neuesSpielToolStripMenuItem_Click);
            // 
            // leichtToolStripMenuItem
            // 
            this.leichtToolStripMenuItem.Name = "leichtToolStripMenuItem";
            this.leichtToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.leichtToolStripMenuItem.Text = "leicht";
            // 
            // mittelToolStripMenuItem
            // 
            this.mittelToolStripMenuItem.Name = "mittelToolStripMenuItem";
            this.mittelToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.mittelToolStripMenuItem.Text = "mittel";
            // 
            // schwerToolStripMenuItem
            // 
            this.schwerToolStripMenuItem.Name = "schwerToolStripMenuItem";
            this.schwerToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.schwerToolStripMenuItem.Text = "schwer";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entwicklerToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // entwicklerToolStripMenuItem
            // 
            this.entwicklerToolStripMenuItem.Name = "entwicklerToolStripMenuItem";
            this.entwicklerToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.entwicklerToolStripMenuItem.Text = "Entwickler";
            this.entwicklerToolStripMenuItem.Click += new System.EventHandler(this.entwicklerToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "Hilfe";
            // 
            // btn_Spalte_0
            // 
            this.btn_Spalte_0.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Spalte_0.Location = new System.Drawing.Point(103, 85);
            this.btn_Spalte_0.Name = "btn_Spalte_0";
            this.btn_Spalte_0.Size = new System.Drawing.Size(75, 26);
            this.btn_Spalte_0.TabIndex = 51;
            this.btn_Spalte_0.UseVisualStyleBackColor = false;
            this.btn_Spalte_0.Click += new System.EventHandler(this.btn_Spalte_0_Click);
            // 
            // btn_Spalte_1
            // 
            this.btn_Spalte_1.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Spalte_1.Location = new System.Drawing.Point(177, 85);
            this.btn_Spalte_1.Name = "btn_Spalte_1";
            this.btn_Spalte_1.Size = new System.Drawing.Size(75, 26);
            this.btn_Spalte_1.TabIndex = 52;
            this.btn_Spalte_1.UseVisualStyleBackColor = false;
            this.btn_Spalte_1.Click += new System.EventHandler(this.btn_Spalte_1_Click);
            // 
            // btn_Spalte_2
            // 
            this.btn_Spalte_2.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Spalte_2.Location = new System.Drawing.Point(251, 85);
            this.btn_Spalte_2.Name = "btn_Spalte_2";
            this.btn_Spalte_2.Size = new System.Drawing.Size(75, 26);
            this.btn_Spalte_2.TabIndex = 53;
            this.btn_Spalte_2.UseVisualStyleBackColor = false;
            this.btn_Spalte_2.Click += new System.EventHandler(this.btn_Spalte_2_Click);
            // 
            // btn_Spalte_3
            // 
            this.btn_Spalte_3.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Spalte_3.Location = new System.Drawing.Point(325, 85);
            this.btn_Spalte_3.Name = "btn_Spalte_3";
            this.btn_Spalte_3.Size = new System.Drawing.Size(75, 26);
            this.btn_Spalte_3.TabIndex = 54;
            this.btn_Spalte_3.UseVisualStyleBackColor = false;
            this.btn_Spalte_3.Click += new System.EventHandler(this.btn_Spalte_3_Click);
            // 
            // btn_Spalte_4
            // 
            this.btn_Spalte_4.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Spalte_4.Location = new System.Drawing.Point(399, 85);
            this.btn_Spalte_4.Name = "btn_Spalte_4";
            this.btn_Spalte_4.Size = new System.Drawing.Size(75, 26);
            this.btn_Spalte_4.TabIndex = 55;
            this.btn_Spalte_4.UseVisualStyleBackColor = false;
            this.btn_Spalte_4.Click += new System.EventHandler(this.btn_Spalte_4_Click);
            // 
            // btn_Spalte_5
            // 
            this.btn_Spalte_5.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Spalte_5.Location = new System.Drawing.Point(473, 85);
            this.btn_Spalte_5.Name = "btn_Spalte_5";
            this.btn_Spalte_5.Size = new System.Drawing.Size(75, 26);
            this.btn_Spalte_5.TabIndex = 56;
            this.btn_Spalte_5.UseVisualStyleBackColor = false;
            this.btn_Spalte_5.Click += new System.EventHandler(this.btn_Spalte_5_Click);
            // 
            // btn_Spalte_6
            // 
            this.btn_Spalte_6.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Spalte_6.Location = new System.Drawing.Point(547, 85);
            this.btn_Spalte_6.Name = "btn_Spalte_6";
            this.btn_Spalte_6.Size = new System.Drawing.Size(75, 26);
            this.btn_Spalte_6.TabIndex = 57;
            this.btn_Spalte_6.UseVisualStyleBackColor = false;
            this.btn_Spalte_6.Click += new System.EventHandler(this.btn_Spalte_6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(727, 626);
            this.Controls.Add(this.btn_Spalte_6);
            this.Controls.Add(this.btn_Spalte_5);
            this.Controls.Add(this.btn_Spalte_4);
            this.Controls.Add(this.btn_Spalte_3);
            this.Controls.Add(this.btn_Spalte_2);
            this.Controls.Add(this.btn_Spalte_1);
            this.Controls.Add(this.btn_Spalte_0);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vier Gewinnt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neuesSpielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mittelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schwerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entwicklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Button btn_Spalte_0;
        private System.Windows.Forms.Button btn_Spalte_1;
        private System.Windows.Forms.Button btn_Spalte_2;
        private System.Windows.Forms.Button btn_Spalte_3;
        private System.Windows.Forms.Button btn_Spalte_4;
        private System.Windows.Forms.Button btn_Spalte_5;
        private System.Windows.Forms.Button btn_Spalte_6;
    }
}

