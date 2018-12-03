using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingProgrammSR
{
    class PowerFrame
    {
        public bool[] WorkStepMotor;
        public bool[] Direction;
        public static uint Speed;
        public static bool EncoderChannel;
        public UInt16[] Angle;
        public UInt16 DryContactSensor;
        public UInt16[] NullAngle;

        public PowerFrame()
        {
            WorkStepMotor = new bool[4] { false, false, false, false };
            Direction = new bool[4] { false, false, false, false };
            Speed = 60;
            EncoderChannel = false;


        }
    }
}
