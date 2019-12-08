using Terraria.ID;
using Terraria.ModLoader;

namespace UltWedZit.Items.Placeable
{
    public class OniteOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
            DisplayName.SetDefault("Onite Ore");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.maxStack = 999;
            item.consumable = true;
            item.createTile = mod.TileType("OniteOreTile");
            item.width = 12;
            item.height = 12;
            item.value = 3000;
        }
    }
}