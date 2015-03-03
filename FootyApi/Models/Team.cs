using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace FootApi.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PostCode { get; set; }
        public string PitchType { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public List<Player> Players { get; set; }
    }
}