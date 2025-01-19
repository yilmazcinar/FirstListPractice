List <string> guest = new List<string>();

Console.WriteLine("Galaya hoşgeldiniz. \n");

while (true)
{
    Console.WriteLine("\nZiyaretçi ismi giriniz. Bitirmek için 'bitir' yazın. \n\n");
    string isim = Console.ReadLine();

    
    
    if (isim.ToLower() == "bitir")
    {
        break;

    }

    guest.Add(isim);



}

Console.WriteLine("\nGuest List : \n");

foreach (var item in guest)
{
    Console.WriteLine($"{item}\n");
}