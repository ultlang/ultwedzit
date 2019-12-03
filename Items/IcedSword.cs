using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace UltWedZit.Items
{
	public class IcedSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iced Metal Sword");
			Tooltip.SetDefault("Yeeeeeeeeeet~ \n Can inflict Frostburn");
		}
		public override void SetDefaults()
		{
			item.damage = 40;
			item.melee = true;
			item.width = 44;
			item.height = 44;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 15.6f;
			item.value = 00032000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
			target.AddBuff(BuffID.Frostburn, 90);
        }
        

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.IceBlock, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            
            ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.LeadBar, 10);
            recipe2.AddIngredient(ItemID.IceBlock, 5);
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(this);
			recipe2.AddRecipe();
            
            ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(ItemID.DirtBlock);    
			recipe3.SetResult(this);
			recipe3.AddRecipe();
		}
	}
}
