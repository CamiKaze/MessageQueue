# ColLab
Video Conferencing Application


## Getting started
### Installation
Clone ColLab from the master branch of Github repository

```bash
git clone git@github.com:CamiKaze/ColLab.git
```

Double click on Collab.csproj to open the solution via Visual Studio 2017/2019.

Run the application

```bash
go run main.go
```

The Websocket is now listening on the port `5000`, to change it just set it inside the applicationURL variable in launchSettings.json, found inside the Properties folder of the project.


### How to use
On startup, the application will open a browser and display data in JSON format found within the memory cached database.

```json
{
  "id":1,
  "productID":2125,
  "productName":"Cheese",
  "quantity":5,
  "createdDate":"0001-01-01T00:00:00",
  "shoppingCartID":1
}
```


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