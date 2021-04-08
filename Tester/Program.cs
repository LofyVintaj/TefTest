﻿using System;
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

        public void SearchRecord<T>(string table, string name)
		{
            var dbClient = new MongoClient("mongodb://localhost:27017");

            IMongoDatabase db = dbClient.GetDatabase("TestBook");
            var cars = db.GetCollection<BsonDocument>("Test");

            var filter = Builders<BsonDocument>.Filter.Eq("name", "leha");

            var doc = cars.Find(filter).FirstOrDefault();
            Console.WriteLine(doc.ToString());

            //var collection = db.GetCollection<T>(table);
            //var result = collection.Find(Builders<T>.Filter.Eq("name", name));

            //Console.WriteLine(result.ToString());
            //         Console.WriteLine(result);
            //         return result;


            //var filter = Builders<Test>.Filter.Eq("name", "leha4");

            //var filter = new BsonDocument("name", "leha4");
            //var results = collection.Find(filter).ToList();

            //foreach (var p in results)
            //{
            //    Console.WriteLine(p);
            //    Console.WriteLine("KOPEC");
            //}



            //var firstDocument = collection.Find(new BsonDocument()).FirstOrDefault();
            //Console.WriteLine(firstDocument.ToBson().ToString
            //var results = collection.Find(filter).ToList();


        }
	}
}
