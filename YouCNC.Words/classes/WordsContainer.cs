using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouCNC.Words
{
    public static class WordsContainer
    {
        public const string GetPositions = "?";
        public const string ReceivedPositions = "Positions";
        public const string IsIdle = "Idle";
        public const string Run = "Run";
        public const string PauseStop = "!";
        public const string StartContinue = "~";
        public const string KillAlarmLock = "$X";
        public const string SetXToZero = "G92x0";
        public const string SetYToZero = "G92y0";
        public const string SetZToZero = "G92z0";
        public const string XGoToZero = "G90x0";
        public const string YGoToZero = "G90y0";
        public const string ZGoToZero = "G90z0";
        public const string Error = "err";
        public const string AbsoluteCoordinates = "G90";
        public const string RelativeCoordinates = "G91";
        public const string MoveXValue = "G0x";
        public const string MoveYValue = "G0y";
        public const string MoveZValue = "G0z";
        public const string Unlock = "$X";
        public const string StepEnableInvert = "$4=";
    }
}
