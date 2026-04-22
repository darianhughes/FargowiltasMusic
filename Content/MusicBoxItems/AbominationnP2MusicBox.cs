using FargowiltasMusic.Content.MusicBoxSheets;
using FargowiltasMusic.Core;
using System;
using Terraria.ModLoader;

namespace FargowiltasMusic.Content.MusicBoxItems
{
    public class AbominationnP2MusicBox : MusicBoxSystem.MusicBoxItem
    {
        public override void SetStaticDefaults()
        {
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, Mod.Version >= Version.Parse("0.1.5") ? "Assets/Music/Laevateinn_P2" : "Assets/Music/Stigma"), ModContent.ItemType<AbominationnP2MusicBox>(), ModContent.TileType<AbominationnP2MusicBoxSheet>());
            base.SetStaticDefaults();
        }

        public override void SetDefaults()
        {
            Item.DefaultToMusicBox(ModContent.TileType<AbominationnP2MusicBoxSheet>(), 0);
            base.SetDefaults();
        }
    }
}
