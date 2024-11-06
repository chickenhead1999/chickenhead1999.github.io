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
	
	public class 神的餐刀 : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.星规阵列遗物.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 600;
			Item.DamageType = DamageClass.Generic;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 5;
			Item.useAnimation = 5;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = Item.buyPrice(2147483647);
			Item.rare = -13;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.noMelee = true;
			Item.shoot = ModContent.ProjectileType<Projectiles.mudbullet>();
			Item.shootSpeed = 1f;

		}
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
            Vector2 playerPosition = player.Center;
            Vector2 randomPosition = playerPosition + new Vector2(Main.rand.Next(-400, 400), Main.rand.Next(-400, 400));

            Projectile.NewProjectile(source, randomPosition, Vector2.Zero, ModContent.ProjectileType<Projectiles.mudbullet>(), damage, knockback, player.whoAmI);
			Projectile.NewProjectile(source, randomPosition, Vector2.Zero, ModContent.ProjectileType<Projectiles.mudbullet2>(), damage, knockback, player.whoAmI);


            return false;
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
