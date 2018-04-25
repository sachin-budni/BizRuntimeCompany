using org.apache.rocketmq.client.producer;
using org.apache.rocketmq.common.message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    class Async:SendCallback
    {
        private static object final;

        static void Main(string[] args)
        {
            DefaultMQProducer producer = new DefaultMQProducer("ExampleProducerGroup");
            //Launch the instance.
            producer.start();
            producer.setRetryTimesWhenSendAsyncFailed(0);
            for (int i = 0; i < 100; i++)
            {
                int index = i;
                //Create a message instance, specifying topic, tag and message body.
                var mes = Encoding.UTF8.GetBytes("Hello world");
                Message msg = new Message("TopicTest", "TagA", "OrderID188", mes);//"Hello world".getBytes(RemotingHelper.DEFAULT_CHARSET));
                                                                                  //producer.send(msg,SendCallback);
                SendCallback calls = new SendCallback()
                {
                    public void onSuccess(SendResult sendResult)
                    {
                        //System.out.printf("%-10d OK %s %n", index,
                        //  sendResult.getMsgId());
                    }
                    public void onException(Exception e)
                    {
                        //System.out.printf("%-10d Exception %s %n", index, e);
                        //  e.printStackTrace();
                    }
                };


                //producer.send(msg,new SendCallback()
                //{
                //    public void onSuccess(SendResult sendResult)
                //    {
                //        //System.out.printf("%-10d OK %s %n", index,
                //        //  sendResult.getMsgId());
                //    }
                //    public void onException(Exception e)
                //    {
                //        //System.out.printf("%-10d Exception %s %n", index, e);
                //        //  e.printStackTrace();
                //    }
                //});
	        }
            //Shut down once the producer instance is not longer in use.
            producer.shutdown();
        }

    }
}
