using Terraria.ID;
using Terraria.ModLoader;

namespace ultwedzit.Items
{
	public class axityaxityaxyhey : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("axity axity axy hey!");
			Tooltip.SetDefault("I see trees of none...");
		}
		public override void SetDefaults()
		{
            item.melee = true;
			item.width = 50;
			item.height = 50;
			item.useTime = 1;
            item.useAnimation = 7;
            item.axe = 700;   
			item.useStyle = 1;
			item.knockBack = 6f;
			item.value = 100000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.useTurn = true;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(mod.GetTile("DevForge"));
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
