using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_TestSystem
{
    [Serializable]
    public class Answers
    {
        public Answers()
        {
            UserAnswers = new List<UserAnswers>();
        }
        public int Id { get; set; }

        
        public string Discription { get; set; }
      
        public bool IsRight { get; set; }

        public int? QuestionsId { get; set; }
        public Questions Questions { get; set; }
        public virtual ICollection<UserAnswers> UserAnswers { get; set; }
    }
}
