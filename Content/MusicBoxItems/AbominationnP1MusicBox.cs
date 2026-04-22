using System;
using FargowiltasMusic.Content.MusicBoxSheets;
using FargowiltasMusic.Core;
using Terraria;
using Terraria.ModLoader;

namespace FargowiltasMusic.Content.MusicBoxItems
{
    public class AbominationnP1MusicBox : MusicBoxSystem.MusicBoxItem
    {
        public override void SetStaticDefaults()
        {
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, Mod.Version >= Version.Parse("0.1.5") ? "Assets/Music/Laevateinn_P1" : "Assets/Music/Stigma"), ModContent.ItemType<AbominationnP1MusicBox>(), ModContent.TileType<AbominationnP1MusicBoxSheet>());
            base.SetStaticDefaults();
        }

        public override void SetDefaults()
        {
            Item.DefaultToMusicBox(ModContent.TileType<AbominationnP1MusicBoxSheet>(), 0);
            base.SetDefaults();
        }
    }
}
