using System.Collections.Generic;
using FargowiltasMusic.Content.MusicBoxSheets;
using FargowiltasMusic.Core;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace FargowiltasMusic.Content.MusicBoxItems
{
    public class RePrologueMusicBox : MusicBoxSystem.MusicBoxItem
    {
        public override void SetStaticDefaults()
        {
            MusicLoader.AddMusicBox(Mod, MusicLoader.GetMusicSlot(Mod, "Assets/Music/rePrologue"), ModContent.ItemType<RePrologueMusicBox>(), ModContent.TileType<RePrologueMusicBoxSheet>());
            base.SetStaticDefaults();
        }

        public override void ModifyTooltips(List<TooltipLine> list)
        {
            foreach (TooltipLine line2 in list)
            {
                if (line2.Mod == "Terraria" && line2.Name == "ItemName")
                {
                    line2.OverrideColor = new Color(Main.DiscoR, 51, 255 - (int)(Main.DiscoR * 0.4));
                }
            }
        }

        public override void SetDefaults()
        {
            Item.DefaultToMusicBox(ModContent.TileType<RePrologueMusicBoxSheet>(), 0);
            base.SetDefaults();
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }
    }
}
