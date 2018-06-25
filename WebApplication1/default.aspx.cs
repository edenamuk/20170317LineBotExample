using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var ChannelAccessToken = "GD3FGHjJmIZVTT0lYEUb2znRG6oIhG5thKUB9MotItS1WyfNGPelF148SobaWZMGooCazVMZZLzl92/j6uddgRbMbkXy1Gfj8m1ojkMbs+Nr4rsRU3qz2SNVEj/zjaeYBhWa3IgjhXAfLrb9gaGZrQdB04t89/1O/w1cDnyilFU=";
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot(ChannelAccessToken);

            var UserID = "Uf61bf68e7cfaedec8be1db4f007fa3b6";

            //push text
            //bot.PushMessage(UserID, "test");

            //push sticker
            //bot.PushMessage(UserID, 1, 2);

            //push image
            //bot.PushMessage(UserID, new Uri("https://arock.blob.core.windows.net/blogdata201612/22-124303-d8b2c4de-9a8c-48da-83f1-7c0d36de3ab6.png"));

            //建立actions，作為ButtonTemplate的用戶回覆行為
            var actions = new List<isRock.LineBot.TemplateActionBase>();
            actions.Add(new isRock.LineBot.MessageActon()
            { label = "點選這邊等同用戶直接輸入某訊息", text = "/例如這樣" });
            actions.Add(new isRock.LineBot.UriActon()
            { label = "點這邊開啟網頁", uri = new Uri("http://www.google.com") });
            actions.Add(new isRock.LineBot.PostbackActon()
            { label = "點這邊發生postack", data = "abc=aaa&def=111" });

            //單一Button Template Message
            var ButtonTemplate = new isRock.LineBot.ButtonsTemplate()
            {
                altText = "替代文字(在無法顯示Button Template的時候顯示)",
                text = "描述文字",
                title = "標題",
                //設定圖片
                thumbnailImageUrl = new Uri("https://scontent-tpe1-1.xx.fbcdn.net/v/t31.0-8/15800635_1324407647598805_917901174271992826_o.jpg?oh=2fe14b080454b33be59cdfea8245406d&oe=591D5C94"),
                actions = actions //設定回覆動作
            };

            //發送
            bot.PushMessage(UserID, ButtonTemplate);
        }
    }
}