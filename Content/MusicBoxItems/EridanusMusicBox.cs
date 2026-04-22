using FargowiltasMusic.Content.MusicBoxSheets;
using FargowiltasMusic.Core;
using Terraria.ModLoader;

namespace FargowiltasMusic.Content.MusicBoxItems
{
    public class EridanusMusicBox : MusicBoxSystem.MusicBoxItem
    {
        public override void SetStaticDefaults()
        {
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Assets/Music/PlatinumStar"), ModContent.ItemType<EridanusMusicBox>(), ModContent.TileType<EridanusMusicBoxSheet>());
            base.SetStaticDefaults();
        }

        public override void SetDefaults()
        {
            Item.DefaultToMusicBox(ModContent.TileType<EridanusMusicBoxSheet>(), 0);
            base.SetDefaults();
        }
    }
}
