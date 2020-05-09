using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Goods
    {
        public string GoodsName { get; set; }

        public double goodsPrice;

        public double GetGoodsPrice() => goodsPrice;

        public Goods(string name)
        {
            GoodsName = name;
            NewMethod(name);
        }

        private void NewMethod(string name)
        {
            switch (name)
            {
                case "面包": goodsPrice = 5; break;
                case "矿泉水": goodsPrice = 1.5; break;
                case "卫龙": goodsPrice = 3; break;
                default: goodsPrice = 0; Console.WriteLine("没有该商品！请重新输入"); break;
            }
        }

        public override string ToString() => "[" + GoodsName + "," + GetGoodsPrice() + "]";
    }
}
