using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Fortnite.Net.Resources
{
    public class Stat
    {
        [DataMember(Name = "Label")]
        public string Label { get; set; }
        [DataMember(Name = "Field")]
        public string Field { get; set; }
        [DataMember(Name = "Category")]
        public string Category { get; set; }
        [DataMember(Name = "ValueInt")]
        public int ValueInt { get; set; }
        [DataMember(Name = "Value")]
        public string Value { get; set; }
        [DataMember(Name = "Rank")]
        public int Rank { get; set; }
        [DataMember(Name = "Percentile")]
        public string Percentile { get; set; }
        [DataMember(Name = "DisplayValue")]
        public string DisplayValue { get; set; }
    }
}
