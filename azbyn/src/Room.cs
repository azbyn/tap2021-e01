using System;

namespace src
{
    public class Room
    {
        public readonly int perNightCost;
        public readonly string name;

        public Room(int perNightCost, string name)
        {
            this.perNightCost = perNightCost;
            this.name = name;
        }
        public int CalculateCost(DateTime start, DateTime end) {
            if (start > end) {
                return CalculateCost(end, start);
            }
            var delta = end - start;
            return CalculateCost(delta.Days);
        }
        protected virtual int CalculateCost(int duration) {
            return duration * perNightCost;
        }
    }
}
