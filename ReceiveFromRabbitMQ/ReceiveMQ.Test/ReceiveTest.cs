using System;
using Xunit;
using ReceiveFromRabbitMQ;

namespace ReceiveMQ.Test
{
    public class ReceiveTest
    {
        [Fact]
        public void Receiver()
        {
            string expected = "Cameron";
            string Name = Program.GetName($"Hello my name is Cameron");
            Assert.Equal(expected, Name);
        }
    }
}
