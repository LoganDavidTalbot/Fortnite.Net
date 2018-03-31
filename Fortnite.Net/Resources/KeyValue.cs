using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Fortnite.Net.Resources
{
    [DataContract(Name = "profile")]
    public class KeyValue
    {
        [DataMember(Name = "key")]
        public string Key { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }
    }
}
