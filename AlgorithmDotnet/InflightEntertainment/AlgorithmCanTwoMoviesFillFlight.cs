using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmDotnet.InflightEntertainment
{
    public class AlgorithmCanTwoMoviesFillFlight
    {
        public bool CanTwoMoviesFillFlight(int[] movieLengths, int flightLength)
        {
            var moviesSet = new HashSet<int>();

            foreach (var item in movieLengths)
            {
                var targetLength = flightLength - item;

                if (moviesSet.Contains(targetLength))
                {
                    return true;
                }

                moviesSet.Add(item);
            }

            return false;
        }
    }
}
