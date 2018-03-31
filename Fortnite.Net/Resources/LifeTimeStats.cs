using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Fortnite.Net.Resources
{
    public class LifeTimeStats
    {
        private KeyValue[] _stats;
        public LifeTimeStats(KeyValue[] stats)
        {
            _stats = stats;
        }

        public KeyValue[] Stats { get { return _stats; }}

        public string GetStat(string key)
        {
            return HasStat(key) ? Stats.Where(s => s.Key == key).FirstOrDefault().Value : null;
        }

        public bool HasStat(string key)
        {
            if (Stats == null)
            {
                return false;
            }

            return Stats.Any(s => s.Key == key);
        }

        public string Top3 { get { return GetStat("Top 3"); } }
        public string Top5s { get { return GetStat("Top 5s"); } }
        public string Top3s { get { return GetStat("Top 3s"); } }
        public string Top6s { get { return GetStat("Top 6s"); } }
        public string Top12s { get { return GetStat("Top 12s"); } }
        public string Top25s { get { return GetStat("Top 25s"); } }
        public string Score { get { return GetStat("Score"); } }
        public string MatchesPlayed { get { return GetStat("Matches Played"); } }
        public string Wins { get { return GetStat("Wins"); } }
        public string WinPercentage { get { return GetStat("Win%"); } }
        public string Kills { get { return GetStat("Kills"); } }
        public string KD { get { return GetStat("K/d"); } }
        public string KillsPerMin { get { return GetStat("Kills Per Min"); } }
        public string TimePlayed { get { return GetStat("Time Played"); } }
        public string AvgSurivalTime { get { return GetStat("Avg Survival Time"); } }
    }
}
