using System;

namespace DatabaseRepl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Database Connection REPL");
            Console.WriteLine("========================\n");

            while (true)
            {
                Console.WriteLine("\nSelect a database:");
                Console.WriteLine("1. MongoDB");
                Console.WriteLine("2. PostgreSQL");
                Console.WriteLine("3. Exit");
                Console.Write("\nEnter choice: ");
                
                string? choice = Console.ReadLine();

                if (choice == "3")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                Console.Write("Enter connection string: ");
                string? connectionString = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(connectionString))
                {
                    Console.WriteLine("Connection string cannot be empty.");
                    continue;
                }

                if (choice == "1")
                {
                    PingMongoDB(connectionString);
                }
                else if (choice == "2")
                {
                    PingPostgreSQL(connectionString);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }

        static void PingMongoDB(string connectionString)
        {
            try
            {
                // TODO: Use your interface from previous assignment
                // Example: var db = new MongoDBConnection(connectionString);
                // bool success = db.Ping();
                
                Console.WriteLine("Attempting to connect to MongoDB...");
                // Placeholder - replace with actual implementation
                Console.WriteLine("✓ Successfully connected to MongoDB!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Failed to connect to MongoDB: {ex.Message}");
            }
        }

        static void PingPostgreSQL(string connectionString)
        {
            try
            {
                // TODO: Use your interface from previous assignment
                // Example: var db = new PostgreSQLConnection(connectionString);
                // bool success = db.Ping();
                
                Console.WriteLine("Attempting to connect to PostgreSQL...");
                // Placeholder - replace with actual implementation
                Console.WriteLine("✓ Successfully connected to PostgreSQL!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Failed to connect to PostgreSQL: {ex.Message}");
            }
        }
    }
}