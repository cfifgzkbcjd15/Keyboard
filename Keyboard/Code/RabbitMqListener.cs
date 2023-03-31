using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using System.Diagnostics;
using System.Text.Json;
using Keyboard.Models;
using Keyboard.Data;

namespace Keyboard.Code
{
    public class RabbitMqListener : BackgroundService
    {
        private IConnection _connection;
        private IModel _channel;
        public Repository _repository;

        public RabbitMqListener()
        {
            _repository=new Repository();
            // Не забудьте вынести значения "localhost" и "MyQueue"
            // в файл конфигурации
            var factory = new ConnectionFactory { Uri = new Uri("amqps://apxnlkkv:7M5gMijKZRT2WCRM5jq6ci2vprJ3fCvP@rattlesnake.rmq.cloudamqp.com/apxnlkkv") };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(queue: "file.changes.v1-dwh", durable: false, exclusive: false, autoDelete: false, arguments: null);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            stoppingToken.ThrowIfCancellationRequested();

            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (ch, ea) =>
            {
                try { 
                var content = Encoding.UTF8.GetString(ea.Body.ToArray());
                var result=JsonSerializer.Deserialize<Contract>(content);
                // Каким-то образом обрабатываем полученное сообщение
                _repository.JsonToBase(result);

                _channel.BasicAck(ea.DeliveryTag, false);
                }
                catch(Exception ex)
                {
                    Debug.Write(ex.Message);
                }
            };

            _channel.BasicConsume("file.changes.v1-dwh", false, consumer);

            return Task.CompletedTask;
        }

        public override void Dispose()
        {
            _channel.Close();
            _connection.Close();
            base.Dispose();
        }
    }
}
