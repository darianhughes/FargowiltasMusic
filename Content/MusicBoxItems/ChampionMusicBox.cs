using FargowiltasMusic.Content.MusicBoxSheets;
using FargowiltasMusic.Core;
using Terraria;
using Terraria.ModLoader;

namespace FargowiltasMusic.Content.MusicBoxItems
{
    public class ChampionMusicBox : MusicBoxSystem.MusicBoxItem
    {
        public override void SetStaticDefaults()
        {
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Assets/Music/Champions"), ModContent.ItemType<ChampionMusicBox>(), ModContent.TileType<ChampionMusicBoxSheet>());
            base.SetStaticDefaults();
        }

        public override void SetDefaults()
        {
            Item.DefaultToMusicBox(ModContent.TileType<ChampionMusicBoxSheet>(), 0);
            base.SetDefaults();
        }
    }
}

