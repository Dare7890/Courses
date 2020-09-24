using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF06_BeePart2
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;
        private double totalHoney = 0.0d;

        public Queen(Worker[] workers, double weightMg) : base(weightMg)
        {
            this.workers = workers;
        }

        public bool AssignWork(string nameOfWork, int shiftNumber)
        {
            foreach (var worker in workers)
            {
                if (worker.DoThisJob(nameOfWork, shiftNumber))
                {
                    return true;
                }
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            shiftNumber++;
            totalHoney = 0.0d;
            string report = "Report for shift #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                totalHoney = HoneyConsumptionRate();
                if (workers[i].DidYouFinish())
                {
                    report += "Worker #" + (i + 1) + " finished the job\r\n";
                }
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " in not working\r\n";
                if (workers[i].ShiftsLeft == 1)
                    report += "Worker #" + (i + 1) + " will be done with " + workers[i].CurrentJob +
                        " after this shift\r\n";
                if (workers[i].ShiftsLeft > 1)
                    report += "Worker #" + (i + 1) + " is doing " + workers[i].CurrentJob +
                        " for " + workers[i].ShiftsLeft + " more shifts\r\n";
                totalHoney += workers[i].HoneyConsumptionRate();
            }
            report += "Total honey consumed for the shift: " + totalHoney + " units";
            return report;
        }


    }
}
