using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestDesignerDLL
{
	[XmlRoot(ElementName = "Test")]
	public class TestDll
	{
		[XmlElement(ElementName = "Author")]
		public string Author { get; set; }
		[XmlElement(ElementName = "TestName")]
		public string TestName { get; set; }
		//[XmlElement(ElementName = "QuestionCount")]
		//public string QuestionCount { get; set; }
		[XmlElement(ElementName = "Questions")]
		public List<QuestionDLL> Questions { get; set; }
        public TestDll()
        {
			Questions = new List<QuestionDLL>();
		}
		
	}
}
