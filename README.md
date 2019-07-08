# MessageQueue
Publishing and Consuming messages with C# and RabbitMQ
.Net Core and RabbitMQ 
Publishing and Consuming messages with C# and RabbitMQ

Getting started
Installation

Install Erlang.
Download and install the correct version of Erlang depending on the operating system that you are using. (https://www.erlang.org/downloads)
Download and install RabbitMQ server. (https://www.rabbitmq.com/download.html)

Clone MessageQueue from the master branch of the Github repository

git clone git@github.com:CamiKaze/MessageQueue.git

You will be presented with two folders:
SendToRabbitMQ
ReceiveFromRabbitMQ

SendToRabbitMQ
Enter folder and double-click on SendToRabbitMQ.sln.
In Visual Studio (2017/2019), run the application.
You will be asked to enter your name.
Enter name and press enter.
A message will be sent to RabbitMQ and stored in a queue.
"Hello my name is, {Name}" is sent to RabbitMQ
You can view the queue in your browser by navigating to the URL:
http://<localhost>:15672/#/queues

ReceiveFromRabbitMQ
Enter folder and double-click on ReceiveFromRabbitMQ.sln
In Visual Studio (2017/2019), run the application.
The queue will be retrieved from RabbitMQ and the following text will display:
"Hello {ReceivedName}, I am your father!"
