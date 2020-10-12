using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF15_BallEvent
{
    class Fun
    {
        public ObservableCollection<string> FunSays = new ObservableCollection<string>();

        public Fun(Ball ball)
        {
            ball.BallInPlay += Ball_BallInPlay;
        }

        private void Ball_BallInPlay(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance <= 400) && (ballEventArgs.Trajectory <= 30))
                    FunSay();
                else
                    FunTryCatch();
            }
        }

        private void FunTryCatch()
        {
            FunSays.Add("Хоум-ран. Пытаюсь поймать мяч");
        }

        private void FunSay()
        {
            FunSays.Add("Фанат кричит");
        }
    }
}
