using FluentAssertions;
using NUnit.Framework;


namespace RabbitMQ.Demo.StandardQueue.Test
{
    public class StandardQueueTest
    {
        public static string QUEUE_NAME = "StandardQueue_Demo";
        public static string HOST_NAME = "localhost";
        public static string USER_NAME = "guest";
        public static string PASSWORD = "guest";

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldBeEmptyWhenInitialized()
        {
            //Arrange
            StandardQueue standardQueue = new StandardQueue(QUEUE_NAME,HOST_NAME,USER_NAME,PASSWORD);
            standardQueue.CreateQueue();

            //Act
            uint messageCount = standardQueue.GetMessageCount(QUEUE_NAME);

            //Assert
            messageCount.Should().Be(0);
            
        }
    }
}