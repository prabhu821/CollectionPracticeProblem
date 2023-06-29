namespace CollectionPracriceProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection Practice Problem!");
            int n = 4;
            int k = 7;

            Dictionary<int, int> chapters = new Dictionary<int, int>();

            chapters.Add(1, 4);
            chapters.Add(5, 7);
            chapters.Add(9, 16);
            chapters.Add(17, 26);

            int chaptersToRead = CountChapters.ChaptersToRead(n, chapters, k);
            Console.WriteLine("The Number of Chapters to Read: " + chaptersToRead);
        }
    }
}