using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace SendToRabbitMQ
{
    class Program
    {
        static void Main(string[] args)
        { // Get name from user, send message ID and string to Send Method
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Send("MSGID", $"Hello my name is {Name}");
        }
        public static void Send(string queue, string data)
        { // Accept message ID and string
            using (IConnection connection = new ConnectionFactory().CreateConnection())
            { // Create and use rabbitMQ connection details
                using (IModel channel = connection.CreateModel())
                {   // Name of queue, Publish message with mandatory and immediate flags set to false
                    channel.QueueDeclare(queue, false, false, false, null);
                    channel.BasicPublish(string.Empty, queue, null, Encoding.UTF8.GetBytes(data));
                    Console.WriteLine($"Message Sent: {data}");
                    Console.ReadKey();
                }
            }
        }
    }
}