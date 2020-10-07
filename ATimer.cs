using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Astonia_Alert
{
    class ATimer
    {
            public string GetTime()
            {
                var url = "https://www.astonia3.com/timer/";

                var htmlWeb = new HtmlWeb();
                var documentNode = htmlWeb.Load(url).DocumentNode;

                var findclasses = documentNode.SelectNodes("//p[contains(@class,'timer')]/span[contains(@class,'timertime')]");
                
                // May be unecessary to add all
                List<string> text = new List<string> { };
                foreach (var item in findclasses.Select(x => x.InnerText))
                {
                    text.Add(item);
                }

                return text.ElementAt(2);
            }
    }
}
