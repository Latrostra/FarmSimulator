using Types;
using UnityEngine;

namespace ScriptableObjects.Models
{
    public class Month : ScriptableObject
    {
        public int MonthNumber;
        public MonthName Name;
        public Season Season;
        public int NumberOfDays;
    }
}
