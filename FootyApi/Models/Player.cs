using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootApi.Models
{
    public class Player
    {
        public int PlayerId { get; private set; }
        public string Firstname { get; private set; }
        public string Surname { get; private set; }
        public DateTime Dob { get; private set; }

        public Player( int playerId, string firstname, string surname, DateTime dob)
        {
            PlayerId = playerId;
            Firstname = firstname;
            Surname = surname;
            Dob = dob;
        }
    }
}