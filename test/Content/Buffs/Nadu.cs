using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System;
// using CalamityMod.CalPlayer;
namespace test.Content.Buffs
{
    public class Nadu : ModBuff
    {
        // public override void SetStaticDefaults()
        // {
        //     DisplayName.SetDefault("拿杜");
        //     Description.SetDefault("响应你起动寇族游牧人两次，展示牌库顶是张地，触发亡者旷野造个僵尸，再起动寇族游牧人展示牌库顶是找地地再造两僵尸");
        //     Main.buffNoTimeDisplay[Type] = false;
        //     Main.debuff[Type] = false;
        // }

        public override void Update(Player player, ref int buffIndex) 
        {
            var modPlayer = player.GetModPlayer<Players.MyPlayer>();
            // 如果当前有属于玩家的僚机的弹幕
            if (player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.Nadupro>()] > 0)
            {
                modPlayer.Nadu = true;

            }
            // 如果玩家取消了这个召唤物就让buff消失
            if (!modPlayer.Nadu)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {
                // 无限buff时间
                player.buffTime[buffIndex] = 9999;
            }
        }
    }
}