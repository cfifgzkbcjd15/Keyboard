using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using System.Diagnostics;
//using System.Text.Json;
using Newtonsoft.Json;
using ConsumerTwo.Data;
using ConsumerTwo.Models.OnlyContractProcedure;

namespace ConsumerTwo.Code
{
    public class RabbitMqListener : BackgroundService
    {
        private IConnection _connection;
        private IModel _channel;
        private MongoContext db;

        public RabbitMqListener(MongoContext _db)
        {
            // Не забудьте вынести значения "localhost" и "MyQueue"
            // в файл конфигурации
            var factory = new ConnectionFactory { Uri = new Uri("amqp://admin:admin@192.168.31.104:5672") };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.ExchangeDeclare("file.changes.v1", "topic", true, false, null);
            _channel.QueueDeclare(queue: "file.changes.v1-dwh", durable: true, exclusive: false, autoDelete: false, arguments: null);
            _channel.QueueBind("file.changes.v1-dwh", "file.changes.v1", "#", null);
            db = _db;
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            try
            {
                stoppingToken.ThrowIfCancellationRequested();

                var consumer = new EventingBasicConsumer(_channel);
                consumer.Received += async (ch, ea) =>
                {
                    var content = Encoding.UTF8.GetString(ea.Body.ToArray());
                    //var result = JsonSerializer.Deserialize<Contract>(content);
                    var result = JsonConvert.DeserializeObject<ContractProcedure>(content);
                    await db.CreateContractsProcedure(result);

                    
                    //_channel.BasicAck(ea.DeliveryTag, false);

                };

                _channel.BasicConsume("file.changes.v1-dwh", true, consumer);
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
            }
        }

        public override void Dispose()
        {
            _channel.Close();
            _connection.Close();
            base.Dispose();
        }
    }
}
