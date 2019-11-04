using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class JobChangedEventArgs:EventArgs
    {
        public JobChangedEventArgs(Job job):base()
        {
            Job = job;
        }
        public Job Job { get; set; }
    }
}
