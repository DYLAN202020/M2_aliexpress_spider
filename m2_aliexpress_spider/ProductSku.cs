using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2_aliexpress_spider
{
    public class ProductSku
    {
        public ProductItem[] ProductItems { get; set; }
    }

    public class ProductItem
    {
        public string skuAttr { get; set; }
        public long skuId { get; set; }
        public string skuPropIds { get; set; }
        public SkuVal skuVal { get; set; }
    }

    public class SkuVal
    {
        public string actSkuCalPrice { get; set; }
        public string actSkuMultiCurrencyCalPrice { get; set; }
        public string actSkuMultiCurrencyDisplayPrice { get; set; }
        public int availQuantity { get; set; }
        public int inventory { get; set; }
        public bool isActivity { get; set; }
        public object[] optionalWarrantyPrice { get; set; }
        public SkuactivityAmount skuActivityAmount { get; set; }
        public SkuAmount skuAmount { get; set; }
        public string skuCalPrice { get; set; }
        public string skuMultiCurrencyCalPrice { get; set; }
        public string skuMultiCurrencyDisplayPrice { get; set; }
    }

    public class SkuactivityAmount
    {
        public string currency { get; set; }
        public string formatedAmount { get; set; }
        public float value { get; set; }
    }

    public class SkuAmount
    {
        public string currency { get; set; }
        public string formatedAmount { get; set; }
        public float value { get; set; }
    }
}
