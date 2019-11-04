using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public sealed class Mediator
    {
        private static readonly Mediator _Instance = new Mediator();

        private Mediator()
        {

        }

        public static Mediator GetInstance()
        {
            return _Instance;
        }

        public event EventHandler<JobChangedEventArgs> JobChanged;

        public void OnJobChanged(object sender, Job job)
        {
            if (JobChanged == null)
                return;

            JobChanged(sender, new JobChangedEventArgs(job));
        }
    }
}
