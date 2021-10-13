
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
	[XmlRoot(ElementName = "Answer")]
	public class Answer
	{
		[XmlElement(ElementName = "Description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "IsRight")]
		public string IsRight { get; set; }
	}

	[XmlRoot(ElementName = "Question")]
	public class Question
	{
		[XmlElement(ElementName = "Description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "Difficulty")]
		public string Difficulty { get; set; }
		[XmlElement(ElementName = "Answer")]
		public List<Answer> Answer { get; set; }
	}

	[XmlRoot(ElementName = "Test")]
	public class Test
	{
		[XmlElement(ElementName = "Author")]
		public string Author { get; set; }
		[XmlElement(ElementName = "TestName")]
		public string TestName { get; set; }
		//[XmlElement(ElementName = "QuestionCount")]
		//public string QuestionCount { get; set; }
		[XmlElement(ElementName = "Question")]
		public List<Question> Question { get; set; }
	}

}
