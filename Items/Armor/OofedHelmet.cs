using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace UltWedZit.Items.Armor
{
    
    [AutoloadEquip(EquipType.Head)]
    public class OofedHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Oofed Helmet");
			Tooltip.SetDefault("Boosts melee and magic damage.");
		}
		public override void SetDefaults()
		{
			item.width = 11;
			item.height = 10;
			item.defense = 16;
			item.value = 00010000;
			item.rare = 2;			
		}
        /* public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == mod.ItemType("ExampleBreastplate") && legs.type == mod.ItemType("ExampleLeggings");
		} */
        
        public override void UpdateArmorSet(Player player) {
			player.meleeDamage *= 2.1f;
			player.magicDamage *= 2.1f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe3 = new ModRecipe(mod);
            recipe3.AddIngredient(ItemID.DirtBlock);    
			recipe3.SetResult(this);
			recipe3.AddRecipe();
		}
	}
}
