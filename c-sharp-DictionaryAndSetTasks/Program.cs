using c_sharp_DictionaryAndSetTasks;

internal class Program
{
    private static void Main(string[] args)
    {
        string sentence = "hi i am omran i am from oman";
        Dictionary analyzer = new Dictionary();
        Dictionary<string, int> result = analyzer.Frequency(sentence.ToLower());

        foreach (var kvp in result)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }



    }
}