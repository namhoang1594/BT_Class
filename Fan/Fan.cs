using System;
using System.Collections.Generic;
using System.Text;

namespace Fan
{
    class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;

        private int Speed;
        public void setSpeed(int speed)
        {
            Speed = speed;
        }
        public int getSpeed()
        {
            if (Speed == 2)
            {
                return MEDIUM;
            }
            else if (Speed == 3)
            {
                return FAST;
            }
            else
            {
                return SLOW;
            }
        }
        private bool on = true;
        public bool geton()
        {
            return on;
        }
        public void seton(bool on)
        {
            this.on = on;
        }

        private double Radius = 5;
        public double getRadius()
        {
            return Radius;
        }
        public void setRadius(double Radius)
        {
            this.Radius = Radius;
        }

        private string Color = "Blue";
        public string getColor()
        {
            return Color;
        }
        public void setColor(string Color)
        {
            this.Color = Color;
        }

        public string ToString()
        {
            if (this.on == true)
            {
                return $"speed = {this.getSpeed()}, color = {this.Color},radius = {this.Radius}, fan is on";
            }
            else if (this.on == false)
            {
                return $"color = {this.Color},radius = {this.Radius}, fan is off";
            }
            else return "";
        }
    }
}
