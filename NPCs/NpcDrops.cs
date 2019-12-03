using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UltWedZit.NPCs
{
    public class NpcDrops : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {

            if (npc.type == NPCID.EyeofCthulhu) //this is where you choose what vanilla npc you want  , for a modded npc add this instead  if (npc.type == mod.NPCType("ModdedNpcName"))
            {
                if (!UWZModWorld.spawnOre)
                {                                                          //Red  Green Blue
                    Main.NewText("The deserts are fucking DRY lmao yeet", 200, 200, 55);  //this is the message that will appear when the npc is killed  , 200, 200, 55 is the text color
                    for (int k = 0; k < (int)((double)(WorldGen.rockLayer * Main.maxTilesY) * 40E-05); k++)   //40E-05 is how many veins ore is going to spawn , change 40 to a lover value if you want less vains ore or higher value for more veins ore
                    {
                        int X = WorldGen.genRand.Next(0, Main.maxTilesX);
				        int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.
                        Tile tile = Framing.GetTileSafely(X, y);
                        if (tile.active() && tile.type == TileID.Sand)
				        {
                        WorldGen.OreRunner(X, y, WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9), (ushort)mod.TileType("LuminiteOre"));   //WorldGen.genRand.Next(9, 15), WorldGen.genRand.Next(5, 9) is the vein ore sizes, so 9 to 15 blocks or 5 to 9 blocks, mod.TileType("CustomOreTile") is the custom tile that will spawn
                        }
                    }
                }
                UWZModWorld.spawnOre = true;   //so the message and the ore spawn does not proc(show) when you kill EoC/npc again
            }
        }  
    }
}