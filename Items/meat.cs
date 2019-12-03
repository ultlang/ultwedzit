using Terraria.ID;
using Terraria.ModLoader;

namespace ultwedzit.Items
{
	public class meat : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("meat");
			Tooltip.SetDefault("it feels... wierd...");
		}
		public override void SetDefaults()
		{
			item.damage = 900;
			item.melee = true;
			item.width = 700;
			item.height = 40;
			item.useTime = 1;
			item.useAnimation = 9;
			item.useStyle = 1;
			item.knockBack = 0f;
			item.value = 10000;
			item.rare = -12;
			item.UseSound = SoundID.Item16;
			item.autoReuse = true;
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
