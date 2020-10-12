using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace HF15_BallEvent
{
    class BaseballSimulator
    {
        private Ball ball = new Ball();
        private Pitcher pitcher;
        private Fun fun;

        public ObservableCollection<string> FunSays { get { return fun.FunSays; } }
        public ObservableCollection<string> PitcherSays { get { return pitcher.PitcherSays; } }

        public int Trajectory { get; set; }
        public int Distance { get; set; }

        public BaseballSimulator()
        {
            pitcher = new Pitcher(ball);
            fun = new Fun(ball);
        }

        public void PlayBall()
        {
            Bat bat = ball.GetNewBat();
            BallEventArgs ballEventArgs = new BallEventArgs(Trajectory, Distance);
            bat.HitTheBall(ballEventArgs);
        }
    }
}
