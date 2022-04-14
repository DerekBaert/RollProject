using RollProject.Data;
using RollProject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq.Dynamic.Core;
using RollUtilities;

namespace LootGenerator
{
    public partial class LootGenerator : Form
    {
        private RollProjectContext db = new RollProjectContext();
        private Random die = new Random();
        private List<Item> loot;

        public LootGenerator()
        {
            InitializeComponent();
        }

        private void LootGenerator_Load(object sender, EventArgs e)
        {
            dgvLoot.SelectionChanged += DgvLoot_SelectionChanged;
            btnSave.Enabled = false;
            btnReplace.Enabled = false;
        }

        private void DgvLoot_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvLoot.SelectedRows.Count == 0)
            {
                btnReplace.Enabled = false;
            }
            else
            {
                btnReplace.Enabled = true;
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            dgvLoot.DataSource = null;
            loot = new List<Item>();

            Dictionary<string, int> items = new Dictionary<string, int>();

            items.Add("Common", int.Parse(txtCommon.Text));
            items.Add("Uncommon", int.Parse(txtUncommon.Text));
            items.Add("Rare", int.Parse(txtRare.Text));
            items.Add("Very Rare", int.Parse(txtVeryRare.Text));
            items.Add("Legendary", int.Parse(txtLegendary.Text));

            foreach (KeyValuePair<string, int> entry in items)
            {
                if (entry.Value != 0)
                {
                    for (int i = 0; i < entry.Value; i++)
                    {
                        loot.Add(TableRoll.Roll(entry.Key, "Magic Item"));
                    }
                }
            }           

            // Potions
            int potions = int.Parse(txtPotions.Text);

            if (potions != 0)
            {
                Random die = new Random();

                for (int i = 0; i < potions; i++)
                {
                    List<Potion> potionTable = db.Potions.ToList();

                    loot.Add(potionTable[die.Next(0, potionTable.Count - 1)]);

                }
            }

            // Wands
            int wands = int.Parse(txtWands.Text);
            
            if (wands != 0)
            {
                Random die = new Random();

                for (int i = 0; i < wands; i++)
                {
                    List<Wand> wandTable = db.Wands.ToList();

                    loot.Add(wandTable[die.Next(0, wandTable.Count - 1)]);
                }
            }

            // Oils
            int oils = int.Parse(txtOils.Text);

            if (oils != 0)
            {
                Random die = new Random();

                for (int i = 0; i < oils; i++)
                {
                    List<WeaponOil> oilTable = db.WeaponOils.ToList();

                    loot.Add(oilTable[die.Next(0, oilTable.Count - 1)]);
                }
            }

            dgvLoot.DataSource = loot;
            btnSave.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control t in this.Controls)
            {
                if (t is TextBox)
                {
                    t.Text = "0";
                }
            }

            dgvLoot.DataSource = null;
            btnSave.Enabled = false;
            btnReplace.Enabled = false;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)dgvLoot.SelectedRows[0].DataBoundItem;

            string rarity = selectedItem.RarityName;

            Item newItem = TableRoll.Roll(rarity, selectedItem.Type);

            loot[dgvLoot.CurrentCell.RowIndex] = newItem;

            dgvLoot.DataSource = null;

            dgvLoot.DataSource = loot;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string lootData = string.Format("{0}{1}{2}Notes\n{3}\n", 
                "Name".PadRight(40, ' '), 
                "Rarity".PadRight(17, ' '),
                "Source".PadRight(22, ' '),
                string.Empty.PadRight(115, '-'));
            foreach(Item item in loot)
            {
                string name = item.DisplayName.PadRight(40, ' ');
                string rarity = item.RarityName.PadRight(17, ' ');
                string source = item.Source.PadRight(22,' ');
                string notes = item.Notes;
                lootData += name +  rarity +  source + notes + "\n";
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
