using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL_TestSystem
{
    public class Tests
    {
        public Tests()
        {
            Questions = new List<Questions>();
            TestGroup = new List<TestGroup>();
            Results = new List<Results>();
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public ICollection<Questions> Questions { get; set; }
        public ICollection<TestGroup> TestGroup { get; set; }
        public ICollection<Results> Results { get; set; }

    }
}