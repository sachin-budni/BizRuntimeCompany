using org.apache.rocketmq.client.producer;
using org.apache.rocketmq.common.message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //DefaultMQProducer p = new DefaultMQProducer("test");
            //p.setNamesrvAddr("192.168.1.69:9876");
            //p.start();
            //var data = Encoding.UTF8.GetBytes("Hello From RocketMq");
            //Message m = new Message("TopicTest", "tagA", data);
            //se=p.send(m);
            //p.shutdown();

            //Instantiate with a producer group name.
            DefaultMQProducer producer = new DefaultMQProducer("please_rename_unique_group_name");
            producer.setNamesrvAddr("");
            //Launch the instance.
            producer.start();
            for (int i = 0; i < 100; i++)
            {
                var data = Encoding.UTF8.GetBytes("Hello From RocketMq"+i);
                Message msg = new Message("TopicTest", "TagA", data);//.getBytes(RemotingHelper.DEFAULT_CHARSET));
                //Call send message to deliver message to one of brokers.
                SendResult sendResult = producer.send(msg);
                Console.WriteLine(sendResult);
                //System.out.printf("%s%n", sendResult);
            }
            //Shut down once the producer instance is not longer in use.
            producer.shutdown();
            Console.ReadKey();
        }
    }
}
