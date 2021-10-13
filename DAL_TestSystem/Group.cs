using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_TestSystem
{
    public class Group
    {
        public Group()
        {
            Users = new List<User>();
            TestGroups = new List<TestGroup>();
        }
      
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<TestGroup> TestGroups { get; set; }
    }
}