using System;
using FargowiltasMusic.Content.MusicBoxSheets;
using FargowiltasMusic.Core;
using Terraria;
using Terraria.ModLoader;

namespace FargowiltasMusic.Content.MusicBoxItems
{
    public class DeviMusicBox : MusicBoxSystem.MusicBoxItem
    {
        public override void SetStaticDefaults()
        {
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, (Mod.Version >= Version.Parse("0.1.4")) ? "Assets/Music/Strawberry_Sparkly_Sunrise" : "Assets/Music/LexusCyanixs"), ModContent.ItemType<DeviMusicBox>(), ModContent.TileType<DeviMusicBoxSheet>());
            base.SetStaticDefaults();
        }

        public override void SetDefaults()
        {
            Item.DefaultToMusicBox(ModContent.TileType<DeviMusicBoxSheet>(), 0);
            base.SetDefaults();
        }
    }
}
