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
    public class MoodBallet : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("God Bullet"); 
        }
        
        public override void SetDefaults()
        {
            Projectile.width = 14; //设置弹幕的宽度
            Projectile.height = 14; //设置弹幕的高度
            Projectile.friendly = true; //设置为友方弹幕,赋值为false则为敌方弹幕
            Projectile.DamageType = DamageClass.Melee; //设置弹幕的伤害类型，如果是用枪械发射的则设为projectile.ranged = true；
            Projectile.ignoreWater = true; //设置同时无视水影响，如果赋值为false则弹幕会在水中减速
            Projectile.alpha = 255; //设置弹幕的透明度，0-255之间整数的任何值都可以，0表示完全不透明，255表示完全透明
            Projectile.tileCollide = false; //设置弹幕是否会在撞到地形后消失，如果赋值projectile.tileCollides = true; 则会在撞地后消失
            Projectile.penetrate = 1; //设置弹幕穿透次数，-1表示无限穿透
            Projectile.timeLeft = 240;
            Projectile.light = 0.1f; // 设置弹幕的发光量，取值范围[0, 1]

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
        Vector2 position = Projectile.position;
        var player = Main.player[Projectile.owner];
        var dust = Dust.NewDustDirect(position, 1, 1, 6, 0, 0, 100, Color.White, 2f);
        dust.noGravity = true;
        NPC target = null;
        float distanceMax = 1000f;
        foreach (NPC npc in Main.npc) {
            if (!npc.active || npc.friendly) continue;
            float currentDistance = Vector2.Distance(npc.Center, player.Center);
            if (currentDistance < distanceMax) {
                distanceMax = currentDistance;
                target = npc;
            }
        }
        if (target != null) {
            Vector2 targetPosition = target.position; 
            Vector2 direction = targetPosition - Projectile.position; 
            direction.Normalize();
            Projectile.velocity = direction * 5f;
            }
        else{
            Projectile.position = Main.MouseWorld;
        }
    }
  } 
}


