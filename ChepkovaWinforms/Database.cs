using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using Npgsql;

namespace ChepkovaWinforms
{
    internal class Database
    {

        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=11111; DataBase=Chepkova1");

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed) 
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return connection;
        }

        public List<ProductCard> GetProduct()
        {

            List<ProductCard> proCards = new List<ProductCard>();

            openConnection();

            NpgsqlCommand getProducts = new NpgsqlCommand($"SELECT * FROM products", connection);

            NpgsqlDataReader reader = getProducts.ExecuteReader();

            while (reader.Read())
            {
                ProductCard productCard = new ProductCard(reader.GetInt32(0), reader.GetString(1), reader.GetString(2).ToString(), reader.GetInt32(3), null);

                proCards.Add(productCard);
            
            }

            closeConnection();

            return proCards;

        }

        public List<ProductCard> GetProdQuery(string query)
        {

            List<ProductCard> proCards = new List<ProductCard>();

            openConnection();

            NpgsqlCommand getProducts = new NpgsqlCommand($"SELECT * FROM products WHERE prod_name LIKE '{query}%'", connection);

            NpgsqlDataReader reader = getProducts.ExecuteReader();

            while (reader.Read())
            {
                ProductCard productCard = new ProductCard(reader.GetInt32(0), reader.GetString(1), reader.GetString(2).ToString(), reader.GetInt32(3), null);
                proCards.Add(productCard);
            }

            closeConnection();

            return proCards;

        }

        public List<ProductCard> GetProdFilter(string filter)
        {

            List<ProductCard> proCards = new List<ProductCard>();

            openConnection();

            if (filter == "мин")
            {
                NpgsqlCommand getProducts = new NpgsqlCommand($"SELECT * FROM products ORDER BY price ASC", connection);
                NpgsqlDataReader reader = getProducts.ExecuteReader();

                while (reader.Read())
                {
                    ProductCard productCard = new ProductCard(reader.GetInt32(0), reader.GetString(1), reader.GetString(2).ToString(), reader.GetInt32(3), null);
                    proCards.Add(productCard);
                }
            }            
            if (filter == "макс")
            {
                NpgsqlCommand getProducts = new NpgsqlCommand($"SELECT * FROM products ORDER BY price DESC", connection);
                NpgsqlDataReader reader = getProducts.ExecuteReader();

                while (reader.Read())
                {
                    ProductCard productCard = new ProductCard(reader.GetInt32(0), reader.GetString(1), reader.GetString(2).ToString(), reader.GetInt32(3), null);
                    proCards.Add(productCard);
                }
            }    

            closeConnection();

            return proCards;
        }

        public List<ProductCard> GetProdSort(string sort)
        {

            List<ProductCard> proCards = new List<ProductCard>();

            openConnection();

            if (sort == "ABC")
            {
                NpgsqlCommand getProducts = new NpgsqlCommand($"SELECT * FROM products ORDER BY prod_name ASC", connection);
                NpgsqlDataReader reader = getProducts.ExecuteReader();

                while (reader.Read())
                {
                    ProductCard productCard = new ProductCard(reader.GetInt32(0), reader.GetString(1), reader.GetString(2).ToString(), reader.GetInt32(3), null);
                    proCards.Add(productCard);
                }
            }
            if (sort == "ZYX")
            {
                NpgsqlCommand getProducts = new NpgsqlCommand($"SELECT * FROM products ORDER BY prod_name DESC", connection);
                NpgsqlDataReader reader = getProducts.ExecuteReader();

                while (reader.Read())
                {
                    ProductCard productCard = new ProductCard(reader.GetInt32(0), reader.GetString(1), reader.GetString(2).ToString(), reader.GetInt32(3), null);
                    proCards.Add(productCard);
                }
            }

            closeConnection();

            return proCards;
        }
    }
}
