using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace test.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class 雄哥 : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.夏松灰熊.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 8964;
			Item.DamageType = DamageClass.Generic;
			Item.width = 150;
			Item.height = 150;
			Item.scale = 0.8f;
			Item.useTime = 1;
			Item.useAnimation = 1;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(2147483647);
			Item.rare = -13;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noMelee = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.维尼蜂蜜>();
			Item.shootSpeed = 40f;
		}
public override Vector2? HoldoutOffset()
{
// 横坐标往左移动10像素，纵坐标向上移动5像素
return new Vector2(-87, 0);
}
		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
    }
}