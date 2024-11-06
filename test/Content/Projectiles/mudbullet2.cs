using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using System.Threading;


namespace test.Content.Projectiles
{
    public class mudbullet2 : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("God Bullet"); 
        }

        public override void SetDefaults()
        {
            Projectile.width = 14; //设置弹幕的宽度
            Projectile.height = 14; //设置弹幕的高度
            Projectile.scale = 0.9f;
            Projectile.friendly = true; //设置为友方弹幕,赋值为false则为敌方弹幕
            Projectile.DamageType = DamageClass.Melee; //设置弹幕的伤害类型，如果是用枪械发射的则设为projectile.ranged = true；
            Projectile.ignoreWater = true; //设置同时无视水影响，如果赋值为false则弹幕会在水中减速
            Projectile.alpha = 0; //设置弹幕的透明度，0-255之间整数的任何值都可以，0表示完全不透明，255表示完全透明
            Projectile.tileCollide = false; //设置弹幕是否会在撞到地形后消失，如果赋值projectile.tileCollides = true; 则会在撞地后消失
            Projectile.penetrate = -1; //设置弹幕穿透次数，-1表示无限穿透
            Projectile.timeLeft = 900;
            Projectile.light = 1f; // 设置弹幕的发光量，取值范围[0, 1]

           // 以下属性视具体场景可设置
           /*
            projectile.light = 0.5f; // 设置弹幕的发光量，取值范围[0, 1]
            projectile.magic = true; // 如果是魔法弹幕，设置为true
            projectile.minion = false; // 如果是随从弹幕，设置为true
            projectile.aiStyle = -1; // 设置弹幕的AI类型。-1表示我们在AI函数进行自定义
            */

        }

        public override void AI()
       {
        Player player = Main.LocalPlayer;
        // Vector2 position = Projectile.position;
        // var dust = Dust.NewDustDirect(position, 1, 1, 6, 0, 0, 100, Color.White, 2f);
        // dust.noGravity = true;
        // Vector2 banjin = Projectile.position - player.Center;
        float distance =  Vector2.Distance(Projectile.position,player.Center);
        // Projectile.velocity = 

        float t = (float)(900 - Projectile.timeLeft) * 0.1f;
        // var player = Main.player[Projectile.owner];
        // // 目标位置（我偷个懒
        var targetPos = player.Center + t.ToRotationVector2().RotatedBy(-10F) * (-distance);
        Projectile.velocity = (targetPos - Projectile.Center);
        
        
        // Vector2 position = Projectile.Center;
        // int dustIndex = Dust.NewDust(position, 0, 0, 87, 0f, 0f, 0, default(Color), 1.5f);
        // if (Main.dust[dustIndex] != null)
        // {
        //     Main.dust[dustIndex].position = position;
        // }
        // }
        // Main.dust[dustIndex].velocity = Projectile.velocity;
        // Main.dust[dustIndex].noGravity = true;
        // 创建或更新ichor火焰粒子
        // if (Projectile.ai[0] == 0f) // 只在初始化时创建粒子
        // {
        //     for (int i = 0; i < 10; i++)
        //     {
        //         Vector2 position = Projectile.Center + new Vector2(Main.rand.Next(-20, 21), Main.rand.Next(-20, 21));
        //         Dust.NewDust(position, 1, 1, 87, Projectile.velocity.X * 0.2f, Projectile.velocity.Y * 0.2f, 150, default(Color), 1.5f);
        //     }
        //     Projectile.ai[0] = 1f;
        // }

        // // 更新粒子位置
        // foreach (Dust dust in Main.dust)
        // {
        //     if (dust.type == 87 && dust.customData == Projectile) // 确保是ichor火焰粒子且与弹幕相关
        //     {
        //         dust.position = Projectile.position;
        //     }
        // }
        //     if (Projectile.timeLeft % 60 == 0 && Projectile.timeLeft != 300)
        // {
        //     // 计算五角星的位置
        //     Vector2 starPosition = Projectile.Center + new Vector2(100f, 0f).RotatedBy(Projectile.velocity.ToRotation());

        //     // 创建粒子以绘制五角星
        //     for (int i = 0; i < 5; i++)
        //     {
        //         float rotation = MathHelper.TwoPi * i / 5;
        //         Vector2 offset = new Vector2(50f, 0f).RotatedBy(rotation);
        //         Dust.NewDust(starPosition + offset, 1, 1, 87, 0f, 0f, 0, default(Color), 1.5f);
        //     }
        // }

        // // 更新所有粒子的位置为五角星的中心
        // foreach (Dust dust in Main.dust)
        // {
        //     if (dust.type == 87) // 确保是你要的粒子类型
        //     {
        //         dust.position = starPosition;
        //     }
        // }
        // 让弹幕按照sin函数的周期性旋转，旋转弧度范围为[-0.5, 0.5]
        // Projectile.rotation += 0.1f; // 弹幕旋转速度

        //     float frequency = 0.5f; // 正弦函数的频率
        //     float amplitude = 1000f; // 正弦函数的振幅
            
        //     Projectile.velocity.X = 6f; // 弹幕水平移动速度
        //     Projectile.velocity.Y = amplitude * (float)Math.Sin(frequency * Projectile.position.X); // 计算弹幕垂直运动轨迹
        }
    }
}

