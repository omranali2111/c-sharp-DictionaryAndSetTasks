using c_sharp_DictionaryAndSetTasks;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        string sentence = "hi i am omran i am from oman";
        Dictionary analyzer = new Dictionary();
        Dictionary<string, int> result = analyzer.Frequency(sentence.ToLower());

        foreach (var kvp in result)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        */

        PhoneBook phoneBook = new PhoneBook();

        phoneBook.add("omran", "99334243");
        phoneBook.add("ali", "92334662");

        phoneBook.search("omran");
        phoneBook.search("ali");
        phoneBook.search("salim");

        phoneBook.remove("omran");

        phoneBook.search("omran");


    }
}