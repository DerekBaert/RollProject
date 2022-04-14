using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RollProject.Data
{
    public class RollProjectContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public RollProjectContext() : base("name=RollProjectContext")
        {
        }

        public System.Data.Entity.DbSet<RollProject.Models.Arrow> Arrows { get; set; }

        public System.Data.Entity.DbSet<RollProject.Models.Item> Items { get; set; }

        public System.Data.Entity.DbSet<RollProject.Models.MagicItem> MagicItems { get; set; }

        public System.Data.Entity.DbSet<RollProject.Models.Rarity> Rarities { get; set; }

        public System.Data.Entity.DbSet<RollProject.Models.Common> Commons { get; set; }

        public System.Data.Entity.DbSet<RollProject.Models.Legendary> Legendaries { get; set; }

        public System.Data.Entity.DbSet<RollProject.Models.Figurine> Figurines { get; set; }

        public System.Data.Entity.DbSet<RollProject.Models.IounStone> IounStones { get; set; }

        public System.Data.Entity.DbSet<RollProject.Models.Potion> Potions { get; set; }

        public System.Data.Entity.DbSet<RollProject.Models.Rare> Rares { get; set; }

        public System.Data.Entity.DbSet<RollProject.Models.Uncommon> Uncommons { get; set; }

        public System.Data.Entity.DbSet<RollProject.Models.VeryRare> VeryRares { get; set; }

        public System.Data.Entity.DbSet<RollProject.Models.Wand> Wands { get; set; }

        public System.Data.Entity.DbSet<RollProject.Models.WeaponOil> WeaponOils { get; set; }
    }
}
