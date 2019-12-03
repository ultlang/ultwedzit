using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace UltWedZit.Tiles
{
	public class DevForge : ModTile
	{
		public override void SetDefaults()
		{
            adjTiles = new int[] { TileID.Furnaces };
			Main.tileLighted[Type] = true;    //so the tile emits light
			Main.tileShine[Type] = 1100;
			Main.tileSolid[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.Origin = new Point16(1, 2);    //this is where the cursor is on tile when you try to place it, ex: if your tile is 6 x 6 then 3,3 is on the middle of the tile

			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.addTile(Type);

			

            ModTranslation name = CreateMapEntryName();
			name.SetDefault("Devs' Forge");
			AddMapEntry(new Color(224, 183, 19), name);
            
            animationFrameHeight = 36;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY){Item.NewItem(i * 16, j * 16, 32, 32, mod.ItemType("DeveloperForge"));}

		

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)      //this adds light to the tile
        {                    //light  color
            r = 0.33f;   //red
            g = 0.2f;    // green
            b = 0f;   //blue
        }
 
        public override void AnimateTile(ref int frame, ref int frameCounter)
        {
            frameCounter++;
            if (frameCounter > 20)  //this is the frames speed, the bigger is the value the slower are the frames
            {
                frameCounter = 0;
                frame++;
                if (frame > 2)   //this is where you add how may frames your spritesheet has but -1, so if it has 4 frames you put 3 etc.
                {
                    frame = 0;
                }
            }
        }
	}
}