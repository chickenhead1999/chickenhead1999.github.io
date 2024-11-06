using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;

namespace test.Content.Items
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class 夕象 : ModItem
	{
		public int i = 10;
		public override void SetDefaults()
		{
			Item.height=40;
			Item.width=40;
			Item.value=1000000;
			// 使用速度和使用动画持续时间！
		// 这个数值越低越快，因为TR游戏速度每秒是60帧，这里的20就是
		// 20.0 / 60.0 = 0.333 秒挥动一次！也就是一秒三次
			Item.useTime = 5;
			Item.useAnimation = 60;
			// 一般来说我们要把这两个值设成一样，但也有例外的时候
		// 比如下边的工具，让useTime = 5，而useAnimation还是20，这这么做就会让这个物品点击一次使用20 / 5 = 4次！但是只有一次使用动画（）

		// 使用类型，这个值决定了武器使用时到底是按什么样的动画播放
		// 0 或 None 代表......字面意思，就是啥都没有！你写了之后甚至无法使用！
		// 1 或 Swing 代表挥动，也就是剑类武器！
		// 2 或 EatFood 代表像食物一样，拥有物品，手持，放在盘子上三帧的贴图，具体可见exmod里头的🥧（派）https://github.com/Cyrillya/Example-Mod-Zh-Project/blob/master/Content/Items/Consumables/ExampleFoodItem.cs
		// 3 或 Thrust 代表像1.3的同志短剑一样刺x 出去（也就是朝左或右刺出）（如果你想要写全方位刺出的剑，那你还是得看exmod）
		// 4 或 HoldUp 唔，这个一般不是用在武器上的，想象一下生命水晶使用的时候的动作
		// 5 或 Shoot 手持，枪、弓、法杖类武器的动作，用途最广
		// 6 或 DrinkLong 代表直接猛喝，感兴趣可以自己看看，挺好玩的（
		// 7 或 DrinkOld 代表1.3的喝药水动作
		// 8 或 GolfPlay 代表高尔夫球杆的动作
		// 9 或 DrinkLiquid 代表1.4的喝药水动作，相比1.3的来说，这个动作的手臂更加流畅，持握位置会在瓶口
		// 10 或 HiddenAnimation 代表使用时无动画
		// 11 或 MowTheLawn 代表割草机的动作，神奇，这玩意还有单独的动作
		// 12 或 Guitar 代表常春藤、雨之歌等物品的动作，对这玩意也是单独的动作（爱抚剑ing
		// 13 或 Rapier 代表标尺、星光等武器的动作
		// 14 或 RaiseLamp 代表夜光的动作，好吧这也单独写一个动作的吗？话说这玩意翻译过来叫吊灯......夜光大吊灯（bushi
		// Item.useStyle = 1; 请不要写魔法值
			Item.useStyle = ItemUseStyleID.Shoot; //需要注意一点，泰拉中的挥动型物品的贴图基本都是朝着右上角倾斜的，如果你的贴图不是如此，那可能会导致奇怪的视觉问题。
			Item.rare = -13;
		// 决定了这个武器鼠标按住不放能不能自动使用， true代表可以, false代表不行
		// （鼠标别按废了，这条属性你要是不写那就是默认的false
			Item.autoReuse = true;

		// 决定了你在使用物品的时候可否转身，不写就是false
			Item.useTurn = false;

		// 这是使用时的音效，不写就是没有
		// 这是一个挥动音效
			Item.UseSound = SoundID.Item1;
		// 使用时的体积倍率，不写就是默认1倍，即不变大也不变小
			Item.scale = 1f;

// 伤害！想都不要想，后面这个值随便改吧，但是不要超过2147483647
// 不然…… 你试试就知道了
			Item.damage = i;

		// 决定了这个武器的伤害类型
		// Default 代表无属性（也就是不吃任何加成）
		// Generic 代表全属性（也就是全部加成都吃）所谓1.3的allDamage就是它了
		// MagicSummonHybrid 代表什么我不知道，但是可以同时吃到魔法和召唤加成
		// MeleeNoSpeed 代表近战，但是不吃攻速加成
		// Melee 代表近战
		// Ranged 代表远程
		// Magic 代表马猴烧酒，不，魔法
		// Summon 代表召唤
				// SummonMeleeSpeed 代表额......看看鞭子吧，可以吃到近战和召唤加成
			// Throwing 代表投掷（没错虽然1.4没了投掷武器，全给远程了，但是这个伤害类型还在！）
			Item.DamageType = DamageClass.Magic; // 这里用的是一把剑所以是Melee，近战伤害

// 击退力，写0~20f之间的数值，越大击退力越强
			Item.knockBack = 8f;

// 暴击率，角色自带4%
			Item.crit = 66; // 20%暴击率，游戏内显示会是20 + 4 = 24%暴击率

// 这是控制贴图是否造成伤害，默认是造成伤害
			Item.noMelee = true; // 这是一把剑所以贴图是造成伤害的
// 但如果你是枪类的远程武器，你不希望拿着枪敲人的话就要把它设置为true

// 这是控制使用时是否显示贴图，默认是有的
			Item.noUseGraphic = false;
// 吸血飞刀这个就是true，它使用时不显示贴图

// 假如这是一个法杖类型，不写默认false，这里就用到物品Type了
			Item.staff[Type] = true; // enn，这是把剑
// 一般来说，法杖类武器会使用Shoot的那个使用方式，但它的贴图不像枪一样是水平朝向而是向右上倾斜
// 让它变成true就会导致使用时贴图再转45度，变成法杖尖端朝着射击方向

// 这是使用消耗的魔力值，不写就不消耗
			Item.mana = 4;
			Item.shoot = ProjectileID.TerraBeam; // 物品使用时发射的弹幕类型，这里是泰拉刃的剑气
			Item.shootSpeed = 8f; // 物品发射弹幕的速度，单位：像素/帧，一秒 = 60帧
		
		}
		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
		{
        // 检查敌人是否已死亡，以确定是否击杀  
        if (target.life <= i)  
        {  
            // 增加伤害  
            i += 2;  
        }  
    	}  
		public override void AddRecipes()
		 {
			CreateRecipe()
			.AddIngredient(ItemID.Wood, 18)		
			.AddTile(TileID.WorkBenches)
			.Register();
		 }
		//public override bool UseItem(Player player)
		//{ 
		//	Vector2 position = player.position; 
		//	float newY = Main.rand.Next((int)Main.worldSurface * 16);
		//	position.Y = newY; 
		//	player.Teleport(position); 
		//	return true; 
		//}
	 	//public override void AddRecipes()
	 	//{
	 	//	MidRecuoe recipe=new ModRecipe(this);
	 //		recipe.AkkIngredient(ItemID,Wood,18);
	 	//	recipe.SetResult(null,"夕象",1);
	 	//	recipe.AddRecipe;
		//}
	}
}