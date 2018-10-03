using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLinkedIn.Models
{
    public class Interests
    {
        public InterestType Type { get; set; },
    }
    public enum InterestType
    {
        LongWalksOnTheBeachInMoonlight,
        PaintingTurtleShells,
        HeavyBreathing,
        EatingCheezItsByTheBox,
        TandemBiking,
        SittingInSilence,
        InterpretiveDance
    }
}
