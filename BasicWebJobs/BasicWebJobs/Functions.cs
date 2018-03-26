using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace BasicWebJobs
{
    public class Functions
    {
#if true
        public static void TimerFunction([TimerTrigger("0 */5 * * * *")] TimerInfo timerInfo)
        {
            Console.WriteLine($"Timer job fired! at {DateTime.Now}");
        }

        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
        //public static void ProcessQueueMessage([QueueTrigger("queue")] string message, TextWriter log)
        //{
        //    log.WriteLine(message);
        //}
#else

#endif
    }
}
