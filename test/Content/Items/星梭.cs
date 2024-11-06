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
	public class 星梭 : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.星规阵列遗物.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 4000;
			Item.DamageType = DamageClass.Generic;
			Item.width = 50;
			Item.height = 50;
			Item.useTime = 1;
			Item.useAnimation = 1;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(2147483647);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noMelee = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.耀斑>();
			Item.shootSpeed = 10f;
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