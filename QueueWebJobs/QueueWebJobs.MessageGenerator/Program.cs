using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueWebJobs.MessageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create queue
            // Retrieve storage account from connection string.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                CloudConfigurationManager.GetSetting("StorageConnectionString"));

            // Create the queue client.
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Retrieve a reference to a container.
            CloudQueue queue = queueClient.GetQueueReference("danielqueue");

            // Create the queue if it doesn't already exist
            queue.CreateIfNotExists();

            // Create queue
            CloudQueueMessage message = new CloudQueueMessage("Hey, do this job for me :)");
            queue.AddMessage(message);

            // Peek at the next message
            CloudQueueMessage peekedMessage = queue.PeekMessage();

            // Display message. Make sure message is added into queue.
            Console.WriteLine(peekedMessage.AsString);
        }
    }
}
