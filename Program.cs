Library library = new Library("   Городская библиотека   ");

library.AddBook(new Book("   Мастер и Маргарита   ", "Булгаков", 1967, 480));
library.AddBook(new Book("Преступление и наказание", "Достоевский", 1866, 672));
library.AddBook(new Book("", "Неизвестный автор", 2020, 300));
library.AddBook(new Book("Маленький принц", "Сент-Экзюпери", 1943, 96));

library.PrintAll();

Console.WriteLine($"Доступно книг: {library.CountAvailable()}");
Console.WriteLine();

Book first = library.Books[0];
first.Borrow();
Console.WriteLine($"{first.Title}: доступна? {first.IsAvailable}");

first.Borrow();
Console.WriteLine($"{first.Title}: доступна? {first.IsAvailable}");

first.Return();
Console.WriteLine($"{first.Title}: доступна? {first.IsAvailable}, прочитана раз: {first.TimesRead}");


Console.WriteLine($"Первый в списке прочитан раз: {library.Books[0].TimesRead}");
Console.WriteLine();

Console.WriteLine($"«{first.Title}» длинная? {first.IsLong()}");
Console.WriteLine($"Доступно книг после действий: {library.CountAvailable()}");
