using System;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляров книг
            LibraryBook book1 = new LibraryBook("Война и мир", "Лев Толстой");
            LibraryBook book2 = new LibraryBook("Преступление и наказание", "Фёдор Достоевский");

            // Проверка работы методов
            book1.PrintStatus();
            book1.CheckOutBook();
            book1.PrintStatus();
            book1.CheckOutBook(); // Попытка взять уже взятую книгу

            Console.WriteLine();

            book2.PrintStatus();
            book2.ReturnBook(); // Попытка вернуть книгу, которая не взята
            book2.CheckOutBook();
            book2.PrintStatus();
            book2.ReturnBook();
            book2.PrintStatus();
        }
    }
}
