using RollProject.Data;
using RollProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RollUtilities;
using System.IO;
using System.Diagnostics;

namespace LootGenerator
{
    public partial class InventoryGenerator : Form
    {
        private RollProjectContext db = new RollProjectContext();
        private Random die = new Random();
        private List<Item> inventory = new List<Item>();

        public InventoryGenerator()
        {
            InitializeComponent();
        }

        private void InventoryGenerator_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnReplace.Enabled = false;
            dgvInventory.SelectionChanged += DgvInventory_SelectionChanged;
        }

        private void DgvInventory_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventory.SelectedRows.Count == 0)
            {
                btnReplace.Enabled = false;
            }
            else
            {
                btnReplace.Enabled = true;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            dgvInventory.DataSource = null;

            // Magic Items
            Dictionary<string, int> magicItems = new Dictionary<string, int>();

            magicItems.Add("Common", int.Parse(txtCommonItem.Text));
            magicItems.Add("Uncommon", int.Parse(txtUncommonItem.Text));
            magicItems.Add("Rare", int.Parse(txtRareItem.Text));
            magicItems.Add("Very Rare", int.Parse(txtVeryRareItem.Text));
            magicItems.Add("Legendary", int.Parse(txtLegendaryItem.Text));

            foreach (KeyValuePair<string, int> entry in magicItems)
            {
                if (entry.Value != 0)
                {
                    for (int i = 0; i < entry.Value; i++)
                    {
                        inventory.Add(TableRoll.Roll(entry.Key, "Magic Item"));
                    }                    
                }
            }

            // Potions
            Dictionary<string, int> potions = new Dictionary<string, int>();

            potions.Add("Common", int.Parse(txtCommonPotion.Text));
            potions.Add("Uncommon", int.Parse(txtUncommonPotion.Text));
            potions.Add("Rare", int.Parse(txtRarePotion.Text));
            potions.Add("Very Rare", int.Parse(txtVeryRarePotion.Text));
            potions.Add("Legendary", int.Parse(txtLegendaryPotion.Text));

            foreach (KeyValuePair<string, int> entry in potions)
            {
                if (entry.Value != 0)
                {
                    for (int i = 0; i < entry.Value; i++)
                    {
                        inventory.Add(TableRoll.Roll(entry.Key, "Potion"));
                    }
                }
            }

            // Oils
            int oils = int.Parse(txtOil.Text);
            if(oils != 0)
            {
                inventory.Add(TableRoll.Roll("Uncommon", "Weapon Oil"));
            }

            // Arrows
            Dictionary<string, int> arrows = new Dictionary<string, int>();

            arrows.Add("Uncommon", int.Parse(txtUncommonArrow.Text));
            arrows.Add("Rare", int.Parse(txtRareArrow.Text));
            arrows.Add("Very Rare", int.Parse(txtVeryRareArrow.Text));

            foreach (KeyValuePair<string, int> entry in arrows)
            {
                if (entry.Value != 0)
                {
                    for (int i = 0; i < entry.Value; i++)
                    {
                        inventory.Add(TableRoll.Roll(entry.Key, "Arrow"));
                    }
                }
            }

            // Wands
            Dictionary<string, int> wands = new Dictionary<string, int>();

            wands.Add("Common", int.Parse(txtCommonWand.Text));
            wands.Add("Uncommon", int.Parse(txtUncommonWand.Text));
            wands.Add("Rare", int.Parse(txtRareWand.Text));
            wands.Add("Very Rare", int.Parse(txtVeryRareWand.Text));
            wands.Add("Legendary", int.Parse(txtLegendaryWand.Text));

            foreach (KeyValuePair<string, int> entry in wands)
            {
                if (entry.Value != 0)
                {
                    for (int i = 0; i < entry.Value; i++)
                    {
                        inventory.Add(TableRoll.Roll(entry.Key, "Wand"));
                    }
                }
            }

            dgvInventory.DataSource = inventory;

            btnSave.Enabled = true;
            btnReplace.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType().ToString() == "System.Windows.Forms.GroupBox")
                {
                    foreach(Control t in c.Controls)
                    {
                        if(t is TextBox)
                        {
                            t.Text = "0";
                        }                        
                    }                    
                }
            }

            dgvInventory.DataSource = null;
            btnSave.Enabled = false;
            btnReplace.Enabled = false;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)dgvInventory.SelectedRows[0].DataBoundItem;

            string rarity = selectedItem.RarityName;

            Item newItem = TableRoll.Roll(rarity, selectedItem.Type);

            inventory[dgvInventory.CurrentCell.RowIndex] = newItem;

            dgvInventory.DataSource = null;

            dgvInventory.DataSource = inventory;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string lootData = string.Format("{0}{1}{2}Notes\n{3}\n",
                "Name".PadRight(40, ' '),
                "Rarity".PadRight(17, ' '),
                "Source".PadRight(22, ' '),
                string.Empty.PadRight(115, '-'));
            foreach (Item item in inventory)
            {
                string name = item.DisplayName.PadRight(40, ' ');
                string rarity = item.RarityName.PadRight(17, ' ');
                string source = item.Source.PadRight(22, ' ');
                string notes = item.Notes;
                lootData += name + rarity + source + notes + "\n";
            }
            lootData += string.Empty.PadRight(115, '-');

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.Write(lootData);
                    writer.Close();

                    Process.Start(saveFileDialog.FileName);
                }
            }
        }
    }
}
