using System;
using System.Collections.Generic;
using System.Text;

namespace School.Common.Models
{
    using Newtonsoft.Json;
    class Player
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Full Name")]
        public string FullName { get; set; }

        [JsonProperty("Birthdate")]
        public DateTime Birthdate { get; set; }

        [JsonProperty("Age")]
        public float Age { get; set; }

        [JsonProperty("Home Country")]
        public string HomeCountry { get; set; }

        [JsonProperty("Health")]
        public string Health { get; set; }

        [JsonProperty("Position")]
        public string Position { get; set; }

        public override string ToString()
        {
            return $"{this.FullName}  {this.Birthdate}  {this.Age}  {this.Position}";
        }
    }
}
