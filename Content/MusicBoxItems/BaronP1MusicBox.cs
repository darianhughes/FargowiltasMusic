using FargowiltasMusic.Content.MusicBoxSheets;
using FargowiltasMusic.Core;
using Terraria;
using Terraria.ModLoader;

namespace FargowiltasMusic.Content.MusicBoxItems
{
    public class BaronP1MusicBox : MusicBoxSystem.MusicBoxItem
    {
        public override void SetStaticDefaults()
        {
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Assets/Music/Baron"), ModContent.ItemType<BaronP1MusicBox>(), ModContent.TileType<BaronP1MusicBoxSheet>());
            base.SetStaticDefaults();
        }
        public override void SetDefaults()
        {
            Item.DefaultToMusicBox(ModContent.TileType<BaronP1MusicBoxSheet>(), 0);
            base.SetDefaults();
        }
    }
}
