using System.Collections;
internal static class HashProgram
{
    public static void Main(string[] args)
    {



        Hashtable adatok = new Hashtable();
        adatok.Add("22", "Tom");
        adatok.Add("38", "Lisa");
        adatok.Add("17", "Adam");

        Console.WriteLine("Add meg a nevet vagy a kort!");
        var adat = Console.ReadLine();
        foreach (DictionaryEntry elem in adatok)
        {
            if (adatok.ContainsKey(adat) || adatok.ContainsValue(adat))
            {

                if (elem.Key.Equals(adat))
                {
                    Console.WriteLine("A korhoz tartozó név: " + elem.Value);
                }

                if (elem.Value.Equals(adat))
                {
                    Console.WriteLine("A névhez tartozó kor: " + elem.Key);
                }
            }
            else
            {
                Console.WriteLine("Rossz szám vagy név");
                break;

            }
        }
    }
}
