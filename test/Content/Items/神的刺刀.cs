using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System;



//C SHARP 笔记
//Console.WriteLine($"Your age is: {age}"); 
//字符串开头的 $ 表示该字符串为插值字符串， { 和 } 之间的任何表达式都会被求值后嵌入到字符串中。
//x++ = x=x+1   ++X先赋值后输出，x++先输出后赋值
//果 flag 的值为 true ，那么 !flag 就是 false。
//当且仅当 && 两侧的两个布尔值均为 true 时，该表达式的结果才为 true，否则为 false。bool flag3 = 100 > 0 && 50 < 100; //true
//只要 || 两侧有一个值为 true，表达式的返回值就为 true。bool flag = number >= 100f || 50 > 0;//flag 为true
//例如，&& 的左操作数为 false，或 || 的左操作数为 true 时，便无需再继续对右操作数进行求值。
//twopi=360° 
namespace test.Content.Items
{
	public class 神的刺刀 : ModItem
	{
    public override void SetDefaults() {
			Item.width = 40; // The item texture's width.
			Item.height = 40; // The item texture's height.
            // 使用时的体积倍率，不写就是默认1倍，即不变大也不变小
            Item.scale = 1f;

			Item.useStyle = ItemUseStyleID.Swing; // The useStyle of the Item.
			Item.useTime = 4; // The time span of using the weapon. Remember in terraria, 60 frames is a second.
			Item.useAnimation = 4; // The time span of the using animation of the weapon, suggest setting it the same as useTime.
			Item.autoReuse = true; // Whether the weapon can be used more than once automatically by holding the use button.
            // 决定了你在使用物品的时候可否转身，不写就是false
            Item.useTurn = true;
            Item.mana = 0;
            Item.maxStack = Item.CommonMaxStack;
			Item.DamageType = DamageClass.Melee; // Whether your item is part of the melee class.
            // Default 代表无属性（也就是不吃任何加成）
            // Generic 代表全属性（也就是全部加成都吃）所谓1.3的allDamage就是它了
            // MagicSummonHybrid 代表什么我不知道，但是可以同时吃到魔法和召唤加成
            // MeleeNoSpeed 代表近战，但是不吃攻速加成
            // Melee 代表近战
            // Ranged 代表远程   
            // Magic 代表马猴烧酒，不，魔法
            // Summon 代表召唤
            // SummonMeleeSpeed 代表额......看看鞭子吧，可以吃到近战和召唤加成
            // Throwing 代表 投掷（没错虽然1.4没了投掷武器，全给远程了，但是这个伤害类型还在！）
			Item.damage = 8000; // The damage your item deals.
			Item.knockBack = 6; // The force of knockback of the weapon. Maximum is 20
			Item.crit = 100; // The critical strike chance the weapon has. The player, by default, has a 4% critical strike chance.
            Item.noUseGraphic = false;//是否在使用时显示贴图，默认显示，吸血飞刀这种不显示
			Item.value = Item.buyPrice(platinum: 1); // The value of the weapon in copper coins.
			Item.rare = -13;
			Item.UseSound = SoundID.Item1; // The sound when the weapon is being used.
			Item.shoot = ModContent.ProjectileType<Projectiles.GoodBullet>(); // 物品使用时发射的弹幕类型，这里是泰拉刃的剑气
			Item.shootSpeed = 10f;
		}
        public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Wood, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
		
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
			target.AddBuff(BuffID.Ichor, 600);
			player.Heal(1000);
			// if (damageDone > 10 || hit.Crit)
    		// {
    		//     // player.statLife += 10; // 回复10点生命，但是这个不会跳字
    		//     // player.HealEffect(10); // 玩家头上跳出绿色的10，就像使用生命水晶或是生命果那样
    		//     player.Heal(10); // 这种写法会同时回血+跳字，如无特殊需求建议使用这个
    		// }
		}
    }
}