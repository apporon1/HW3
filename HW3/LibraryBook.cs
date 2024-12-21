using System;

namespace HW3
{
    public class LibraryBook
    {
        // Закрытые поля
        private string title;
        private string author;
        private bool isCheckedOut;

        // Конструктор
        public LibraryBook(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.isCheckedOut = false;
        }

        // Публичные свойства только для чтения
        public string Title
        {
            get { return title; }
        }

        public string Author
        {
            get { return author; }
        }

        // Метод для взятия книги
        public void CheckOutBook()
        {
            if (isCheckedOut)
            {
                Console.WriteLine($"Книга \"{title}\" уже взята.");
            }
            else
            {
                isCheckedOut = true;
                Console.WriteLine($"Книга \"{title}\" успешно взята.");
            }
        }

        // Метод для возврата книги
        public void ReturnBook()
        {
            if (!isCheckedOut)
            {
                Console.WriteLine($"Книга \"{title}\" уже доступна.");
            }
            else
            {
                isCheckedOut = false;
                Console.WriteLine($"Книга \"{title}\" успешно возвращена.");
            }
        }

        // Метод для получения статуса книги
        public void PrintStatus()
        {
            string status = isCheckedOut ? "взята" : "доступна";
            Console.WriteLine($"Книга: \"{title}\" Автор: {author} Статус: {status}");
        }
    }
}
