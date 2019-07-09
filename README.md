# .Net Core and RabbitMQ 
Publishing and Consuming messages with C# and RabbitMQ

## Getting started
### Installation

### Install Erlang.
Download and install the correct version of Erlang depending on the operating system that you are using.
Download and install RabbitMQ server. 

```bash
(https://www.erlang.org/downloads)
(https://www.rabbitmq.com/download.html)
```

Clone MessageQueue from the master branch of the Github repository

```bash
git clone git@github.com:CamiKaze/MessageQueue.git
```

You will be presented with two folders:

```bash
SendToRabbitMQ
ReceiveFromRabbitMQ
```

### SendToRabbitMQ
Enter the SendToRabbitMQ folder and double-click on the SendToRabbitMQ.sln file.
In Visual Studio (2017/2019), run the application.
You will be asked to enter your name.
Enter your name and press enter.

```bash
"Hello my name is, {Name}" is sent to RabbitMQ
```
A message will be sent to RabbitMQ and stored in a queue.

You can view the queue in your browser by navigating to the URL:

```bash
http://<localhost>:15672/#/queues
```

### ReceiveFromRabbitMQ
Enter the ReceiveFromRabbitMQ folder and double-click on ReceiveFromRabbitMQ.sln file.
In Visual Studio (2017/2019), run the application.
The queue will be retrieved from RabbitMQ and the following text will display:

```bash
"Hello {ReceivedName}, I am your father!"
```
