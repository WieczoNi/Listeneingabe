

using System;
bool b = false;
bool c = false;
void SchreibeListe(List<string> I)
{
    I.Sort();
    foreach(string s in I)
    {
        Console.WriteLine(s);
    }
}

bool HatLeerzeichen(string s)
{
    if (s.Any(Char.IsWhiteSpace) == true)
    {
        return (b = true);
    }
    else
    {
        return (b = false);
    }
}

bool SchonVorhanden(List<string> I, string s)
{
    foreach (string item in I)
    {
        if(item == s)
        {
            c = true;
        }
        
     
    }
    if (c == false)
    {
        return (b = false);
    }
    else { c = false;  return (b = true);}
}

List<string> test = new List<string>();
while (true)
{
    Console.Clear();
    Console.WriteLine("Bitte geben sie ein Wort ein");
    string wort = Console.ReadLine();
    if(HatLeerzeichen(wort) == true)
    {
        Console.WriteLine("Das wort darf kein Leerzeiche enthalten");
    }
    else if(SchonVorhanden(test, wort) == true) {
        Console.WriteLine("Das angegebene Wort ist bereits in der Liste vorhanden");
    }
    else
    {
        test.Add(wort);
        Console.WriteLine("Wort erfolgreich hinzugefügt");
    }
    foreach(string item in test) { Console.WriteLine(item); }
    Console.WriteLine("Wenn sie noch ein wort hinzufügen wollen, drücken sie eine Taste");
    Console.ReadKey();

}