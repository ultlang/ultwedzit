using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace UltWedZit
{
	class UltWedZit : Mod
	{
		public UltWedZit()
		{
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
            

            
		}

        public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Minishark);
			recipe.AddRecipe();
		}
	}
}
