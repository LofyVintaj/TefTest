using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tester
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

	}
	// ChoiseRadio

	public class RadioDataQuestion
	{
		// Объект теста
		public string name { get; set; }
		public bool or_right { get; set; }
	}

	public class Student
	{
		// Объект теста
		public ObjectId Id { get; set; }
		public string FIO { get; set; }
		public string Group { get; set; }
	}

	//[BsonIgnoreExtraElements]
	public class Test
	{
		// Объект теста

		//[BsonId] // id
		[BsonId]
		public ObjectId Id { get; set; }
		public string name { get; set; }
		public int count_question { get; set; }
		//public int figure_to_count {
		//	get; 
		//	set => figure_to_count = count_question / 10; 
		//}
		public float figure_to_count
		{
			get;
			set;
		}
		public void calculate_figure()
		{
			figure_to_count = 10F / count_question;
			Console.WriteLine("figure_to_count");
			Console.WriteLine(figure_to_count);
		}
		//[BsonSerializer(typeof(TestingObjectTypeSerializer))]

		//public List<object> questions = new List<object>();

		//public object[] questions { get; set; }

		public List<QuestionChoiseAnser> questions_choise_answer = new List<QuestionChoiseAnser>();
		public List<QuestionTermin> questions_termin = new List<QuestionTermin>();
		public List<QuestionInsertWordQuestion> questions_insert_word = new List<QuestionInsertWordQuestion>();

		//public var questions = new List<object>();
		
	}

	public class PassedTest
	{
		public Test test { get; set; }
		public Student student { get; set; }
		public float assessment { get; set; }
	}

	public class QuestionChoiseAnser
	{
		public string question_name = "QuestionChoiseAnser";
		public string text { get; set; }

		public List<RadioDataQuestion> object_buttons { get; set; }
	}
	public class QuestionTermin
	{
		public string question_name = "QuestionTermin";
		public string termin_text { get; set; }
		public string termin_value { get; set; }
		public int appraisal { get; set; }

	}
	public class QuestionInsertWordQuestion
	{
		public string question_name = "QuestionInsertWordQuestion";
		public string text { get; set; }
		public List<int> list_index { get; set; }
	}


	public class MongoCRUD
	{
		private IMongoDatabase db;

		public MongoCRUD(string database)
		{
			var client = new MongoClient();
			db = client.GetDatabase(database);
		}

		public void InsertRecord<T>(string table, T record)
		{
			var collection = db.GetCollection<T>(table);
			collection.InsertOne(record);
		}



		public List<Test> ListTests<T>(string collectionName)
		{
			//var collection = db.GetCollection<Test>(table)
			//var documents = await collection.Find( new Test() ).ToListAsync();
			var collection = db.GetCollection<Test>(collectionName);
			var filter = new List<Test>();
			//var filter = Builders<Test>.Filter.();
			var documents = collection.Find(Builders<Test>.Filter.Empty).ToList();
			Console.WriteLine("----------------");
			foreach (Test doc in documents)
			{
				Console.WriteLine(doc.name);
			}
			return documents;
		}


		// 
		public Test SearchTest<T>(string collectionName, string test_name)
		{
			var collection = db.GetCollection<Test>(collectionName);
			var filter = Builders<Test>.Filter.Eq("name", test_name);
			var document = collection.Find(filter).FirstOrDefault();
			return document;
		}

		// Обонвление тестов ( Добавление обеьктов вопроса в них) 
		async public void UpdateQuestionsTerminRecord(string table, string name, QuestionTermin question, int page)
		{
			QuestionTermin new_question = new QuestionTermin();
			Console.WriteLine("----sssssssss----");
			Console.WriteLine(question.ToJson());
			Console.WriteLine(new_question.ToJson());

			var collection = db.GetCollection<Test>(table);
			var filter = Builders<Test>.Filter.Eq("name", name);
			var doc = collection.Find(filter).FirstOrDefault();
			doc.questions_termin.Add(question);
			var update_insert_word = Builders<Test>.Update.Set(s => s.questions_termin, doc.questions_termin);
			var result = await collection.UpdateOneAsync(filter, update_insert_word);
		}

		async public void UpdateQuestionsChoiseAnswerRecord(string table, string name, QuestionChoiseAnser question, int page)
		{

			Console.WriteLine("--------");
			Console.WriteLine(question.ToJson());

			var collection = db.GetCollection<Test>(table);
			var filter = Builders<Test>.Filter.Eq("name", name);
			var doc = collection.Find(filter).FirstOrDefault();

			doc.questions_choise_answer.Add(question);
			var update_insert_word = Builders<Test>.Update.Set(s => s.questions_choise_answer, doc.questions_choise_answer);
			var result_second = await collection.UpdateOneAsync(filter, update_insert_word);
		}
		async public void UpdateQuestionsInstertWordQuestionRecord(string table, string name, QuestionInsertWordQuestion question, int page)
		{

			Console.WriteLine("--------");
			Console.WriteLine(question.ToJson());
			var collection = db.GetCollection<Test>(table);
			var filter = Builders<Test>.Filter.Eq("name", name);
			var doc = collection.Find(filter).FirstOrDefault();
			doc.questions_insert_word.Add(question);
			var update_insert_word = Builders<Test>.Update.Set(s => s.questions_insert_word, doc.questions_insert_word);
			var result_second = await collection.UpdateOneAsync(filter, update_insert_word);
		}

	}
}
