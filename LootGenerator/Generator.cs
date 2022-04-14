using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LootGenerator
{
    public partial class Generator : Form
    {
        public Generator()
        {
            InitializeComponent();
        }

        private void btnLoot_Click(object sender, EventArgs e)
        {
            LootGenerator lootGen = new LootGenerator();

            lootGen.Show();
        }

        private void mnuLoot_Click(object sender, EventArgs e)
        {
            LootGenerator lootGen = new LootGenerator();

            lootGen.Show();
        }

        private void mnuInventory_Click(object sender, EventArgs e)
        {
            InventoryGenerator inventoryGen = new InventoryGenerator();

            inventoryGen.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryGenerator inventoryGen = new InventoryGenerator();

            inventoryGen.Show();
        }
    }
}
