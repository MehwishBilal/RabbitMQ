using MassTransit;
using Newtonsoft.Json;
using OrderS.Model;
using System.Text;

namespace InventoryS
{
    public class OrderConsumer : IConsumer <Order>
    {
        public async Task Consume(ConsumeContext<Order> context)
        {
            var msg = context.Message;

            //To Do
            await Console.Out.WriteLineAsync(msg.Detail);
        }

        //public async Task Consume(ConsumeContext<Order> context)
        //{
        //    var msg = context.Message;
        //    var receivedMessage = JsonConvert.DeserializeObject(Encoding.UTF8.GetString(msg.Detail));
        //    //To Do
        //    await Console.Out.WriteLineAsync(receivedMessage.ToString());
        //}

    }
}
