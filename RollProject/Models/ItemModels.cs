using RollProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RollProject.Models
{
    /// <summary>
    /// Item to be rolled for
    /// </summary>
    public abstract class Item
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ItemId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public virtual string Type 
        { 
            get
            {
                return this.GetType().Name.Split('_')[0];
            }
        }

        [Required]
        public virtual string DisplayName
        {
            get
            {
                return this.Name;
            }
        }

        [Required]
        [ForeignKey("Rarity")]
        public int RarityId { get; set; }

        [Required]
        public string RarityName
        {
            get
            {
                return this.Rarity.Name;
            }
        }

        [Required]
        public string Source { get; set; }

        public string Notes { get; set; }

        public virtual Rarity Rarity { get; set; }
    }

    #region Item Subtypes
    /// <summary>
    /// Standard Magic Item
    /// </summary>
    public class MagicItem : Item
    {
        public override string Type
        {
            get
            {
                return "Magic Item";
            }
        }
    }

    /// <summary>
    /// Potion Item Subtype
    /// </summary>
    public class Potion : Item
    {
        public override string DisplayName
        {
            get
            {
                return String.Format("{0} of {1}", "Potion", this.Name);
            }
        }
    }

    /// <summary>
    /// Wand Item Subtype
    /// </summary>
    public class Wand : Item
    {
        public override string DisplayName
        {
            get
            {
                return String.Format("{0} of {1}", "Wand", this.Name);
            }
        }
    }

    /// <summary>
    /// Arrow Item Subtype
    /// </summary>
    public class Arrow : Item
    {
        public override string DisplayName
        {
            get
            {
                return String.Format("{1} {0}s", "Arrow", this.Name);
            }
        }
    }

    /// <summary>
    /// IounStone Item Subtype
    /// </summary>
    public class IounStone : Item
    {
        public override string Type
        {
            get
            {
                return "Ioun Stone";
            }
        }

        public override string DisplayName
        {
            get
            {
                return String.Format("{0} of {1}", "Ioun Stone", this.Name);
            }
        }
    }

    /// <summary>
    /// Oil Item Subtype
    /// </summary>
    public class WeaponOil : Item
    {
        public override string Type
        {
            get
            {
                return "Weapon Oil";
            }
        }

        public override string DisplayName
        {
            get
            {
                return String.Format("{1} {0}", "Weapon Oil", this.Name);
            }
        }
    }

    public class Figurine : Item { }

    #endregion

    /// <summary>
    /// Rarity of an item.
    /// </summary>
    public abstract class Rarity
    {
        protected static RollProjectContext db = new RollProjectContext();

        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int RarityId { get; set; }

        public string Name { get; set; }

        public virtual string Type 
        { 
            get 
            {
                return this.GetType().Name;
            } 
        }

        public virtual ICollection<Item> Item { get; set; }
    }

    #region Rarity Types
    public class Common : Rarity 
    {
        private static Common common;

        private Common()
        {
            this.Name = "Common";
        }

        public static Common GetInstance()
        {
            if (common == null)
            {
                common = db.Commons.SingleOrDefault();

                if (common == null)
                {
                    common = new Common();
                    db.Commons.Add(common);
                    db.SaveChanges();
                }
            }

            return common;
        }
    }

    public class Uncommon : Rarity 
    {
        private static Uncommon uncommon;

        private Uncommon()
        {
            this.Name = "Uncommon";
        }

        public static Uncommon GetInstance()
        {
            if (uncommon == null)
            {
                uncommon = db.Uncommons.SingleOrDefault();

                if (uncommon == null)
                {
                    uncommon = new Uncommon();
                    db.Uncommons.Add(uncommon);
                    db.SaveChanges();
                }
            }

            return uncommon;
        }
    }

    public class Rare : Rarity 
    {
        private static Rare rare;

        private Rare()
        {
            this.Name = "Rare";
        }

        public static Rare GetInstance()
        {
            if (rare == null)
            {
                rare = db.Rares.SingleOrDefault();

                if (rare == null)
                {
                    rare = new Rare();
                    db.Rares.Add(rare);
                    db.SaveChanges();
                }
            }

            return rare;
        }
    }

    public class VeryRare : Rarity     
    {
        private static VeryRare veryRare;

        private VeryRare()
        {
            this.Name = "Very Rare";
        }
        public override string Type
        {
            get
            {
                return "Very Rare";
            }
        }

        public static VeryRare GetInstance()
        {
            if (veryRare == null)
            {
                veryRare = db.VeryRares.SingleOrDefault();

                if (veryRare == null)
                {
                    veryRare = new VeryRare();
                    db.VeryRares.Add(veryRare);
                    db.SaveChanges();
                }
            }

            return veryRare;
        }
    }

    public class Legendary : Rarity 
    {
        private static Legendary legendary;

        private Legendary()
        {
            this.Name = "Legendary";
        }

        public static Legendary GetInstance()
        {
            if (legendary == null)
            {
                legendary = db.Legendaries.SingleOrDefault();

                if (legendary == null)
                {
                    legendary = new Legendary();
                    db.Legendaries.Add(legendary);
                    db.SaveChanges();
                }
            }

            return legendary;
        }
    }
    #endregion
}

