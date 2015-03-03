using System;

namespace FootApi.Models
{
    public class Player
    {
        public int PlayerId { get;  set; }
        public string Firstname { get;  set; }
        public string Surname { get;  set; }
        public DateTime Dob { get; set; }
    }
}