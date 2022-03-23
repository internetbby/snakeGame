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
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 500;
            aTimer.Enabled = true;

        }

        public Timer(){
            setTimer(50);
        }


        public virtual void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            
        }

    }


}