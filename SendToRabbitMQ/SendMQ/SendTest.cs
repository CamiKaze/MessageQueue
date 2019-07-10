using System;
using Xunit;
using SendToRabbitMQ;

namespace SendMQ
{
    public class SendTest
    {
        [Fact]
        public void Sender()
        {
            string queue = "MSGID";
            string data = $"Hello my name is Cameron";
            bool expected = true;
            bool a = Program.Send(queue, data);
            Assert.Equal(expected, a);
        }
    }
}