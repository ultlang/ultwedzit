using Terraria.ID;
using Terraria.ModLoader;

namespace ultwedzit.Items
{
	public class theforgotten : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("the forgotten");
			Tooltip.SetDefault("ancient technology of the first adventurers");
		}
		public override void SetDefaults()
		{
            item.noMelee = true;
            item.damage = 30;
            item.ranged = true;
			item.width = 256;
			item.height = 128;
			item.useTime = 7;
            item.useAnimation = 7;   
			item.useStyle = 5;
			item.knockBack = 1f;
			item.value = 100000;
			item.rare = 5;
			item.shoot = 206;
            item.UseSound = SoundID.Item33;
			item.shootSpeed = 16;
            item.autoReuse = true;
            item.useAmmo = AmmoID.Bullet;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
	    /*public override bool ConsumeAmmo(player player)
		{
			return Main.rand.NextFloat() >= .38f;
		}*/
    }
}
