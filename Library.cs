public class Library {
    private string _name = "Библиотека";

    public string Name {
        get {
            return _name;
        }

        private set {
            if (string.IsNullOrWhiteSpace(value)) {
                _name = "Библиотека";
                return;
            }

            _name = value.Trim();
        }
    }

    public List<Book> Books { get; private set; }

    public Library(string name) {
        Name = name;
        Books = new List<Book>();
    }

    public void AddBook(Book book) {
        if (book == null) {
            return;
        }

        Books.Add(book);
    }

    public void PrintAll() {
        Console.WriteLine($">>> {Name} <<<");
        Console.WriteLine($"Книг в фонде: {Books.Count}");
        Console.WriteLine();

        foreach (Book book in Books) {
            Console.WriteLine(book.GetInfo());
            Console.WriteLine();
        }
    }

    public int CountAvailable() {
        int count = 0;

        foreach (Book book in Books) {
            if (book.IsAvailable) {
                count++;
            }
        }

        return count;
    }
}