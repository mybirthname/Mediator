using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator
{
    public class Job
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        private List<Job> JobList { get; set; }

        private List<Job> InitliazeJobs()
        {
            List<Job> list = new List<Job>();
            for (int i = 1; i < 6; i++)
            {
                list.Add(new Job()
                {
                    ID = i,
                    Title = $"Job {i}",
                    StartDate = DateTime.Now.AddDays(i),
                    EndDate = DateTime.Now.AddMonths(i)
                });
            }

            return list;
        }


        public Job()
        {
            
        }

        public void OnJobSelection(int jobID)
        {
            JobList = InitliazeJobs();
            var result = JobList.FirstOrDefault(x => x.ID == jobID);

            if(result == null)
                Console.WriteLine("Invalid job id please select from 1 to 5");

            Mediator.GetInstance().OnJobChanged(this, result);
        }
    }
}
