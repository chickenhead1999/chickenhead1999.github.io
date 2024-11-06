using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
namespace test.Content.Players
{
public class MyPlayer : ModPlayer
{
   
    public override void PreUpdate()
    {
        ItemCheck(Player);
    }
    
    public void ItemCheck(Player player)
    {
        Item item = player.HeldItem;
        if (Main.mouseRight && item.type == ModContent.ItemType<Items.雄哥>())
        {
            Main.NewText("头上三尺有神明，一定要有敬畏之心，都要应验的", new Color(0, 255, 255));
            Main.NewText("轻关易道，通商宽衣", new Color(0, 255, 255));
            Main.NewText("别看你今天闹得欢，小心啊，明天拉清单", new Color(0, 255, 255));
            Main.NewText("亲自指挥，亲自部署", new Color(0, 255, 255));
            Main.NewText("立党为公，执政为民", new Color(0, 255, 255));
            Main.NewText("不忘初心，牢记使命", new Color(0, 255, 255));
            Main.NewText("坚持四项基本原则", new Color(0, 255, 255));
            Main.NewText("为人民服务", new Color(0, 255, 255));
            Main.NewText("全面建成小康社会、全面深化改革、全面依法治国、全面从严治党", new Color(0, 255, 255));
            Main.NewText("没有共产党，就没有新中国", new Color(0, 255, 255));
        }
    }
    public bool Nadu;
    public override void ResetEffects()
    {
        Nadu = false;
    }
    public override void OnEnterWorld()
    {
        Main.NewText("头上三尺有神明，一定要有敬畏之心，都要应验的", new Color(0, 255, 255));
            Main.NewText("轻关易道，通商宽衣", new Color(0, 255, 255));
            Main.NewText("别看你今天闹得欢，小心啊，明天拉清单", new Color(0, 255, 255));
            Main.NewText("亲自指挥，亲自部署", new Color(0, 255, 255));
            Main.NewText("立党为公，执政为民", new Color(0, 255, 255));
            Main.NewText("不忘初心，牢记使命", new Color(0, 255, 255));
            Main.NewText("坚持四项基本原则", new Color(0, 255, 255));
            Main.NewText("为人民服务", new Color(0, 255, 255));
            Main.NewText("全面建成小康社会、全面深化改革、全面依法治国、全面从严治党", new Color(0, 255, 255));
            Main.NewText("没有共产党，就没有新中国", new Color(0, 255, 255));
    }
    
    
}
}