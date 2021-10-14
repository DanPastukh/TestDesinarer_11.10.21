using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestDesignerDLL
{
	[XmlRoot(ElementName = "Question")]
	public class QuestionDLL
	{
		[XmlElement(ElementName = "Description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "Difficulty")]
		public string Difficulty { get; set; }
		[XmlElement(ElementName = "Answers")]
		public List<AnswerDLL> Answers { get; set; }
        public QuestionDLL()
        {
			Answers= new List<AnswerDLL>();
		}
	}
}
