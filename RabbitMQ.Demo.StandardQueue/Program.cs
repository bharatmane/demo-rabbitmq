using RabbitMQ.Client;

namespace RabbitMQ.Demo.StandardQueue
{
    private static ConnectionFactory _factory;
    private static IConnection _connection;
    private static IModel _model;

    private const string QueueName = "StandardQueue_ExampleQueue";

}