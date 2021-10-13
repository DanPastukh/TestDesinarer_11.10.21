
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TestSystem
{
    public class User
    {
        public User()
        {
            Groups = new List<Group>();
            UserAnswers = new List<UserAnswers>();
            Results = new List<Results>();
        }
        public int Id { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string Login{ get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<UserAnswers> UserAnswers { get; set; }
        public virtual ICollection<Results> Results { get; set; }


    }
}
