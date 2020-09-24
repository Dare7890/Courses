using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF06_BeePart2
{
    class Worker : Bee
    {
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
        private string currentJob = "";

        public Worker(string[] work, double weightMg) : base(weightMg)
        {
            jobsICanDo = work;
        }

        public bool DoThisJob(string work, int shift)
        {
            if (String.IsNullOrEmpty(currentJob))
            {
                foreach (var job in jobsICanDo)
                {
                    if (job == work)
                    {
                        currentJob = job;
                        shiftsToWork = shift;
                        shiftsWorked = 0;
                        return true;
                    }
                }
            }
            return false;
        }

        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (ShiftsLeft == 0)
            {
                currentJob = "";
                shiftsWorked = 0;
                shiftsToWork = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override double HoneyConsumptionRate()
        {
            double consumption = base.HoneyConsumptionRate();
            consumption += shiftsWorked * 0.65;
            return consumption;
        }
    }
}
