using FargowiltasMusic.Content.MusicBoxSheets;
using FargowiltasMusic.Core;
using Terraria.ModLoader;

namespace FargowiltasMusic.Content.MusicBoxItems
{
    public class CoffinMusicBox : MusicBoxSystem.MusicBoxItem
    {
        public override void SetStaticDefaults()
        {
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Assets/Music/ShiftingSands"), ModContent.ItemType<CoffinMusicBox>(), ModContent.TileType<CoffinMusicBoxSheet>());

            base.SetStaticDefaults();
        }

        public override void SetDefaults()
        {
            Item.DefaultToMusicBox(ModContent.TileType<CoffinMusicBoxSheet>(), 0);
            base.SetDefaults();
        }
    }
}
