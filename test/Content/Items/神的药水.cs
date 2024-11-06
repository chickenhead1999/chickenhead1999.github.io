using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace test.Content.Items
{
	public class 神的药水 : ModItem
	{
		

		public override void SetDefaults() {
			Item.width = 20;
			Item.height = 26;
			Item.useStyle = ItemUseStyleID.DrinkLiquid;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useTurn = true;
			Item.UseSound = SoundID.Item3;
			Item.maxStack = Item.CommonMaxStack;
			Item.consumable = true;
			Item.rare = -13;
			Item.value = Item.buyPrice(silver: 8);
			Item.buffType = ModContent.BuffType<Buffs.Angryyyy>(); // Specify an existing buff to be applied when used.
			Item.buffTime = 3 * 60 * 60; // The amount of time the buff declared in Item.buffType will last in ticks. Set to 3 minutes, as 60 ticks = 1 second.
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Wood, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
