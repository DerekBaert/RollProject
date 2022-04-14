using RollProject.Data;
using RollProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollUtilities
{
    public static class TableRoll
    {
        private static Random die = new Random();
        private static RollProjectContext db = new RollProjectContext();

        public static Item Roll(string rarity, string type)
        {
            Item result = null;

            switch (type)
            {
                case "Magic Item":
                    #region Magic Item
                    List<MagicItem> table = db.MagicItems.Where(x => x.Rarity.Name.Equals(rarity)).ToList();

                    result = table[die.Next(0, table.Count() - 1)];

                    switch (result.Name)
                    {
                        case "Magic Arrow":
                            List<Arrow> arrows = db.Arrows.Where(x => x.Rarity.Name.Equals(rarity)).ToList();

                            result = arrows[die.Next(0, arrows.Count - 1)];
                            break;

                        case "Weapon Oil":
                            List<WeaponOil> oils = db.WeaponOils.Where(x => x.Rarity.Name.Equals(rarity)).ToList();

                            result = oils[die.Next(0, oils.Count - 1)];
                            break;

                        case "Potion":
                            List<Potion> potions = db.Potions.Where(x => x.Rarity.Name.Equals(rarity)).ToList();

                            result = potions[die.Next(0, potions.Count - 1)];
                            break;

                        case "Figurine":
                            List<Figurine> figurines = db.Figurines.Where(x => x.Rarity.Name.Equals(rarity)).ToList();

                            result = figurines[die.Next(0, figurines.Count - 1)];
                            break;

                        case "Ioun Stone":
                            List<IounStone> stones = db.IounStones.Where(x => x.Rarity.Name.Equals(rarity)).ToList();

                            result = stones[die.Next(0, stones.Count - 1)];
                            break;

                        case "Wand":
                            List<Wand> wands = db.Wands.Where(x => x.Rarity.Name.Equals(rarity)).ToList();

                            result = wands[die.Next(0, wands.Count - 1)];
                            break;

                        default:
                            break;
                    }
                    #endregion
                    break;
                case "Arrow":
                    List<Arrow> arrowTable = db.Arrows.Where(x => x.Rarity.Name.Equals(rarity)).ToList();

                    result = arrowTable[die.Next(0, arrowTable.Count - 1)];
                    break;
                case "Weapon Oil":
                    List<WeaponOil> oilTable = db.WeaponOils.Where(x => x.Rarity.Name.Equals(rarity)).ToList();

                    result = oilTable[die.Next(0, oilTable.Count - 1)];
                    break;

                case "Potion":
                    List<Potion> potionTable = db.Potions.Where(x => x.Rarity.Name.Equals(rarity)).ToList();

                    result = potionTable[die.Next(0, potionTable.Count - 1)];
                    break;

                case "Figurine":
                    List<Figurine> figurineTable = db.Figurines.Where(x => x.Rarity.Name.Equals(rarity)).ToList();

                    result = figurineTable[die.Next(0, figurineTable.Count - 1)];
                    break;

                case "Ioun Stone":
                    List<IounStone> stoneTable = db.IounStones.Where(x => x.Rarity.Name.Equals(rarity)).ToList();

                    result = stoneTable[die.Next(0, stoneTable.Count - 1)];
                    break;

                case "Wand":
                    List<Wand> wandTable = db.Wands.Where(x => x.Rarity.Name.Equals(rarity)).ToList();

                    result = wandTable[die.Next(0, wandTable.Count - 1)];
                    break;
            }
            return (Item)result;
        }
    }
}
