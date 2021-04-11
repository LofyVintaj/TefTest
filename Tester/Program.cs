using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Serializers;
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

        //[BsonId] // id
        public ObjectId Id { get; set; }
        public string name { get; set; }
        public int count_question { get; set; }
        //[BsonSerializer(typeof(TestingObjectTypeSerializer))]

        //public List<object> questions = new List<object>();
        public object[] questions { get; set; }
        //public var questions = new List<object>();
    }

    // Объекты вопросов
    public class QuestionChoiseAnser
    {
        public string question_name = "QuestionChoiseAnser";
        public ObjectId Id { get; set; }
        public string text { get; set; }
        public List<RadioDataQuestion> object_questions { get; set; }
    }
    public class QuestionTermin
    {
        public string question_name = "QuestionTermin";
        public ObjectId Id { get; set; }
        public string termin_text { get; set; }
        public string termin_value { get; set; }
        public int appraisal { get; set; }
    }
    public class QuestionInsertWordQuestion
    {
        public string question_name = "QuestionInsertWordQuestion";
        public ObjectId Id { get; set; }
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

  //      public object SearchRecord<T>(string table, string name)
  //      {
  //          var collection = db.GetCollection<Test>(table);

  //          var filter = Builders<BsonDocument>.Filter.Eq("name", name);

  //          var doc = collection.Find(filter).FirstOrDefault();
		//	Console.WriteLine(doc.ToString());
		//	return doc;
		//}

        // Обонвление тестов ( Добавление обеьктов вопроса в них) 
        async public void UpdateQuestionsRecord<T>(string table, string name, object question, int page)
		{
            var collection = db.GetCollection<Test>(table);
            var filter = Builders<Test>.Filter.Eq("name", name);
            var doc = collection.Find(filter).FirstOrDefault();
            doc.questions[page] = question;
            var update = Builders<Test>.Update.Set(s => s.questions, doc.questions);
            var result = await collection.UpdateOneAsync(filter, update);
		}
	}
}
