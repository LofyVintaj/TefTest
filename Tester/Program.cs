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

        // ChoiseRadio

        public class RadioDataQuestion
        {
            // Объект теста
            public String name { get; set; }
            public bool or_right { get; set; }
        }


        public class Test
        {
            // Объект теста

            [BsonId] // id
            public Guid Id { get; set; }
            public String name { get; set; }
            public int count_question
            {
                get; set;
            }
        }

        // Объекты вопросов
        public class QuestionChoiseAnser
        {
            public List<RadioDataQuestion> object_questions = new List<RadioDataQuestion>();

        }
        public class QuestionTermin
        {
            public String termin_text { get; set; }
            public String termin_right_value { get; set; }
            public int appraisal { get; set; }
        }
        public class QuestionInsertWordQuestion
        {
            public String text { get; set; }
        }



        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
			string connectionString = "TestBook";
			//MongoClient client = new MongoClient(connectionString);
			//IMongoDatabase database = client.GetDatabase("tester");
			MongoCRUD db = new MongoCRUD(connectionString);
            //db.InsertRecord("User", < Object >);
            db.InsertRecord("Test", new Test { name = "IT", count_question = 4 } );
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
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
		}
    }
}
