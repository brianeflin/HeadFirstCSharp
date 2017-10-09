
namespace BeehiveManagementSystem
{
    class Worker : Bee
    {
        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }

        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;
        const double honeyUnitsPerShiftWorked = .65;

        public Worker(double weightInMg, string[] jobs)
            : base(weightInMg)
        {
            jobsICanDo = jobs;
        }

        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (string.IsNullOrEmpty(currentJob))
            {
                foreach (string jobICanDo in jobsICanDo)
                {
                    if (jobICanDo == job)
                    {
                        currentJob = job;
                        shiftsToWork = numberOfShifts;
                        shiftsWorked = 0;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if (string.IsNullOrEmpty(currentJob))
                return false;

            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                currentJob = "";
                shiftsToWork = 0;
                shiftsWorked = 0;
                return true;
            }

            return false;
        }

        public override double HoneyConsumptionRate()
        {
            return base.HoneyConsumptionRate() + (shiftsWorked * honeyUnitsPerShiftWorked);
        }
    }
}
