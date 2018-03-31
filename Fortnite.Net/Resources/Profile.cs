using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Fortnite.Net.Resources
{
    [DataContract(Name = "profile")]
    public class Profile
    {
        [DataMember(Name = "accountId")]
        public string AccountId { get; set; }

        [DataMember(Name = "platformId")]
        public int PlatformId { get; set; }

        [DataMember(Name = "platformName")]
        public string PlatformName { get; set; }

        [DataMember(Name = "platformNameLong")]
        public string PlatformNameLong { get; set; }

        [DataMember(Name = "epicUserHandle")]
        public string EpicUserHandle { get; set; }

        [DataMember(Name = "lifeTimeStats")]
        internal KeyValue[] LifeTimeStatsValues { get; set; }

        public LifeTimeStats LifeTimeStats { get; set; }

        public Profile()
        {
            init();
        }

        internal void init()
        {
            LifeTimeStats = new LifeTimeStats(LifeTimeStatsValues);
        }
    }
}
