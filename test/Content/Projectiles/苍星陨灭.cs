using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;


namespace test.Content.Projectiles
{
     public class 苍星殒灭 : ModProjectile
    {

        public override void SetDefaults()
        {
            Projectile.width = 24; //设置弹幕的宽度
            Projectile.height = 25; //设置弹幕的高度
            Projectile.friendly = true; //设置为友方弹幕,赋值为false则为敌方弹幕
            Projectile.DamageType = DamageClass.Generic; //设置弹幕的伤害类型，如果是用枪械发射的则设为projectile.ranged = true；
            Projectile.ignoreWater = true; //设置同时无视水影响，如果赋值为false则弹幕会在水中减速
            Projectile.alpha = 0; //设置弹幕的透明度，0-255之间整数的任何值都可以，0表示完全不透明，255表示完全透明
            Projectile.tileCollide = false; //设置弹幕是否会在撞到地形后消失，如果赋值projectile.tileCollides = true; 则会在撞地后消失
            Projectile.timeLeft = 200;
            Projectile.penetrate = -1; //设置弹幕穿透次数，-1表示无限穿透
            Projectile.light = 1f; // 设置弹幕的发光量，取值范围[0, 1]

           // 以下属性视具体场景可设置
           /*
            projectile.light = 0.5f; // 设置弹幕的发光量，取值范围[0, 1]
            projectile.magic = true; // 如果是魔法弹幕，设置为true
            projectile.minion = false; // 如果是随从弹幕，设置为true
            projectile.aiStyle = -1; // 设置弹幕的AI类型。-1表示我们在AI函数进行自定义
            */

//         }

//         public override void AI()
//         {
//         Vector2 position = Projectile.position;
//         var dust = Dust.NewDustDirect(position, 1, 1, 161, 0, 0, 100, Color.White, 2f);
//         dust.noGravity = true;   
//         var player = Main.player[Projectile.owner];
//         // 半径r = 100，线速度v = 10
//         var unit = (player.Center - Projectile.Center).SafeNormalize(Vector2.Zero) * 100 * 500 / 10f;
//         Projectile.velocity += unit;
}
}
}