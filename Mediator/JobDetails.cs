using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class JobDetails
    {
        public JobDetails()
        {
            Mediator.GetInstance().JobChanged += JobDetails_JobChanged;
        }

        private void JobDetails_JobChanged(object sender, JobChangedEventArgs e)
        {
            Console.WriteLine($"Job ID: {e.Job.ID}");
            Console.WriteLine($"Job Title: {e.Job.Title}");
            Console.WriteLine($"Job StartDate: {e.Job.StartDate}");
            Console.WriteLine($"Job EndDate: {e.Job.EndDate}");
        }
    }
}
