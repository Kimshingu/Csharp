using System;
namespace ConsoleApplication1
{
    class EventPublisherArgs : System.EventArgs {
        public string myEventData;
        public EventPublisherArgs(string myEventData) {
            this.myEventData = myEventData;
        }
    }

    //이벤트 게시자 클래스, 이벤트를 발생시키는 객체
    class EventPublisher
    {
        public delegate void MyEventHandler(object sender, EventPublisherArgs e); //이벤트처리를위한델리게이트정의
        public event MyEventHandler MyEvent; //이벤트 정의
        public void Do()
        {
            //이벤트 가입자가 있는지 확인
            if (MyEvent != null)
            {
                EventPublisherArgs args = new EventPublisherArgs("데이터");
                MyEvent(this, args);

            }
        }
    }
    //구독자 클래스
    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();

            p.MyEvent += new EventPublisher.MyEventHandler(doAction);
            p.MyEvent += doAction;
            p.MyEvent += delegate (object sender, EventPublisherArgs e)
            {
                Console.WriteLine("MyEvent 라는 이벤트 발생...");
            };
           
            p.Do();
        }
        
        static void doAction(object sender, EventPublisherArgs e)
        {
            Console.WriteLine("MyEvent 라는 이벤트 발생...");
            Console.WriteLine("이벤트 매개변수 : " + e.myEventData);

        }
    }
}