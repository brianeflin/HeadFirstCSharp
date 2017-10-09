
namespace BeehiveManagementSystem
{
    class Queen : Bee
    {
        private Worker[] workers = new Worker[4];
        private int shiftNumber;

        public Queen(double weightInMg, Worker[] workers)
            : base(weightInMg)
        {
            this.workers = workers;
        }

        public bool AssignWork(string job, int shifts)
        {
            foreach (Worker worker in workers)
            {
                if (worker.DoThisJob(job, shifts))
                    return true;
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            double honeyConsumed = this.HoneyConsumptionRate();

            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + "\r\n";

            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].DidYouFinish())
                    report += "Worker #" + (i + 1) + " finished the job.\r\n";

                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " does not have a job. \r\n";
                else
                {
                    if (workers[i].ShiftsLeft > 0)
                        report += "Worker #" + (i + 1) + " is doing '" + workers[i].CurrentJob +
                            "' for " + workers[i].ShiftsLeft + " more shifts.\r\n";
                    else
                        report += "Worker #" + (i + 1) + " will be done with '" + workers[i].CurrentJob +
                            "' after this shift.\r\n";
                }
                honeyConsumed += workers[i].HoneyConsumptionRate();
            }
            report += "Total honey consumed for the shift: " + honeyConsumed + " units.";

            return report;
        }
    }
}
