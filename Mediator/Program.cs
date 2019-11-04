using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {

            for(; ; )
            {
                Console.WriteLine("Select job ID from 1 to 5");
                if(!int.TryParse(Console.ReadLine(), out int result))
                {
                    Console.WriteLine("Please select from 1 to 5");
                    continue;
                }
                //multiple objects which should not know anything about the selection
                var details = new JobDetails();

                var job = new Job();
                job.OnJobSelection(result);


                Console.WriteLine("Press Q to exit");

                if (Console.ReadLine().ToUpper() == "Q")
                    break;

                Console.WriteLine("Press Any key to continue;");
            }
        }
    }
}
