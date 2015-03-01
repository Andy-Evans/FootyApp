using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootApi.Models
{
    public class Team
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Position { get; private set; }

        public Team(int id, string name, int position)
        {
            Id = id;
            Name = name;
            Position = position;
        }
    }
}