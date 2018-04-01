using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Fortnite.Net.Resources
{
    public class Platform
    {
        [DataMember(Name = "trnRating")]
        public Stat TrnRating { get; set; }
        [DataMember(Name = "score")]
        public Stat Score { get; set; }
        [DataMember(Name = "top1")]
        public Stat Top1 { get; set; }
        [DataMember(Name = "top3")]
        public Stat Top3 { get; set; }
        [DataMember(Name = "top5")]
        public Stat Top5 { get; set; }
        [DataMember(Name = "top10")]
        public Stat Top10 { get; set; }
        [DataMember(Name = "top12")]
        public Stat Top12 { get; set; }
        [DataMember(Name = "top25")]
        public Stat Top25 { get; set; }
        [DataMember(Name = "kd")]
        public Stat KD { get; set; }
        [DataMember(Name = "winRatio")]
        public Stat WinRatio { get; set; }
        [DataMember(Name = "matches")]
        public Stat Matches { get; set; }
        [DataMember(Name = "kills")]
        public Stat Kills { get; set; }
        [DataMember(Name = "kpg")]
        public Stat KPG { get; set; }
        [DataMember(Name = "avgTimePlayed")]
        public Stat AvgTimePlayed { get; set; }
        [DataMember(Name = "scorePerMatch")]
        public Stat ScorePerMatch { get; set; }
    }
}