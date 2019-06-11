namespace m2_aliexpress_spider
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUrl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LABLE2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gbxProperty = new System.Windows.Forms.GroupBox();
            this.panelProperty = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDownDescHtml = new System.Windows.Forms.Button();
            this.tbxCurrCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSkuCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxSavePath = new System.Windows.Forms.TextBox();
            this.btnDownloadContentImg = new System.Windows.Forms.Button();
            this.tbxContentImageCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDownMain = new System.Windows.Forms.Button();
            this.tbxMainImageCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnClearUrl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(643, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "速卖通商品详情网址:";
            // 
            // tbxUrl
            // 
            this.tbxUrl.Location = new System.Drawing.Point(143, 23);
            this.tbxUrl.Name = "tbxUrl";
            this.tbxUrl.Size = new System.Drawing.Size(494, 21);
            this.tbxUrl.TabIndex = 2;
            this.tbxUrl.Text = resources.GetString("tbxUrl.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearUrl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.tbxUrl);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 57);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "M2技术社区QQ群：798456228，大量征集产品建议，获取最新版本";
            // 
            // LABLE2
            // 
            this.LABLE2.AutoSize = true;
            this.LABLE2.Location = new System.Drawing.Point(18, 30);
            this.LABLE2.Name = "LABLE2";
            this.LABLE2.Size = new System.Drawing.Size(65, 12);
            this.LABLE2.TabIndex = 4;
            this.LABLE2.Text = "商品标题：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Controls.Add(this.gbxProperty);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnDownDescHtml);
            this.groupBox2.Controls.Add(this.tbxCurrCode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbxSkuCount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbxSavePath);
            this.groupBox2.Controls.Add(this.btnDownloadContentImg);
            this.groupBox2.Controls.Add(this.tbxContentImageCount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnDownMain);
            this.groupBox2.Controls.Add(this.tbxMainImageCount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxPrice);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxTitle);
            this.groupBox2.Controls.Add(this.LABLE2);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 530);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "执行结果";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(20, 420);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(779, 104);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // gbxProperty
            // 
            this.gbxProperty.Controls.Add(this.panelProperty);
            this.gbxProperty.Location = new System.Drawing.Point(20, 170);
            this.gbxProperty.Name = "gbxProperty";
            this.gbxProperty.Size = new System.Drawing.Size(782, 217);
            this.gbxProperty.TabIndex = 23;
            this.gbxProperty.TabStop = false;
            this.gbxProperty.Text = "商品属性";
            // 
            // panelProperty
            // 
            this.panelProperty.AutoScroll = true;
            this.panelProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProperty.Location = new System.Drawing.Point(3, 17);
            this.panelProperty.Name = "panelProperty";
            this.panelProperty.Size = new System.Drawing.Size(776, 197);
            this.panelProperty.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "生成Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDownDescHtml
            // 
            this.btnDownDescHtml.Location = new System.Drawing.Point(330, 141);
            this.btnDownDescHtml.Name = "btnDownDescHtml";
            this.btnDownDescHtml.Size = new System.Drawing.Size(165, 23);
            this.btnDownDescHtml.TabIndex = 19;
            this.btnDownDescHtml.Text = "下载商品详情 Html 代码";
            this.btnDownDescHtml.UseVisualStyleBackColor = true;
            this.btnDownDescHtml.Click += new System.EventHandler(this.btnDownDescHtml_Click);
            // 
            // tbxCurrCode
            // 
            this.tbxCurrCode.Location = new System.Drawing.Point(399, 56);
            this.tbxCurrCode.Name = "tbxCurrCode";
            this.tbxCurrCode.Size = new System.Drawing.Size(96, 21);
            this.tbxCurrCode.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "价格单位：";
            // 
            // tbxSkuCount
            // 
            this.tbxSkuCount.Location = new System.Drawing.Point(92, 391);
            this.tbxSkuCount.Name = "tbxSkuCount";
            this.tbxSkuCount.Size = new System.Drawing.Size(96, 21);
            this.tbxSkuCount.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "变体数量：";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(724, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "浏览";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "文件存储：";
            // 
            // tbxSavePath
            // 
            this.tbxSavePath.Location = new System.Drawing.Point(89, 86);
            this.tbxSavePath.Name = "tbxSavePath";
            this.tbxSavePath.Size = new System.Drawing.Size(629, 21);
            this.tbxSavePath.TabIndex = 12;
            // 
            // btnDownloadContentImg
            // 
            this.btnDownloadContentImg.Location = new System.Drawing.Point(191, 141);
            this.btnDownloadContentImg.Name = "btnDownloadContentImg";
            this.btnDownloadContentImg.Size = new System.Drawing.Size(75, 23);
            this.btnDownloadContentImg.TabIndex = 9;
            this.btnDownloadContentImg.Text = "下载";
            this.btnDownloadContentImg.UseVisualStyleBackColor = true;
            this.btnDownloadContentImg.Click += new System.EventHandler(this.btnDownloadContentImg_Click_1);
            // 
            // tbxContentImageCount
            // 
            this.tbxContentImageCount.Location = new System.Drawing.Point(113, 143);
            this.tbxContentImageCount.Name = "tbxContentImageCount";
            this.tbxContentImageCount.Size = new System.Drawing.Size(72, 21);
            this.tbxContentImageCount.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "详细内容图片：";
            // 
            // btnDownMain
            // 
            this.btnDownMain.Location = new System.Drawing.Point(191, 113);
            this.btnDownMain.Name = "btnDownMain";
            this.btnDownMain.Size = new System.Drawing.Size(75, 23);
            this.btnDownMain.TabIndex = 3;
            this.btnDownMain.Text = "下载";
            this.btnDownMain.UseVisualStyleBackColor = true;
            this.btnDownMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxMainImageCount
            // 
            this.tbxMainImageCount.Location = new System.Drawing.Point(113, 115);
            this.tbxMainImageCount.Name = "tbxMainImageCount";
            this.tbxMainImageCount.Size = new System.Drawing.Size(72, 21);
            this.tbxMainImageCount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "商品主图数量：";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(89, 56);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(96, 21);
            this.tbxPrice.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "最高价格：";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(89, 27);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(710, 21);
            this.tbxTitle.TabIndex = 3;
            // 
            // btnClearUrl
            // 
            this.btnClearUrl.Location = new System.Drawing.Point(724, 20);
            this.btnClearUrl.Name = "btnClearUrl";
            this.btnClearUrl.Size = new System.Drawing.Size(75, 23);
            this.btnClearUrl.TabIndex = 3;
            this.btnClearUrl.Text = "清空";
            this.btnClearUrl.UseVisualStyleBackColor = true;
            this.btnClearUrl.Click += new System.EventHandler(this.btnClearUrl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "M2社区 - 速卖通商品详情抓取工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxProperty.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LABLE2;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownMain;
        private System.Windows.Forms.TextBox tbxMainImageCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDownloadContentImg;
        private System.Windows.Forms.TextBox tbxContentImageCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxSavePath;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSkuCount;
        private System.Windows.Forms.TextBox tbxCurrCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDownDescHtml;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbxProperty;
        private System.Windows.Forms.Panel panelProperty;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnClearUrl;
    }
}

