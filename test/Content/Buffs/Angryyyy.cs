using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System;
// using CalamityMod.CalPlayer;
namespace test.Content.Buffs
{
    public class Angryyyy : ModBuff
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Angryyyy");
            // Description.SetDefault("Quadruples your attack speed");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex) 
        {
            // 提升Terraria原生属性
            player.GetAttackSpeed(DamageClass.Melee) += 3f;  // 近战攻击速度
            player.GetAttackSpeed(DamageClass.Ranged) += 3f; 
            player.GetAttackSpeed(DamageClass.Magic) += 3f; 
            player.GetAttackSpeed(DamageClass.Summon) += 3f; 

            /// 提升灾厄模组中盗贼伤害属性
            // CalamityPlayer modPlayer = player.GetModPlayer<CalamityPlayer>();
            // modPlayer.thrownSpeed += 3f;  // 盗贼攻击速度
        }
    }
}