using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        // public static void Main(string[] args)
        // {
          
        //     ListPart();
        //     DictionaryPart();
        //     QueuePart();

        //     StackPart();

        //     LibraryPart();
        // }

        static void ListPart()
        {
            Console.WriteLine("Parte 1: Listas");
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }

            Console.WriteLine("Lista original:");
            PrintList(numbers);

            numbers.RemoveAt(0); // Eliminar el primer elemento
            numbers.RemoveAt(numbers.Count - 1); // Eliminar el último elemento

            Console.WriteLine("Lista actualizada:");
            PrintList(numbers);
        }

        static void PrintList(List<int> list)
        {
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static void DictionaryPart()
        {
            Console.WriteLine("\nParte 2: Diccionarios");
            Dictionary<string, int> students = new Dictionary<string, int>
            {
                { "Alice", 85 },
                { "Bob", 90 },
                { "Charlie", 78 },
                { "David", 92 },
                { "Eve", 88 }
            };

            Console.WriteLine("Diccionario original:");
            PrintDictionary(students);

            students["Alice"] = 95; 
            students.Remove("Charlie"); 

            Console.WriteLine("Diccionario actualizado:");
            PrintDictionary(students);
        }

        static void PrintDictionary(Dictionary<string, int> dictionary)
        {
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        static void QueuePart()
        {
            Console.WriteLine("\nParte 3: Colas");
            Queue<string> customers = new Queue<string>();
            customers.Enqueue("Customer 1");
            customers.Enqueue("Customer 2");
            customers.Enqueue("Customer 3");
            customers.Enqueue("Customer 4");
            customers.Enqueue("Customer 5");

            Console.WriteLine("Cola original:");
            PrintQueue(customers);

            customers.Dequeue(); 
            customers.Dequeue(); 

            Console.WriteLine("Cola actualizada:");
            PrintQueue(customers);
        }

        static void PrintQueue(Queue<string> queue)
        {
            foreach (var customer in queue)
            {
                Console.WriteLine(customer);
            }
        }

        static void StackPart()
        {
            Console.WriteLine("\nParte 4: Pilas");
            Stack<string> books = new Stack<string>();
            books.Push("Book 1");
            books.Push("Book 2");
            books.Push("Book 3");
            books.Push("Book 4");
            books.Push("Book 5");

            Console.WriteLine("Pila original:");
            PrintStack(books);

            books.Pop(); 
            books.Pop(); 

            Console.WriteLine("Pila actualizada:");
            PrintStack(books);
        }

        static void PrintStack(Stack<string> stack)
        {
            foreach (var book in stack)
            {
                Console.WriteLine(book);
            }
        }

        static void LibraryPart()
        {
            Console.WriteLine("\nParte 5: Combinación de colecciones y genéricos");
            var library = new Dictionary<string, List<Book>>();

            AddBook(library, "Science Fiction", new Book { Title = "Dune", Author = "Frank Herbert" });
            AddBook(library, "Fantasy", new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien" });
            AddBook(library, "Science Fiction", new Book { Title = "Neuromancer", Author = "William Gibson" });
            AddBook(library, "Fantasy", new Book { Title = "Harry Potter", Author = "J.K. Rowling" });
            AddBook(library, "Science Fiction", new Book { Title = "Foundation", Author = "Isaac Asimov" });

            Console.WriteLine("Libros en la biblioteca:");
            ListAllBooks(library);

            Console.WriteLine("\nLibros en la categoría 'Science Fiction':");
            ListBooksInGenre(library, "Science Fiction");

            RemoveBook(library, "Science Fiction", "Neuromancer");

            Console.WriteLine("\nLibros en la categoría 'Science Fiction' después de eliminar uno:");
            ListBooksInGenre(library, "Science Fiction");
        }

        static void AddBook(Dictionary<string, List<Book>> library, string genre, Book book)
        {
            if (!library.ContainsKey(genre))
            {
                library[genre] = new List<Book>();
            }
            library[genre].Add(book);
        }

        static void RemoveBook(Dictionary<string, List<Book>> library, string genre, string title)
        {
            if (library.ContainsKey(genre))
            {
                library[genre].RemoveAll(b => b.Title == title);
            }
        }

        static void ListBooksInGenre(Dictionary<string, List<Book>> library, string genre)
        {
            if (library.ContainsKey(genre))
            {
                foreach (var book in library[genre])
                {
                    Console.WriteLine($"{book.Title} by {book.Author}");
                }
            }
            else
            {
                Console.WriteLine($"No books found in genre: {genre}");
            }
        }

        static void ListAllBooks(Dictionary<string, List<Book>> library)
        {
            foreach (var kvp in library)
            {
                Console.WriteLine($"\nGenre: {kvp.Key}");
                foreach (var book in kvp.Value)
                {
                    Console.WriteLine($"  {book.Title} by {book.Author}");
                }
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}