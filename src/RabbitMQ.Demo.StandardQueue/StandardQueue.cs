using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Demo.StandardQueue
{
    public class StandardQueue
    {
        private static ConnectionFactory _factory;
        private static IConnection _connection;
        private static IModel _model;

        private readonly string _queueName;
        private readonly string _hostName;
        private readonly string _userName;
        private readonly string _password;

        public StandardQueue(string name,string hostName, string userName, string password)
        {
            this._queueName = name;
            this._hostName = hostName;
            this._userName = userName;
            this._password = password;
        }
        public uint GetMessageCount(string queueName)
        {
            var results = _model.QueueDeclare(queueName, true, false, false, null);
            return results.MessageCount;
        }

        public void CreateQueue()
        {
            _factory = new ConnectionFactory { HostName = this._hostName, UserName = this._userName, Password = this._password};
            _connection = _factory.CreateConnection();
            _model = _connection.CreateModel();

            _model.QueueDeclare(_queueName, true, false, false, null);
        }
    }
}
