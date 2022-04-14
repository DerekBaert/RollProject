
namespace LootGenerator
{
    partial class LootGenerator
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCommon = new System.Windows.Forms.TextBox();
            this.txtUncommon = new System.Windows.Forms.TextBox();
            this.txtVeryRare = new System.Windows.Forms.TextBox();
            this.txtRare = new System.Windows.Forms.TextBox();
            this.txtLegendary = new System.Windows.Forms.TextBox();
            this.dgvLoot = new System.Windows.Forms.DataGridView();
            this.displayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rarity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRoll = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPotions = new System.Windows.Forms.TextBox();
            this.txtWands = new System.Windows.Forms.TextBox();
            this.txtOils = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.rarityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Common:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uncommon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rare:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Very Rare:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Legendary:";
            // 
            // txtCommon
            // 
            this.txtCommon.Location = new System.Drawing.Point(215, 36);
            this.txtCommon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCommon.Name = "txtCommon";
            this.txtCommon.Size = new System.Drawing.Size(36, 20);
            this.txtCommon.TabIndex = 6;
            this.txtCommon.Text = "0";
            this.txtCommon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUncommon
            // 
            this.txtUncommon.Location = new System.Drawing.Point(215, 59);
            this.txtUncommon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUncommon.Name = "txtUncommon";
            this.txtUncommon.Size = new System.Drawing.Size(36, 20);
            this.txtUncommon.TabIndex = 7;
            this.txtUncommon.Text = "0";
            this.txtUncommon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVeryRare
            // 
            this.txtVeryRare.Location = new System.Drawing.Point(215, 105);
            this.txtVeryRare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVeryRare.Name = "txtVeryRare";
            this.txtVeryRare.Size = new System.Drawing.Size(36, 20);
            this.txtVeryRare.TabIndex = 9;
            this.txtVeryRare.Text = "0";
            this.txtVeryRare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRare
            // 
            this.txtRare.Location = new System.Drawing.Point(215, 83);
            this.txtRare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRare.Name = "txtRare";
            this.txtRare.Size = new System.Drawing.Size(36, 20);
            this.txtRare.TabIndex = 8;
            this.txtRare.Text = "0";
            this.txtRare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLegendary
            // 
            this.txtLegendary.Location = new System.Drawing.Point(215, 129);
            this.txtLegendary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLegendary.Name = "txtLegendary";
            this.txtLegendary.Size = new System.Drawing.Size(36, 20);
            this.txtLegendary.TabIndex = 10;
            this.txtLegendary.Text = "0";
            this.txtLegendary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvLoot
            // 
            this.dgvLoot.AutoGenerateColumns = false;
            this.dgvLoot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.displayNameDataGridViewTextBoxColumn,
            this.Rarity,
            this.sourceDataGridViewTextBoxColumn,
            this.Notes});
            this.dgvLoot.DataSource = this.itemBindingSource;
            this.dgvLoot.Location = new System.Drawing.Point(11, 181);
            this.dgvLoot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLoot.MultiSelect = false;
            this.dgvLoot.Name = "dgvLoot";
            this.dgvLoot.RowHeadersWidth = 51;
            this.dgvLoot.RowTemplate.Height = 24;
            this.dgvLoot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoot.Size = new System.Drawing.Size(623, 354);
            this.dgvLoot.TabIndex = 11;
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            this.displayNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
            this.displayNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.displayNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            this.displayNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Rarity
            // 
            this.Rarity.DataPropertyName = "RarityName";
            this.Rarity.HeaderText = "Rarity";
            this.Rarity.MinimumWidth = 6;
            this.Rarity.Name = "Rarity";
            this.Rarity.ReadOnly = true;
            this.Rarity.Width = 125;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            // 
            // Notes
            // 
            this.Notes.DataPropertyName = "Notes";
            this.Notes.HeaderText = "Notes";
            this.Notes.MinimumWidth = 6;
            this.Notes.Name = "Notes";
            this.Notes.Width = 125;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(RollProject.Models.Item);
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(511, 15);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(105, 32);
            this.btnRoll.TabIndex = 14;
            this.btnRoll.Text = "Roll!";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Potions:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Wands:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 107);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Weapon Oils:";
            // 
            // txtPotions
            // 
            this.txtPotions.Location = new System.Drawing.Point(369, 59);
            this.txtPotions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPotions.Name = "txtPotions";
            this.txtPotions.Size = new System.Drawing.Size(36, 20);
            this.txtPotions.TabIndex = 11;
            this.txtPotions.Text = "0";
            this.txtPotions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWands
            // 
            this.txtWands.Location = new System.Drawing.Point(369, 81);
            this.txtWands.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWands.Name = "txtWands";
            this.txtWands.Size = new System.Drawing.Size(36, 20);
            this.txtWands.TabIndex = 12;
            this.txtWands.Text = "0";
            this.txtWands.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOils
            // 
            this.txtOils.Location = new System.Drawing.Point(369, 104);
            this.txtOils.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOils.Name = "txtOils";
            this.txtOils.Size = new System.Drawing.Size(36, 20);
            this.txtOils.TabIndex = 13;
            this.txtOils.Text = "0";
            this.txtOils.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(511, 52);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 32);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Enabled = false;
            this.btnReplace.Location = new System.Drawing.Point(511, 90);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(105, 34);
            this.btnReplace.TabIndex = 20;
            this.btnReplace.Text = "Replace Selection";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // rarityBindingSource
            // 
            this.rarityBindingSource.DataSource = typeof(RollProject.Models.Rarity);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(511, 129);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 32);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // LootGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 546);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtOils);
            this.Controls.Add(this.txtWands);
            this.Controls.Add(this.txtPotions);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.dgvLoot);
            this.Controls.Add(this.txtLegendary);
            this.Controls.Add(this.txtRare);
            this.Controls.Add(this.txtVeryRare);
            this.Controls.Add(this.txtUncommon);
            this.Controls.Add(this.txtCommon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LootGenerator";
            this.Text = "LootGenerator";
            this.Load += new System.EventHandler(this.LootGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rarityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCommon;
        private System.Windows.Forms.TextBox txtUncommon;
        private System.Windows.Forms.TextBox txtVeryRare;
        private System.Windows.Forms.TextBox txtRare;
        private System.Windows.Forms.TextBox txtLegendary;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.BindingSource rarityBindingSource;
        private System.Windows.Forms.DataGridView dgvLoot;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPotions;
        private System.Windows.Forms.TextBox txtWands;
        private System.Windows.Forms.TextBox txtOils;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rarity;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}

