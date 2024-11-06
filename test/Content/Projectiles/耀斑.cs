using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;


namespace test.Content.Projectiles
{
     public class 耀斑 : ModProjectile
    {

        public override void SetDefaults()
        {
            Projectile.width = 36; //设置弹幕的宽度
            Projectile.height = 34; //设置弹幕的高度
            Projectile.friendly = true; //设置为友方弹幕,赋值为false则为敌方弹幕
            Projectile.DamageType = DamageClass.Generic; //设置弹幕的伤害类型，如果是用枪械发射的则设为projectile.ranged = true；
            Projectile.ignoreWater = true; //设置同时无视水影响，如果赋值为false则弹幕会在水中减速
            Projectile.alpha = 255; //设置弹幕的透明度，0-255之间整数的任何值都可以，0表示完全不透明，255表示完全透明
            Projectile.tileCollide = false; //设置弹幕是否会在撞到地形后消失，如果赋值projectile.tileCollides = true; 则会在撞地后消失
            Projectile.timeLeft = 200;
            Projectile.penetrate = -1; //设置弹幕穿透次数，-1表示无限穿透
            Projectile.light = 1f; // 设置弹幕的发光量，取值范围[0, 1]
           // Projectile.magic = true;
        }


//         }

          
    public override void AI()
        {
     Vector2 position = Projectile.position;
           var dust = Dust.NewDustDirect(position, 1, 1, 235, 0, 0, 100, Color.White, 2f);
           dust.noGravity = true;
           if(Projectile.timeLeft >= 100)
          { 
            var k = Main.time * 10f;
           var t = Main.time * 10f;
           var player = Main.player[Projectile.owner];
// 半径r = 50，以玩家中心为圆心
           Projectile.Center = player.Center + new Vector2((float)Math.Cos(t), (float)Math.Sin(t)) * 1f;
           var uni2 = (player.Center - Projectile.Center).SafeNormalize(Vector2.Zero) * 40 * 40 / 50f;
           Projectile.velocity = uni2;
          }
            else
           {
        
           
           }
     }
}
}