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
        


        PhoneBook phoneBook = new PhoneBook();

        phoneBook.add("omran", "99334243");
        phoneBook.add("ali", "92334662");

        phoneBook.search("omran");
        phoneBook.search("ali");
        phoneBook.search("salim");

        phoneBook.remove("omran");

        phoneBook.search("omran");
        */


        int[] array = { 1, 2, 3, 4, 5, 5, 4, 3, 2, 1 };
        HashSet<int> uniqueSet1 = HashSet.GetUniqueElements(array);
        Console.WriteLine("Unique elements in array:");
        foreach (int element in uniqueSet1)
        {
            Console.Write(element+" ");
        }


    }
}