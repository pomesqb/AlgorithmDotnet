using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmDotnet.MergeMeetingTimes
{
    public class AlgorithmMergeMeetingTimes
    {
        public List<Meeting> MergeMeetingTimes(List<Meeting> meetings)
        {
            for (int i = 0; i < meetings.Count; i++)
            {
                var meeting = meetings[i];

                for (int innerIndex = 0; innerIndex < meetings.Count; innerIndex++)
                {
                    var comparedMeeting = meetings[innerIndex];

                    if (meeting.StartTime == comparedMeeting.StartTime && meeting.EndTime == comparedMeeting.EndTime)
                        continue;

                    if (meeting.StartTime >= comparedMeeting.StartTime && meeting.StartTime <= comparedMeeting.EndTime)
                    {
                        if (meeting.EndTime < comparedMeeting.EndTime)
                        {
                            meeting.EndTime = comparedMeeting.EndTime;
                        }

                        if (meeting.StartTime > comparedMeeting.StartTime)
                        {
                            meeting.StartTime = comparedMeeting.StartTime;
                        }

                        meetings.Remove(comparedMeeting);
                    }
                    else if (meeting.EndTime >= comparedMeeting.StartTime && meeting.EndTime <= comparedMeeting.EndTime)
                    {
                        if (meeting.EndTime < comparedMeeting.EndTime)
                        {
                            meeting.EndTime = comparedMeeting.EndTime;
                        }

                        if (meeting.StartTime > comparedMeeting.StartTime)
                        {
                            meeting.StartTime = comparedMeeting.StartTime;
                        }

                        meetings.Remove(comparedMeeting);
                    }
                }
            }

            return meetings;
        }

        public List<Meeting> MergeMeetingTimesBest(List<Meeting> meetings)
        {
            var sortedMeetings = meetings.Select(m => new Meeting(m.StartTime, m.EndTime)).OrderBy(m => m.StartTime).ToList();

            var mergedMeetings = new List<Meeting>();

            foreach (var currentMeeting in sortedMeetings)
            {
                if (mergedMeetings.Count == 0)
                {
                    mergedMeetings.Add(currentMeeting);
                    continue;
                }

                var lastMergedMeeting = mergedMeetings.Last();

                if (currentMeeting.StartTime <= lastMergedMeeting.EndTime)
                {
                    lastMergedMeeting.EndTime = Math.Max(currentMeeting.EndTime, lastMergedMeeting.EndTime);
                }
                else
                {
                    mergedMeetings.Add(currentMeeting);
                }
            }

            return mergedMeetings;
        }
    }
}
