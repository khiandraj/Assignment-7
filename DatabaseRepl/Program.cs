using System;
using MongoDB.Driver;
using Npgsql;

namespace DatabaseReplApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Database Connection REPL");
            Console.WriteLine("=================================\n");

            bool running = true;

            while (running)
            {
                Console.WriteLine("\nSelect database type:");
                Console.WriteLine("1. MongoDB");
                Console.WriteLine("2. PostgreSQL");
                Console.WriteLine("3. Exit");
                Console.Write("\nEnter choice (1-3): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        HandleMongoDb();
                        break;
                    case "2":
                        HandlePostgreSql();
                        break;
                    case "3":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void HandleMongoDb()
        {
            Console.WriteLine("\n--- MongoDB Connection ---");
            Console.Write("Enter MongoDB connection string: ");
            string connectionString = Console.ReadLine();

            try
            {
                var mongoConnector = new MongoConnector(connectionString);
                bool pingResult = mongoConnector.Ping();


                Console.WriteLine("✓ SUCCESS: Connected to MongoDB!");
                Console.WriteLine($"Response: {pingResult}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ ERROR: Failed to connect to MongoDB");
                Console.WriteLine($"Details: {ex.Message}");
            }
        }

        static void HandlePostgreSql()
        {
            try
            {
                var PostgresConnector = new PostgresConnector(connectionString);
                bool pingResult= PostgresConnector.Ping()
            }
            
            
    
            catch (Exception ex)
            {
                Console.WriteLine($"✗ ERROR: Failed to connect to PostgreSQL");
                Console.WriteLine($"Details: {ex.Message}");
            }
        }
    }
}