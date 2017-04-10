using GigHub.Models;
using System.Collections.Generic;

namespace GigHub.ViewModels
{
    public class GigFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Genre { get; set; }

        //added for a drop list used IEnumable because we are not changing thes list 
        public IEnumerable<Genre> Genres { get; set; } 
    }
}