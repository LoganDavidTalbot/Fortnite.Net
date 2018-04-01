using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Fortnite.Net.Resources
{
    [DataContract(Name = "Match")]
    public class Match
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "accountId")]
        public string AccountId { get; set; }
        [DataMember(Name = "playlist")]
        public string Playlist { get; set; }
        [DataMember(Name = "kills")]
        public int Kills { get; set; }
        [DataMember(Name = "minutesPlayed")]
        public int MinutesPlayed { get; set; }
        [DataMember(Name = "top1")]
        public int Top1 { get; set; }
        [DataMember(Name = "top3")]
        public int Top3 { get; set; }
        [DataMember(Name = "top5")]
        public int Top5 { get; set; }
        [DataMember(Name = "top6")]
        public int Top6 { get; set; }
        [DataMember(Name = "top10")]
        public int Top10 { get; set; }
        [DataMember(Name = "top12")]
        public int Top12 { get; set; }
        [DataMember(Name = "top25")]
        public int Top25 { get; set; }
        [DataMember(Name = "matches")]
        public int Matches { get; set; }
        [DataMember(Name = "dateCollected")]
        public DateTime DateCollected { get; set; }
        [DataMember(Name = "score")]
        public int Score { get; set; }
        [DataMember(Name = "platform")]
        public int Platform { get; set; }
        [DataMember(Name = "trnRating")]
        public double TrnRating { get; set; }
        [DataMember(Name = "trnRatingChange")]
        public double TrnRatingChange { get; set; }
    }
}