using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication6
{
    class Goods
    {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga)
        {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override String ToString()
        {
            return goodsno + ":" + gname + ":"
                    + danga ;
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum{ get; set; }
        

        public Cart(Goods goods, int count)
        {
            this.goods = goods;
            this.count = count;
            this.sum = this.goods.danga*count;
        }

        public override String ToString()
        {
            return goods + ":" + count + ":" + sum;
                    
        }
    }

    class CartTest
    {
        static void Main()
        {
            Goods product1 = new Goods(1001, "볼펜", 1000);
            Goods product2 = new Goods(1002, "연필", 500);
            Goods product3 = new Goods(1003, "딸기", 6000);
            Cart rcp1 = new Cart(product1,2);
            Cart rcp2 = new Cart(product2,3);
            Cart rcp3 = new Cart(product3,2);

            Dictionary<int, Cart> test = new Dictionary<int, Cart>();
            test.Add(1, rcp1);
            test.Add(2, rcp2);
            test.Add(3, rcp3);

            foreach (KeyValuePair<int, Cart> d in test)
            {
                Console.WriteLine("{0}:{1}", d.Key, d.Value);
            }
        }
    }
}
