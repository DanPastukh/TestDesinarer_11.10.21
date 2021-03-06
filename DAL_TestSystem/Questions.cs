using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL_TestSystem
{
    [Serializable]
    public class Questions
    {
        public Questions()
        {
            Answers = new List<Answers>();
        }
        public int Id { get; set; }
     
        public string Discription { get; set; }

        public string Difficulty { get; set; }
        public ICollection<Answers> Answers { get; set; }

        public int? TestsId { get; set; }
       
        public Tests Tests { get; set; }
    }
}