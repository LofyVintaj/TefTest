using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

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
            //string connectionString = "TestBook";
            //MongoClient client = new MongoClient(connectionString);
            //IMongoDatabase database = client.GetDatabase("tester");
            //MongoCRUD db = new MongoCRUD(connectionString);
            //db.InsertRecord("User", < Object >);
            //db.InsertRecord("Test", new Test { name = "IT", count_question = 4 

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

        [BsonId] // id
        public Guid Id { get; set; }
        public string FIO { get; set; }
        public string Group { get; set; }
        public int Assessment { get; set; }
    }


    public class Test
    {
        // Объект теста

        [BsonId] // id
        public Guid Id { get; set; }
        public string name { get; set; }
        public int count_question
        {
            get; set;
        }
		public List<object> questions = new List<object>();
		//public var questions = new List<object>();
	}

    // Объекты вопросов
    public class QuestionChoiseAnser
    {
        public List<RadioDataQuestion> object_questions = new List<RadioDataQuestion>();
    }
    public class QuestionTermin
    {
        public string termin_text { get; set; }
        public string termin_value { get; set; }
        public int appraisal { get; set; }
    }
    public class QuestionInsertWordQuestion
    {
        public string text { get; set; }
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

        public object SearchRecord<T>(string table, string name)
        {
            var dbClient = new MongoClient("mongodb://localhost:27017");

            IMongoDatabase db = dbClient.GetDatabase("TestBook");
            var cars = db.GetCollection<BsonDocument>("Test");

            var filter = Builders<BsonDocument>.Filter.Eq("name", "leha");

            var doc = cars.Find(filter).FirstOrDefault();
			Console.WriteLine(doc.ToString());
			return doc;
		}

        async public void UpdateQuestionsRecord<T>(string table, string name, object question)
		{
            var dbClient = new MongoClient("mongodb://localhost:27017");

            IMongoDatabase db = dbClient.GetDatabase("TestBook");
            var test = db.GetCollection<Test>("Test");

            // Взял тот документ который мне нужен
            var filter = Builders<Test>.Filter.Eq("name", name);

            var doc = test.Find(filter).FirstOrDefault();
            Console.WriteLine("ОООПА");
            Console.WriteLine(doc);
            Console.WriteLine(doc.questions);
            doc.questions.Add(question);
            Console.WriteLine(doc.questions);
            var update = Builders<Test>.Update.Set(s => s.questions, question);
            var result = await test.UpdateOneAsync(filter, update);

            foreach (object p in doc.questions)
			{
				Console.WriteLine("l l l");
				//Console.WriteLine(p.GetType().GetProperties());

    //            foreach (var s in p.GetType().GetProperties())
				//{
    //                Console.WriteLine(s.GetValue(s));
    //            }
                var isAllPropertiesNull = p.GetType()
                                            .GetProperties()
                                            .Select(pi => pi.GetValue(p));
                Console.WriteLine(isAllPropertiesNull);

                foreach (var s in isAllPropertiesNull)
				{
					Console.WriteLine(s.GetType());
				}
			}
        }
	}
}
