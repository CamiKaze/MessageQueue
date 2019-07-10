using RabbitMQ.Client;
using System;
using System.Text;

namespace SendToRabbitMQ
{
    public class Program
    {
        static void Main(string[] args)
        { // Get name from user, send message ID and string to Send Method
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            Send("MSGID", $"Hello my name is {Name}");
        }
        public static bool Send(string queue, string data)
        { // Accept message ID and string
            bool acks = false;
            using (IConnection connection = new ConnectionFactory().CreateConnection())
            { // Create and use rabbitMQ connection details
                using (IModel channel = connection.CreateModel())
                {   // Name of queue, Publish message with mandatory and immediate flags set to false
                    channel.QueueDeclare(queue, false, false, false, null);
                    // Set acknowledgement
                    channel.BasicAcks += (sender, eventargs) =>
                    { acks = true; };
                    channel.ConfirmSelect();
                    channel.BasicPublish(string.Empty, queue, null, Encoding.UTF8.GetBytes(data));
                    channel.WaitForConfirmsOrDie();
                }
            }
            return acks;
        }
    }
}