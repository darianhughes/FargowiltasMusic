using FargowiltasMusic.Content.MusicBoxSheets;
using FargowiltasMusic.Core;
using Terraria;
using Terraria.ModLoader;

namespace FargowiltasMusic.Content.MusicBoxItems
{
    public class BaronP2MusicBox : MusicBoxSystem.MusicBoxItem
    {
        public override void SetStaticDefaults()
        {
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Assets/Music/Baron2"), ModContent.ItemType<BaronP2MusicBox>(), ModContent.TileType<BaronP2MusicBoxSheet>());
            base.SetStaticDefaults();
        }

        public override void SetDefaults()
        {
            Item.DefaultToMusicBox(ModContent.TileType<BaronP2MusicBoxSheet>(), 0);
            base.SetDefaults();
        }
    }
}
