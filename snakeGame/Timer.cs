using System;
using System.Timers;
using Raylib_cs;

namespace snakeGame
{
    public class Timer : MonoBehaviour
    {

        private System.Timers.Timer aTimer = new System.Timers.Timer();


        public void setTimer( int speed){
            aTimer.Interval = speed; 
        }
        public Timer()
        {
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 500;
            aTimer.Enabled = true;
        }



        public virtual void OnTimedEvent(object source, ElapsedEventArgs e)
        {

        }

    }


}