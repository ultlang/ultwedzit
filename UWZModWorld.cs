using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;

namespace UltWedZit
{
	public class UWZModWorld : ModWorld
	{
		public static bool spawnOre = false;
		// We use this hook to add 3 steps to world generation at various points. 
		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight) {
			// Because world generation is like layering several images ontop of each other, we need to do some steps between the original world generation steps.

			// The first step is an Ore. Most vanilla ores are generated in a step called "Shinies", so for maximum compatibility, we will also do this.
			// First, we find out which step "Shinies" is.
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex != -1) {
				// Next, we insert our step directly after the original "Shinies" step. 
				// ExampleModOres is a method seen below.
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("UltWedZit Mod Ores", UWZModOres));
			}
		}



		private void UWZModOres(GenerationProgress progress) {
			// progress.Message is the message shown to the user while the following code is running. Try to make your message clear. You can be a little bit clever, but make sure it is descriptive enough for troubleshooting purposes. 
			progress.Message = "UltWedZit Mod Ores";

            // Ores are quite simple, we simply use a for loop and the WorldGen.TileRunner to place splotches of the specified Tile in the world.
            // "6E-05" is "scientific notation". It simply means 0.00006 but in some ways is easier to read.
            if (WorldGen.genRand.NextBool(2)) {
                for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 2E-04); k++)
                {
                    // The inside of this for loop corresponds to one single splotch of our Ore.
                    // First, we randomly choose any coordinate in the world by choosing a random x and y value.
                    int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                    int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

                    // Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
                    WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("MikaniteOreTile"), false, 0f, 0f, false, true);

                    // Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
                    // Tile tile = Framing.GetTileSafely(x, y);
                    // if (tile.active() && tile.type == TileID.SnowBlock)
                    // {
                    // 	WorldGen.TileRunner(.....);
                    // }
                }
			} else {
                for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 2E-04); k++)
                {
                    // The inside of this for loop corresponds to one single splotch of our Ore.
                    // First, we randomly choose any coordinate in the world by choosing a random x and y value.
                    int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                    int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

                    // Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
                    WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("OniteOreTile"), false, 0f, 0f, false, true);

                    // Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
                    // Tile tile = Framing.GetTileSafely(x, y);
                    // if (tile.active() && tile.type == TileID.SnowBlock)
                    // {
                    // 	WorldGen.TileRunner(.....);
                    // }
                }
            }
		}


		

	}

}