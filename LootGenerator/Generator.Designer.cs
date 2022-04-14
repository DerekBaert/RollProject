
namespace LootGenerator
{
    partial class Generator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.generatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoot = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoot = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(483, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // generatorsToolStripMenuItem
            // 
            this.generatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoot,
            this.mnuInventory});
            this.generatorsToolStripMenuItem.Name = "generatorsToolStripMenuItem";
            this.generatorsToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.generatorsToolStripMenuItem.Text = "&Generators";
            // 
            // mnuLoot
            // 
            this.mnuLoot.Name = "mnuLoot";
            this.mnuLoot.Size = new System.Drawing.Size(224, 26);
            this.mnuLoot.Text = "&Loot Generator";
            this.mnuLoot.Click += new System.EventHandler(this.mnuLoot_Click);
            // 
            // mnuInventory
            // 
            this.mnuInventory.Name = "mnuInventory";
            this.mnuInventory.Size = new System.Drawing.Size(224, 26);
            this.mnuInventory.Text = "&Inventory Generator";
            this.mnuInventory.Click += new System.EventHandler(this.mnuInventory_Click);
            // 
            // btnLoot
            // 
            this.btnLoot.Location = new System.Drawing.Point(52, 75);
            this.btnLoot.Name = "btnLoot";
            this.btnLoot.Size = new System.Drawing.Size(163, 59);
            this.btnLoot.TabIndex = 1;
            this.btnLoot.Text = "Loot";
            this.btnLoot.UseVisualStyleBackColor = true;
            this.btnLoot.Click += new System.EventHandler(this.btnLoot_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(260, 75);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(163, 59);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 180);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnLoot);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Generator";
            this.Text = "Derek\'s Item Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem generatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLoot;
        private System.Windows.Forms.ToolStripMenuItem mnuInventory;
        private System.Windows.Forms.Button btnLoot;
        private System.Windows.Forms.Button btnInventory;
    }
}