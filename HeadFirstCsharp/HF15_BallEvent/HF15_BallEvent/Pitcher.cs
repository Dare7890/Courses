using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF15_BallEvent
{
    class Pitcher
    {
        public ObservableCollection<string> PitcherSays = new ObservableCollection<string>();

        public Pitcher(Ball ball)
        {
            ball.BallInPlay += Ball_BallInPlay;
        }

        private void Ball_BallInPlay(object sender, EventArgs e)
        {
            if (e is BallEventArgs)
            {
                BallEventArgs ballEventArgs = e as BallEventArgs;
                if ((ballEventArgs.Distance < 95) && (ballEventArgs.Trajectory < 60))
                    CatchBall();
                else
                    CoverFirstBase();
            }
        }

        private void CoverFirstBase()
        {
            PitcherSays.Add("Защитник перебежал на первую базу");
        }

        private void CatchBall()
        {
            PitcherSays.Add("Защитник поймал мяч");
        }
    }
}
