using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegginerCourse
{
    public class SpeedCamera
    {
        private int  _speedLimit, _carSpeed;
        public SpeedCamera(int carSpeed , int speedLimit)
        {
            _speedLimit = speedLimit;
            _carSpeed = carSpeed;
        }

        public string RunSpeedCamera()
        {
            if (_carSpeed <= _speedLimit)
            {
                return "Ok";
            }
            else
            {

                int demeritPoints = CalculateDemeritPoints(_carSpeed, _speedLimit);
                if (demeritPoints > 12)
                {
                    return "License Suspended";
                }
                else
                {
                    return "Demerit Points: " + demeritPoints;
                }

            }
        }

        public static int CalculateDemeritPoints(int carSpeed, int speedLimit)
        {
            const int kmPerDemeritPoint = 5;

            int demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;

            return demeritPoints;

        }
    }
}
