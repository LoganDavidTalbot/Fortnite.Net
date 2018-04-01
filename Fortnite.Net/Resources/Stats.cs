using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Fortnite.Net.Resources
{
    [DataContract(Name = "profile")]
    public class Stats
    {
        [DataMember(Name = "p2")]
        public Platform P2 { get; set; }
        [DataMember(Name = "p10")]
        public Platform P10 { get; set; }
        [DataMember(Name = "p9")]
        public Platform P9 { get; set; }
        [DataMember(Name = "curr_p2")]
        public Platform CurrentP2 { get; set; }
        [DataMember(Name = "curr_p10")]
        public Platform CurrentP10 { get; set; }
        [DataMember(Name = "curr_p9")]
        public Platform CurrentP9 { get; set; }
    }
}
