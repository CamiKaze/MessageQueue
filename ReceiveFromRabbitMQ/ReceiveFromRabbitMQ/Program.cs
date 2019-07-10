using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Linq;
using System.Text;

namespace ReceiveFromRabbitMQ
{
    public class Program
    {
        static void Main(string[] args)
        { // Read specific ID from queue
            Receive("MSGID");
            Console.ReadLine();
        }

        public static void Receive(string queue)
        { // Receive message and print
            using (IConnection connection = new ConnectionFactory().CreateConnection())
            { // Create and use rabbitMQ connection details
                using (IModel channel = connection.CreateModel())
                { // Declare a queue, Dispatch deliveries, Check queue for data
                    channel.QueueDeclare(queue, false, false, false, null);
                    var consumer = new EventingBasicConsumer(channel);
                    BasicGetResult result = channel.BasicGet(queue, true);
                    if (result == null)
                        Console.WriteLine("No messages found.");
                    else
                    {
                        string data = Encoding.UTF8.GetString(result.Body);
                        var Name = GetName(data);
                        Console.WriteLine($"Hello {Name}, I am your Father!");
                    }
                }
            }
        }

        public static string GetName(string data)
        {
            string Name = data.Split(' ').Last();
            return Name;
        }
    }
}
