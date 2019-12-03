using Terraria.ID;
using Terraria.ModLoader;

namespace ultwedzit.Items
{
	public class bulet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("bulet");
			Tooltip.SetDefault("ez");
		}
		public override void SetDefaults()
		{
            item.damage = 10;
			item.width = 8;
			item.height = 8;
			item.useTime = 7;
            item.useAnimation = 7;
            item.consumable = true;   
			item.maxStack = 999;
			item.knockBack = 1f;
			item.value = 10;
			item.rare = 5;
			item.shoot = 206;
			item.shoot = mod.ProjectileType("bulet");
            item.shootSpeed = 16;
            item.autoReuse = true;
            item.ammo = ProjectileID.Bullet;
			item.ammo = AmmoID.Bullet;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 30);
			recipe.AddRecipe();
		}
	}
}
