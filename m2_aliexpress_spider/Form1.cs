using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace m2_aliexpress_spider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strDesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            folderBrowserDialog1.SelectedPath = strDesktopPath;
            tbxSavePath.Text = folderBrowserDialog1.SelectedPath;

            groupBox2.Enabled = false;
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxSavePath.Text = folderBrowserDialog1.SelectedPath; 
            }
        }

        private Spider spider;
        private string check = null;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (check == null)
            {
                string result = HttpUtils.HttpGet("http://www.im6000.com:8800/m2/checkAliexpress?ver=1");
                check = result;
            }

            if (check != "1")
            {
                MessageBox.Show("版本已过期，请加群获取最新版本程序", "提示");
                return;
            }

            spider = new Spider(tbxUrl.Text);
            Console.WriteLine("--");
            bool suc = spider.LoadHtml();
            if (!suc)
            {
                return;
            }
            if (spider.isNL())
            {

                spider.ParseHTML4NL();
            } else
            {
                spider.ParseHTML();
            }

            tbxTitle.Text = spider.Title;

            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());

            foreach (char c in invalid)
            {
                tbxTitle.Text = tbxTitle.Text.Replace(c.ToString(), "");
            }
            
            tbxPrice.Text = spider.Price;
            tbxCurrCode.Text = spider.CurrencyCode;
            tbxMainImageCount.Text = spider.MainImageList.Count.ToString();
            tbxContentImageCount.Text = spider.ContentImageList.Count.ToString();
            tbxBtImageCount.Text = spider.BiantiImageList.Count.ToString();
            tbxSkuCount.Text = spider.ProductSkuItemList.Count.ToString();

            CreateProperty();
            LoadListView();

            groupBox2.Enabled = true;
        }

        private void LoadListView()
        {
            

            this.listView1.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            this.listView1.Clear();

            //设置属性
            this.listView1.GridLines = true;  //显示网格线
            this.listView1.FullRowSelect = true;  //显示全行
            this.listView1.MultiSelect = false;  //设置只能单选
            this.listView1.View = View.Details;  //设置显示模式为详细

            this.listView1.Columns.Add("SkuId", 120);    //将列头添加到ListView控件。
            this.listView1.Columns.Add("价格", 120);
            this.listView1.Columns.Add("名称", 120);

            foreach (var item in spider.PropertyDict)
            {
               this.listView1.Columns.Add("属性: [" + item.Key.Replace(":","") + "]", 120);
            }
            
            for (int i = 0; i < spider.ProductSkuItemList.Count; i++)   
            {
                SkuItem skuitem = spider.ProductSkuItemList[i];
                ListViewItem lvi = new ListViewItem();
                lvi.Text = skuitem.SkuId;
                lvi.SubItems.Add(skuitem.Price);
                lvi.SubItems.Add(skuitem.Title);
                foreach (var item in skuitem.Propertys)
                {
                    lvi.SubItems.Add(item);
                }
                this.listView1.Items.Add(lvi);

            }

            this.listView1.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        }

        private void CreateProperty()
        {
            //

            int i = 0;
            foreach (KeyValuePair<string, List<SkuPropertyValue>> pair in spider.PropertyDict)
            {

                int cellWidth = 250;
                int x = i * cellWidth + 20;

                Label lbl = new Label();//声明一个label
                lbl.Location = new System.Drawing.Point(x, 10);//设置位置
                lbl.Size = new Size(cellWidth, 20);//设置大小
                lbl.Text = pair.Key;//设置Text值
                panelProperty.Controls.Add(lbl);

                int k = 0;
                foreach (var propertyValue in pair.Value)
                {

                    int rowHeight = 20;
                    int z = k * rowHeight + 30;

                    TextBox tb = new TextBox();//声明一个TextBox
                    tb.Location = new System.Drawing.Point(x, z);//设置位置
                    tb.Size = new Size(200, 20);//设置大小
                    string value = propertyValue.ImageUrl;
                    if (value == null)
                    {
                        value = propertyValue.Name;
                    }

                    tb.Text = value;
                    panelProperty.Controls.Add(tb);

                    k++;
                }

                i++;
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = tbxSavePath.Text + @"\" + tbxTitle.Text;
            path += @"\主图";
            Console.WriteLine(path);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            int i = 0;
            foreach (string item in spider.MainImageList)
            {
                i++;
                string fileName = i + ".jpg";
                HttpUtils.HttpDownloadFile(item, path + @"\" + fileName);
            }

            MessageBox.Show("下载完成！", "提示");

        }


        private void btnDownDescHtml_Click(object sender, EventArgs e)
        {
            string path = tbxSavePath.Text + @"\" + tbxTitle.Text;
            path += @"\商品详情html代码";
            Console.WriteLine(path);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filePath = path + @"\desc.txt";

            File.WriteAllText(filePath, spider.DescHtml);
            
        }

        private void btnDownloadContentImg_Click_1(object sender, EventArgs e)
        {
            string path = tbxSavePath.Text + @"\" + tbxTitle.Text;
            path += @"\内容图";
            Console.WriteLine(path);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            int i = 0;
            foreach (string item in spider.ContentImageList)
            {
                i++;
                string fileName = i + ".jpg";
                HttpUtils.HttpDownloadFile(item, path + @"\" + fileName);
            }

            MessageBox.Show("下载完成！", "提示");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("此版本暂未添加！请添加QQ群获取最新版本！", "提示");

            // 图片下载工具
            // 
            //string path = tbxSavePath.Text + @"\" + tbxTitle.Text;
            //path += @"\测试图";
            //Console.WriteLine(path);

            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}

            //int i = 0;


            //string url = "https://www.meib-life.com/products/%E6%97%A5%E6%9C%ACiris-kitchen-chef-%E9%91%BD%E7%9F%B3%E5%A1%97%E5%B1%A4%E4%B8%8D%E6%B2%BE%E5%B9%B3%E5%BA%95%E9%8D%8B-20%E5%90%8B";
            //string html = HttpUtils.HttpGet(url);
            //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            //doc.LoadHtml(html);

            ////HtmlNode producetNode = doc.DocumentNode.SelectSingleNode("//div[@id='j-product-info-sku']");
            //HtmlNodeCollection imgs = doc.DocumentNode.SelectNodes(".//img");
            //foreach (var item in imgs)
            //{
            //    if (item.Attributes.Contains("src"))
            //    {
                    
            //        i++;
            //        string fileName = i + ".jpg";
            //        HttpUtils.HttpDownloadFile(item.Attributes["src"].Value, path + @"\" + fileName);
            //    }

            //}

        }

        private void btnClearUrl_Click(object sender, EventArgs e)
        {
            tbxUrl.Text = "";
        }

        private void btnDownloadBTImg_Click(object sender, EventArgs e)
        {
            string path = tbxSavePath.Text + @"\" + tbxTitle.Text;
            path += @"\变体图";
            Console.WriteLine(path);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            int i = 0;
            foreach (string item in spider.BiantiImageList)
            {
                i++;
                string fileName = i + ".jpg";
                HttpUtils.HttpDownloadFile(item, path + @"\" + fileName);
            }

            MessageBox.Show("下载完成！", "提示");
        }
    }
    
}
