using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDotnet.MergeMeetingTimes
{
    public class Meeting
    {
        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public Meeting(int startTime, int endTime)
        {
            // Number of 30 min blocks past 9:00 am
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"({StartTime}, {EndTime})";
        }

        public override bool Equals(object obj)
        {
            return this.StartTime == (obj as Meeting).StartTime && this.EndTime == (obj as Meeting).EndTime;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StartTime, EndTime);
        }
    }
}
