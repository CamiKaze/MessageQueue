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
=======
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


```bash
"Hello my name is, {Name}" is sent to RabbitMQ
```
You can view the queue in your browser by navigating to the URL:

```bash
http://<localhost>:15672/#/queues
```

### ReceiveFromRabbitMQ
Enter folder and double-click on ReceiveFromRabbitMQ.sln
In Visual Studio (2017/2019), run the application.
The queue will be retrieved from RabbitMQ and the following text will display:

```bash
"Hello {ReceivedName}, I am your father!"
```
=======
"Hello my name is, {Name}" is sent to RabbitMQ
You can view the queue in your browser by navigating to the URL:
http://<localhost>:15672/#/queues

ReceiveFromRabbitMQ
Enter folder and double-click on ReceiveFromRabbitMQ.sln
In Visual Studio (2017/2019), run the application.
The queue will be retrieved from RabbitMQ and the following text will display:
"Hello {ReceivedName}, I am your father!"
>>>>>>> 349c67cf37e507b9a61d2b9611cfdf1071bb6d3e
