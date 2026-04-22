using FargowiltasMusic.Content.MusicBoxSheets;
using FargowiltasMusic.Core;
using Terraria;
using Terraria.ModLoader;

namespace FargowiltasMusic.Content.MusicBoxItems
{
    public class MainMenuMusicBox : MusicBoxSystem.MusicBoxItem
    {
        public override void SetStaticDefaults()
        {
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Assets/Music/Nein"), ModContent.ItemType<MainMenuMusicBox>(), ModContent.TileType<MainMenuMusicBoxSheet>());
            base.SetStaticDefaults();
        }

        public override void SetDefaults()
        {
            Item.DefaultToMusicBox(ModContent.TileType<MainMenuMusicBoxSheet>(), 0);
            base.SetDefaults();
        }
    }
}
