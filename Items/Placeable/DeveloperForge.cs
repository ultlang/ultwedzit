using Terraria.ID;
using Terraria.ModLoader;

namespace UltWedZit.Items.Placeable
{
	public class DeveloperForge : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
            DisplayName.SetDefault("Developer's Forge");
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
			item.createTile = mod.TileType("DevForge");
            item.width = 2;
			item.height = 2;
			item.value = 3000;
		}
        public override void AddRecipes()
		{
        ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock);    
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
	}
}