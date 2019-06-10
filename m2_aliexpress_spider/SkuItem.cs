using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2_aliexpress_spider
{
    public class SkuItem
    {
        public string SkuId { get; set; }
        public string Title { get; set; }
        public List<string> Propertys { get; set; }
        public string Price { get; set; }

    }
}
