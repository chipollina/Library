public class Book {
    private string _title = "Без названия";

    public string Title {
        get {
            return _title;
        }

        private set {
            if (string.IsNullOrWhiteSpace(value)) {
                _title = "Без названия";
                return;
            }

            _title = value.Trim();
        }
    }

    public string Author { get; private set; }
    public int Year { get; private set; }
    public int Pages { get; private set; }
    public int TimesRead { get; private set; }
    public bool IsAvailable { get; private set; }

    public Book(string title, string author, int year, int pages) {
        Title = title;
        Author = author;

        Year = year;

        if (Year < 1450) {
            Year = 1450;
        }

        if (Year > 2100) {
            Year = 2100;
        }

        Pages = pages;

        if (Pages <= 0) {
            Pages = 1;
        }

        TimesRead = 0;
        IsAvailable = true;
    }

    public void Borrow() {
        if (!IsAvailable) {
            return;
        }

        IsAvailable = false;
    }

    public void Return() {
        if (IsAvailable) {
            return;
        }

        IsAvailable = true;
        TimesRead++;
    }

    public bool IsLong() {
        return Pages > 500;
    }

    public string GetInfo() {
        string status = IsAvailable ? "доступна" : "выдана";

        return $">>> {Title} <<<\n" +
               $"Автор: {Author}\n" +
               $"Год: {Year}\n" +
               $"Страниц: {Pages}\n" +
               $"Статус: {status}\n" +
               $"Прочитана раз: {TimesRead}";
    }
}