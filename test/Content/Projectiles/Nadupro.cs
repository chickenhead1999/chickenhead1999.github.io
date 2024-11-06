using Microsoft.Xna.Framework;
using System;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
namespace test.Content.Projectiles
{
     public class Nadupro : ModProjectile
    {

        public override void SetDefaults()
        {
            Projectile.width = 16;
            Projectile.height = 16;
            Projectile.friendly = true;
            Projectile.aiStyle = -1;
            Projectile.timeLeft = 3;
            Projectile.penetrate = -1;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = false;
            Projectile.scale = 1.1f;
            // 召唤物必备的属性
            //Main.projPet[Type] = true;
            Projectile.netImportant = true;
            Projectile.minionSlots = 1;
            Projectile.minion = true;
            ProjectileID.Sets.MinionSacrificable[Type] = true;
            ProjectileID.Sets.CultistIsResistantTo[Type] = true;
        }
        public override void AI()
        {   
            Player player = Main.player[Projectile.owner];
            var modPlayer = player.GetModPlayer<Players.MyPlayer>();
            // 玩家死亡会让召唤物消失
            if (player.dead)
            {
                modPlayer.Nadu = false;
            }
            if (modPlayer.Nadu)
            {
                // 如果Gliders不为true那么召唤物弹幕只有两帧可活
                Projectile.timeLeft = 2;
            }
            player.AddBuff(ModContent.BuffType<Buffs.Nadu>(), 2);// 把之前说的添加buff放在这里
        }
        // public override void SendExtraAI(BinaryWriter writer)
        // {
        //     writer.WriteVector2(TargetLocation);
        // }
        // public override void RecieveExtraAI(BinaryWriter reader)//这两条都是联机同步
        // {
        //     TargetLocation = reader.ReadVector2();
        // }
        public override bool MinionContactDamage()//接触伤害
        {
            return false;
        }
       
    }
}