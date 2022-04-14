
namespace LootGenerator
{
    partial class InventoryGenerator
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
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpMagicItems = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCommonItem = new System.Windows.Forms.TextBox();
            this.txtUncommonItem = new System.Windows.Forms.TextBox();
            this.txtVeryRareItem = new System.Windows.Forms.TextBox();
            this.txtRareItem = new System.Windows.Forms.TextBox();
            this.txtLegendaryItem = new System.Windows.Forms.TextBox();
            this.grpPotions = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCommonPotion = new System.Windows.Forms.TextBox();
            this.txtUncommonPotion = new System.Windows.Forms.TextBox();
            this.txtVeryRarePotion = new System.Windows.Forms.TextBox();
            this.txtRarePotion = new System.Windows.Forms.TextBox();
            this.txtLegendaryPotion = new System.Windows.Forms.TextBox();
            this.grpOil = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtOil = new System.Windows.Forms.TextBox();
            this.grpWand = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCommonWand = new System.Windows.Forms.TextBox();
            this.txtUncommonWand = new System.Windows.Forms.TextBox();
            this.txtVeryRareWand = new System.Windows.Forms.TextBox();
            this.txtRareWand = new System.Windows.Forms.TextBox();
            this.txtLegendaryWand = new System.Windows.Forms.TextBox();
            this.grpArrow = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtUncommonArrow = new System.Windows.Forms.TextBox();
            this.txtVeryRareArrow = new System.Windows.Forms.TextBox();
            this.txtRareArrow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.grpMagicItems.SuspendLayout();
            this.grpPotions.SuspendLayout();
            this.grpOil.SuspendLayout();
            this.grpWand.SuspendLayout();
            this.grpArrow.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(RollProject.Models.Item);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AutoGenerateColumns = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvInventory.DataSource = this.itemBindingSource;
            this.dgvInventory.Location = new System.Drawing.Point(23, 249);
            this.dgvInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(691, 288);
            this.dgvInventory.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "DisplayName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RarityName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Rarity";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Source";
            this.dataGridViewTextBoxColumn7.HeaderText = "Source";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn8.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(121, 199);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(78, 37);
            this.btnGenerate.TabIndex = 38;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(385, 199);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(99, 37);
            this.btnReplace.TabIndex = 39;
            this.btnReplace.Text = "Replace Selected";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(543, 199);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 37);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(254, 199);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 37);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpMagicItems
            // 
            this.grpMagicItems.Controls.Add(this.txtLegendaryItem);
            this.grpMagicItems.Controls.Add(this.txtRareItem);
            this.grpMagicItems.Controls.Add(this.txtVeryRareItem);
            this.grpMagicItems.Controls.Add(this.txtUncommonItem);
            this.grpMagicItems.Controls.Add(this.txtCommonItem);
            this.grpMagicItems.Controls.Add(this.label6);
            this.grpMagicItems.Controls.Add(this.label5);
            this.grpMagicItems.Controls.Add(this.label4);
            this.grpMagicItems.Controls.Add(this.label3);
            this.grpMagicItems.Controls.Add(this.label2);
            this.grpMagicItems.Location = new System.Drawing.Point(23, 27);
            this.grpMagicItems.Margin = new System.Windows.Forms.Padding(2);
            this.grpMagicItems.Name = "grpMagicItems";
            this.grpMagicItems.Padding = new System.Windows.Forms.Padding(2);
            this.grpMagicItems.Size = new System.Drawing.Size(134, 148);
            this.grpMagicItems.TabIndex = 0;
            this.grpMagicItems.TabStop = false;
            this.grpMagicItems.Text = "Magic Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Common:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Uncommon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rare:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Very Rare:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Legendary:";
            // 
            // txtCommonItem
            // 
            this.txtCommonItem.Location = new System.Drawing.Point(80, 27);
            this.txtCommonItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommonItem.Name = "txtCommonItem";
            this.txtCommonItem.Size = new System.Drawing.Size(36, 20);
            this.txtCommonItem.TabIndex = 0;
            this.txtCommonItem.Text = "0";
            this.txtCommonItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUncommonItem
            // 
            this.txtUncommonItem.Location = new System.Drawing.Point(80, 48);
            this.txtUncommonItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtUncommonItem.Name = "txtUncommonItem";
            this.txtUncommonItem.Size = new System.Drawing.Size(36, 20);
            this.txtUncommonItem.TabIndex = 1;
            this.txtUncommonItem.Text = "0";
            this.txtUncommonItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVeryRareItem
            // 
            this.txtVeryRareItem.Location = new System.Drawing.Point(80, 90);
            this.txtVeryRareItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtVeryRareItem.Name = "txtVeryRareItem";
            this.txtVeryRareItem.Size = new System.Drawing.Size(36, 20);
            this.txtVeryRareItem.TabIndex = 3;
            this.txtVeryRareItem.Text = "0";
            this.txtVeryRareItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRareItem
            // 
            this.txtRareItem.Location = new System.Drawing.Point(80, 69);
            this.txtRareItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtRareItem.Name = "txtRareItem";
            this.txtRareItem.Size = new System.Drawing.Size(36, 20);
            this.txtRareItem.TabIndex = 2;
            this.txtRareItem.Text = "0";
            this.txtRareItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLegendaryItem
            // 
            this.txtLegendaryItem.Location = new System.Drawing.Point(80, 111);
            this.txtLegendaryItem.Margin = new System.Windows.Forms.Padding(2);
            this.txtLegendaryItem.Name = "txtLegendaryItem";
            this.txtLegendaryItem.Size = new System.Drawing.Size(36, 20);
            this.txtLegendaryItem.TabIndex = 4;
            this.txtLegendaryItem.Text = "0";
            this.txtLegendaryItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpPotions
            // 
            this.grpPotions.Controls.Add(this.txtLegendaryPotion);
            this.grpPotions.Controls.Add(this.txtRarePotion);
            this.grpPotions.Controls.Add(this.txtVeryRarePotion);
            this.grpPotions.Controls.Add(this.txtUncommonPotion);
            this.grpPotions.Controls.Add(this.txtCommonPotion);
            this.grpPotions.Controls.Add(this.label1);
            this.grpPotions.Controls.Add(this.label7);
            this.grpPotions.Controls.Add(this.label8);
            this.grpPotions.Controls.Add(this.label9);
            this.grpPotions.Controls.Add(this.label10);
            this.grpPotions.Location = new System.Drawing.Point(161, 27);
            this.grpPotions.Margin = new System.Windows.Forms.Padding(2);
            this.grpPotions.Name = "grpPotions";
            this.grpPotions.Padding = new System.Windows.Forms.Padding(2);
            this.grpPotions.Size = new System.Drawing.Size(133, 148);
            this.grpPotions.TabIndex = 1;
            this.grpPotions.TabStop = false;
            this.grpPotions.Text = "Potions";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Common:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Uncommon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Rare:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Very Rare:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Legendary:";
            // 
            // txtCommonPotion
            // 
            this.txtCommonPotion.Location = new System.Drawing.Point(78, 20);
            this.txtCommonPotion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommonPotion.Name = "txtCommonPotion";
            this.txtCommonPotion.Size = new System.Drawing.Size(36, 20);
            this.txtCommonPotion.TabIndex = 0;
            this.txtCommonPotion.Text = "0";
            this.txtCommonPotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUncommonPotion
            // 
            this.txtUncommonPotion.Location = new System.Drawing.Point(78, 41);
            this.txtUncommonPotion.Margin = new System.Windows.Forms.Padding(2);
            this.txtUncommonPotion.Name = "txtUncommonPotion";
            this.txtUncommonPotion.Size = new System.Drawing.Size(36, 20);
            this.txtUncommonPotion.TabIndex = 1;
            this.txtUncommonPotion.Text = "0";
            this.txtUncommonPotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVeryRarePotion
            // 
            this.txtVeryRarePotion.Location = new System.Drawing.Point(78, 84);
            this.txtVeryRarePotion.Margin = new System.Windows.Forms.Padding(2);
            this.txtVeryRarePotion.Name = "txtVeryRarePotion";
            this.txtVeryRarePotion.Size = new System.Drawing.Size(36, 20);
            this.txtVeryRarePotion.TabIndex = 3;
            this.txtVeryRarePotion.Text = "0";
            this.txtVeryRarePotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRarePotion
            // 
            this.txtRarePotion.Location = new System.Drawing.Point(78, 63);
            this.txtRarePotion.Margin = new System.Windows.Forms.Padding(2);
            this.txtRarePotion.Name = "txtRarePotion";
            this.txtRarePotion.Size = new System.Drawing.Size(36, 20);
            this.txtRarePotion.TabIndex = 2;
            this.txtRarePotion.Text = "0";
            this.txtRarePotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLegendaryPotion
            // 
            this.txtLegendaryPotion.Location = new System.Drawing.Point(78, 105);
            this.txtLegendaryPotion.Margin = new System.Windows.Forms.Padding(2);
            this.txtLegendaryPotion.Name = "txtLegendaryPotion";
            this.txtLegendaryPotion.Size = new System.Drawing.Size(36, 20);
            this.txtLegendaryPotion.TabIndex = 4;
            this.txtLegendaryPotion.Text = "0";
            this.txtLegendaryPotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpOil
            // 
            this.grpOil.Controls.Add(this.txtOil);
            this.grpOil.Controls.Add(this.label14);
            this.grpOil.Location = new System.Drawing.Point(306, 27);
            this.grpOil.Margin = new System.Windows.Forms.Padding(2);
            this.grpOil.Name = "grpOil";
            this.grpOil.Padding = new System.Windows.Forms.Padding(2);
            this.grpOil.Size = new System.Drawing.Size(134, 148);
            this.grpOil.TabIndex = 2;
            this.grpOil.TabStop = false;
            this.grpOil.Text = "Oils";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 65);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Uncommon:";
            // 
            // txtOil
            // 
            this.txtOil.Location = new System.Drawing.Point(79, 63);
            this.txtOil.Margin = new System.Windows.Forms.Padding(2);
            this.txtOil.Name = "txtOil";
            this.txtOil.Size = new System.Drawing.Size(36, 20);
            this.txtOil.TabIndex = 0;
            this.txtOil.Text = "0";
            this.txtOil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpWand
            // 
            this.grpWand.Controls.Add(this.txtLegendaryWand);
            this.grpWand.Controls.Add(this.txtRareWand);
            this.grpWand.Controls.Add(this.txtVeryRareWand);
            this.grpWand.Controls.Add(this.txtUncommonWand);
            this.grpWand.Controls.Add(this.txtCommonWand);
            this.grpWand.Controls.Add(this.label16);
            this.grpWand.Controls.Add(this.label17);
            this.grpWand.Controls.Add(this.label18);
            this.grpWand.Controls.Add(this.label19);
            this.grpWand.Controls.Add(this.label20);
            this.grpWand.Location = new System.Drawing.Point(581, 27);
            this.grpWand.Margin = new System.Windows.Forms.Padding(2);
            this.grpWand.Name = "grpWand";
            this.grpWand.Padding = new System.Windows.Forms.Padding(2);
            this.grpWand.Size = new System.Drawing.Size(133, 148);
            this.grpWand.TabIndex = 4;
            this.grpWand.TabStop = false;
            this.grpWand.Text = "Wands";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(23, 23);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Common:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 44);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Uncommon:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 65);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Rare:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 86);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Very Rare:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 107);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Legendary:";
            // 
            // txtCommonWand
            // 
            this.txtCommonWand.Location = new System.Drawing.Point(78, 20);
            this.txtCommonWand.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommonWand.Name = "txtCommonWand";
            this.txtCommonWand.Size = new System.Drawing.Size(36, 20);
            this.txtCommonWand.TabIndex = 0;
            this.txtCommonWand.Text = "0";
            this.txtCommonWand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUncommonWand
            // 
            this.txtUncommonWand.Location = new System.Drawing.Point(78, 41);
            this.txtUncommonWand.Margin = new System.Windows.Forms.Padding(2);
            this.txtUncommonWand.Name = "txtUncommonWand";
            this.txtUncommonWand.Size = new System.Drawing.Size(36, 20);
            this.txtUncommonWand.TabIndex = 1;
            this.txtUncommonWand.Text = "0";
            this.txtUncommonWand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVeryRareWand
            // 
            this.txtVeryRareWand.Location = new System.Drawing.Point(78, 84);
            this.txtVeryRareWand.Margin = new System.Windows.Forms.Padding(2);
            this.txtVeryRareWand.Name = "txtVeryRareWand";
            this.txtVeryRareWand.Size = new System.Drawing.Size(36, 20);
            this.txtVeryRareWand.TabIndex = 3;
            this.txtVeryRareWand.Text = "0";
            this.txtVeryRareWand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRareWand
            // 
            this.txtRareWand.Location = new System.Drawing.Point(78, 63);
            this.txtRareWand.Margin = new System.Windows.Forms.Padding(2);
            this.txtRareWand.Name = "txtRareWand";
            this.txtRareWand.Size = new System.Drawing.Size(36, 20);
            this.txtRareWand.TabIndex = 2;
            this.txtRareWand.Text = "0";
            this.txtRareWand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLegendaryWand
            // 
            this.txtLegendaryWand.Location = new System.Drawing.Point(78, 105);
            this.txtLegendaryWand.Margin = new System.Windows.Forms.Padding(2);
            this.txtLegendaryWand.Name = "txtLegendaryWand";
            this.txtLegendaryWand.Size = new System.Drawing.Size(36, 20);
            this.txtLegendaryWand.TabIndex = 4;
            this.txtLegendaryWand.Text = "0";
            this.txtLegendaryWand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpArrow
            // 
            this.grpArrow.Controls.Add(this.txtRareArrow);
            this.grpArrow.Controls.Add(this.txtVeryRareArrow);
            this.grpArrow.Controls.Add(this.txtUncommonArrow);
            this.grpArrow.Controls.Add(this.label22);
            this.grpArrow.Controls.Add(this.label23);
            this.grpArrow.Controls.Add(this.label24);
            this.grpArrow.Location = new System.Drawing.Point(444, 27);
            this.grpArrow.Margin = new System.Windows.Forms.Padding(2);
            this.grpArrow.Name = "grpArrow";
            this.grpArrow.Padding = new System.Windows.Forms.Padding(2);
            this.grpArrow.Size = new System.Drawing.Size(133, 148);
            this.grpArrow.TabIndex = 3;
            this.grpArrow.TabStop = false;
            this.grpArrow.Text = "Arrows";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(12, 44);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "Uncommon:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(41, 65);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "Rare:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 86);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 25;
            this.label22.Text = "Very Rare:";
            // 
            // txtUncommonArrow
            // 
            this.txtUncommonArrow.Location = new System.Drawing.Point(78, 41);
            this.txtUncommonArrow.Margin = new System.Windows.Forms.Padding(2);
            this.txtUncommonArrow.Name = "txtUncommonArrow";
            this.txtUncommonArrow.Size = new System.Drawing.Size(36, 20);
            this.txtUncommonArrow.TabIndex = 0;
            this.txtUncommonArrow.Text = "0";
            this.txtUncommonArrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVeryRareArrow
            // 
            this.txtVeryRareArrow.Location = new System.Drawing.Point(78, 84);
            this.txtVeryRareArrow.Margin = new System.Windows.Forms.Padding(2);
            this.txtVeryRareArrow.Name = "txtVeryRareArrow";
            this.txtVeryRareArrow.Size = new System.Drawing.Size(36, 20);
            this.txtVeryRareArrow.TabIndex = 2;
            this.txtVeryRareArrow.Text = "0";
            this.txtVeryRareArrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRareArrow
            // 
            this.txtRareArrow.Location = new System.Drawing.Point(78, 63);
            this.txtRareArrow.Margin = new System.Windows.Forms.Padding(2);
            this.txtRareArrow.Name = "txtRareArrow";
            this.txtRareArrow.Size = new System.Drawing.Size(36, 20);
            this.txtRareArrow.TabIndex = 1;
            this.txtRareArrow.Text = "0";
            this.txtRareArrow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InventoryGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 548);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.grpArrow);
            this.Controls.Add(this.grpWand);
            this.Controls.Add(this.grpOil);
            this.Controls.Add(this.grpPotions);
            this.Controls.Add(this.grpMagicItems);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InventoryGenerator";
            this.Text = "Inventory Generator";
            this.Load += new System.EventHandler(this.InventoryGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.grpMagicItems.ResumeLayout(false);
            this.grpMagicItems.PerformLayout();
            this.grpPotions.ResumeLayout(false);
            this.grpPotions.PerformLayout();
            this.grpOil.ResumeLayout(false);
            this.grpOil.PerformLayout();
            this.grpWand.ResumeLayout(false);
            this.grpWand.PerformLayout();
            this.grpArrow.ResumeLayout(false);
            this.grpArrow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpMagicItems;
        private System.Windows.Forms.TextBox txtLegendaryItem;
        private System.Windows.Forms.TextBox txtRareItem;
        private System.Windows.Forms.TextBox txtVeryRareItem;
        private System.Windows.Forms.TextBox txtUncommonItem;
        private System.Windows.Forms.TextBox txtCommonItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPotions;
        private System.Windows.Forms.TextBox txtLegendaryPotion;
        private System.Windows.Forms.TextBox txtRarePotion;
        private System.Windows.Forms.TextBox txtVeryRarePotion;
        private System.Windows.Forms.TextBox txtUncommonPotion;
        private System.Windows.Forms.TextBox txtCommonPotion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpOil;
        private System.Windows.Forms.TextBox txtOil;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox grpWand;
        private System.Windows.Forms.TextBox txtLegendaryWand;
        private System.Windows.Forms.TextBox txtRareWand;
        private System.Windows.Forms.TextBox txtVeryRareWand;
        private System.Windows.Forms.TextBox txtUncommonWand;
        private System.Windows.Forms.TextBox txtCommonWand;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox grpArrow;
        private System.Windows.Forms.TextBox txtRareArrow;
        private System.Windows.Forms.TextBox txtVeryRareArrow;
        private System.Windows.Forms.TextBox txtUncommonArrow;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}