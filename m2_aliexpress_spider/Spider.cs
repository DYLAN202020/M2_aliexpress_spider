using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace m2_aliexpress_spider
{
    class Spider
    {
        public static string ua = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_4) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/73.0.3683.103 Safari/537.36";

        private readonly string url;

        private string html;

        public Spider(string url)
        {
            this.url = url;
        }

        public string Title { get; set; }

        public string Price { get; set; }

        public string CurrencyCode { get; set; }

        public string DescHtml { get; set; }

        public List<string> MainImageList = new List<string>();

        public List<string> ContentImageList = new List<string>();

        // <propTypeName, valueList>
        public Dictionary<string, List<SkuPropertyValue>> PropertyDict = new Dictionary<string, List<SkuPropertyValue>>();

        // <propId, value>
        public Dictionary<string, SkuPropertyValue> PropertyDict4Index = new Dictionary<string, SkuPropertyValue>();


        public List<SkuItem> ProductSkuItemList = new List<SkuItem>();

        public void LoadHtml()
        {
            this.html = HttpUtils.HttpGet(url);
        }

        public void ParseHTML()
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);
            HtmlNode docNode = doc.DocumentNode;

            HtmlNode h1Node = docNode.SelectNodes(".//h1").First();
            this.Title = h1Node.InnerText;

            //HtmlNode producetNode = doc.DocumentNode.SelectSingleNode("//div[@id='j-product-info-sku']");
            HtmlNodeCollection dlNodes = doc.DocumentNode.SelectNodes(".//dl[@class='p-property-item']");
            if (dlNodes != null && dlNodes.Count > 0)
            {
                
                foreach (HtmlNode dlNode in dlNodes)
                {
                    HtmlNode dtNode = dlNode.SelectSingleNode(".//dt[@class='p-item-title']");

                    string propertyTitle = dtNode.InnerText;
                    List<SkuPropertyValue> list = new List<SkuPropertyValue>();

                    HtmlNodeCollection liNodes = dlNode.SelectNodes(".//li");
                    foreach (var liNode in liNodes)
                    {

                        SkuPropertyValue skuPropertyValue = new SkuPropertyValue();
                        skuPropertyValue.Prop = propertyTitle;

                        HtmlNode aNode = liNode.SelectSingleNode(".//a");
                        skuPropertyValue.Id = aNode.Attributes["data-sku-id"].Value;

                        HtmlNode imgNode = aNode.SelectSingleNode(".//img");
                        if (imgNode != null)
                        {
                            skuPropertyValue.ImageUrl = imgNode.Attributes["src"].Value;
                        }

                        HtmlNode spanNode = aNode.SelectSingleNode(".//span");
                        if (spanNode != null)
                        {
                            //Console.WriteLine(spanNode.InnerText);
                            skuPropertyValue.Name = spanNode.InnerText;
                        }

                        list.Add(skuPropertyValue);

                        // for index
                        PropertyDict4Index.Add(skuPropertyValue.Id, skuPropertyValue);
                    }

                    PropertyDict.Add(propertyTitle, list);
                }
            }

            int i = 0;
            HtmlNodeCollection scriptList = doc.DocumentNode.SelectNodes(".//script");
            foreach (HtmlNode item in scriptList)
            {
                //Console.WriteLine("===========================" + i);
                i++;
                //Console.WriteLine(item.InnerHtml);

                string script = item.InnerHtml;
                if (script.Contains("window.runParams.maxPrice"))
                {
                    //Console.WriteLine(script);

                    string v = script;
                    v = v.Substring(script.IndexOf("runParams.maxPrice="));
                    v = v.Replace("runParams.maxPrice=", "");
                    v = v.Substring(0, v.IndexOf(";"));
                    v = v.Replace("\"", "");
                    this.Price = v;
                    //Console.WriteLine(this.Price);
                }

                if (script.Contains("window.runParams.baseCurrencyCode"))
                {
                    //Console.WriteLine(script);
                    string v = script;
                    v = v.Substring(script.IndexOf("runParams.baseCurrencyCode="));
                    v = v.Replace("runParams.baseCurrencyCode=", "");
                    v = v.Substring(0, v.IndexOf(";"));
                    v = v.Replace("\"", "");
                    this.CurrencyCode = v;
                    //Console.WriteLine(this.CurrencyCode);
                }

                if (script.Contains("runParams.imageBigViewURL"))
                {
                    //Console.WriteLine(script);
                    string v = script;
                    v = v.Substring(script.IndexOf("runParams.imageBigViewURL="));
                    v = v.Replace("runParams.imageBigViewURL=", "");
                    v = v.Substring(0, v.IndexOf(";"));
                    v = v.Replace("\"", "");
                    v = v.Replace("\n", "");
                    v = v.Replace("\r", "");
                    v = v.Replace("\t", "");
                    v = v.Replace("[", "");
                    v = v.Replace("]", "");
                    foreach (var imageUrl in v.Split(','))
                    {
                        this.MainImageList.Add(imageUrl);
                    }

                    //this.CurrencyCode = v;
                    //Console.WriteLine(this.MainImageList);
                }

                if (script.Contains("runParams.descUrl"))
                {
                    //Console.WriteLine(script);
                    string v = script;
                    v = v.Substring(script.IndexOf("runParams.descUrl="));
                    v = v.Replace("runParams.descUrl=", "");
                    v = v.Substring(0, v.IndexOf(";"));
                    v = v.Replace("\"", "");
                    //this.CurrencyCode = v;
                    v = "http:" + v;

                    // Console.WriteLine(v);
                    string descHtml = HttpUtils.HttpGet(v);
                    descHtml = descHtml.Replace("window.productDescription='", "");
                    descHtml = descHtml.Replace("';", "");
                    this.DescHtml = descHtml;
                    //Console.WriteLine("descHtml:" + descHtml);

                    HtmlAgilityPack.HtmlDocument descDoc = new HtmlAgilityPack.HtmlDocument();
                    descDoc.LoadHtml(DescHtml);
                    HtmlNode descDoccNode = descDoc.DocumentNode;
                    HtmlNodeCollection imgList = descDoccNode.SelectNodes(".//img");
                    foreach (HtmlNode imgNode in imgList)
                    {
                        //Console.WriteLine(imgNode.Attributes["src"].Value);
                        string src = imgNode.Attributes["src"].Value;
                        if (src.StartsWith(@"//"))
                        {
                            src = src.Substring(2);
                        }

                        if (!src.StartsWith("http"))
                        {
                            src = "http://" + src;
                        }

                        this.ContentImageList.Add(src);
                    }
                }

                if (script.Contains("var skuProducts="))
                {
                    //Console.WriteLine(script);
                    string v = script;
                    v = v.Substring(script.IndexOf("var skuProducts="));
                    v = v.Replace("var skuProducts=", "");
                    v = v.Substring(0, v.IndexOf("}}];") + 3);
                    ProductItem[] ProductItems = JsonConvert.DeserializeObject<ProductItem[]>(v);


                    foreach (ProductItem productItem in ProductItems)
                    {
                        //Console.WriteLine("----------------");
                        SkuItem skuItem = new SkuItem();
                        skuItem.SkuId = productItem.skuId.ToString();
                        skuItem.Price = Price;
                        skuItem.Title = Title;
                        skuItem.Propertys = new List<string>();

                        foreach (var propId in productItem.skuPropIds.Split(','))
                        {
                            if (propId == null || propId.Length == 0)
                            {
                                continue;
                            }
                            //Console.WriteLine("============propId: " + propId);
                        
                        
                            SkuPropertyValue spv = PropertyDict4Index[propId];
                            
                            
                            string prop = spv.Name != null ? spv.Name : spv.ImageUrl;
                            //Console.WriteLine(prop);
                            skuItem.Propertys.Add(prop);
                        }

                        ProductSkuItemList.Add(skuItem);
                    }

                    
                    //v = v.Replace("\"", "");
                    //v = v.Replace("\n", "");
                    //v = v.Replace("\r", "");
                    //v = v.Replace("\t", "");
                    //v = v.Replace("[", "");
                    //v = v.Replace("]", "");


                    //this.CurrencyCode = v;
                    //Console.WriteLine(JsonConvert.SerializeObject(ProductSkuItemList));
                }

            }

            

        }



    }


    

}
