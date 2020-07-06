using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace MemoryCards
{
    public class DBAccess
    {

        public static List<CardModel> LoadCards()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<CardModel> cards = cnn.Query<CardModel>("select * from Cards").ToList();
                return cards;
            }
        }

        public static CardModel LoadACard(CardModel card)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<CardModel>("select * from Tasks WHERE ID = @ID", card).First();
            }
        }

        public static void SaveCard(CardModel card)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Cards (ID, FirstPage, SecondPage, Due, Group) values (@ID, @FirstPage, @SecondPage, @Due, @Group);", card);
            }
        }

        public static void DeleteCard(CardModel card)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Delete From Cards WHERE ID = @ID", card);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

