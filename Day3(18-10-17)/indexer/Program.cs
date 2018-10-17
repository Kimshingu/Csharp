using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    class Ojc<T>
    {
        private T[] ojcArr = new T[10];
        public T this[int i]
        {
            get { return ojcArr[i]; }
            set { ojcArr[i] = value; }
        }
    }

    public class Animation
    {
        private int total;
        private string[] title;
        private string distributor;
        private string date;
        private int price;
        public Animation(int total, string distributor, string date, int price)
        {
            this.total = total;
            this.title = new string[total];
            this.distributor = distributor;
            this.date = date;
            this.price = price;
        }
        public string this[int index]
        {
            get { return title[index]; }
            set { title[index] = value; }
        }
        public string getDistributor() { return distributor; }
        public int getPrice() { return price; }
        public int getTotal() { return total; }
    }

    class Program
    {   
        static void Main(string[] args)
        {
            Animation ani = new Animation(5, "한국애니", "10-27-2004", 35000);
            ani[0] = "인어공주";
            ani[1] = "신데렐라";
            ani[2] = "백설공주";
            ani[3] = "바보온달";
            ani[4] = "라이온킹";

            Console.WriteLine("배급사: {0}", ani.getDistributor());
            Console.WriteLine("가격: {0}", ani.getPrice());
            Console.WriteLine("----------------------------");

            for (int i = 0; i < ani.getTotal(); i++)
            {
                Console.WriteLine("Volume{0} : {1}", i, ani[i]);
            }
            Ojc<string> ojc1 = new Ojc<string>();
            ojc1[0] = "Hello, OJC";
            ojc1[1] = "Hello, OJC";
            ojc1[2] = "Hello, OJC";

            for (int i = 0; i < 10; i++) { Console.WriteLine(ojc1[i]); }
            

            Ojc<int> ojc2 = new Ojc<int>();
            ojc2[0] = 999;
            Console.WriteLine(ojc2[0]);

        }
    }
}
