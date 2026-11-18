internal class Program
{
    static void Main(string[] args)
    {
        string title = "Clean Code";
        int pages = 464;

        string sentence = string.Format(
            "Book: {0}, Pages: {1}", title, pages);

        Console.WriteLine(sentence);
    }
}



