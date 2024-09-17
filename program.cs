int points = 0;

Console.WriteLine("vad är väldens bästa fotbolls lag");
Console.WriteLine("A:real madrid");
Console.WriteLine("B:manchester city");
Console.WriteLine("C:manchester united");
string lag = Console.ReadLine();
if(lag=="B")
{
    Console.WriteLine("rätt");
    points = points + 1;
}
else
{
    Console.WriteLine("fel");
    points =points - 1;
}


Console.WriteLine($"du fick {points} poäng");

Console.ReadLine();
 
 Console.WriteLine("vilket land har de finaste områden");
 Console.WriteLine("A:libanon");
 Console.WriteLine("B grekland:");
 Console.WriteLine("C:marroco");
 Console.WriteLine("D:brasilien");
 string land=Console.ReadLine();
 if(land=="A")
 {
    Console.WriteLine("rätt");
    points = points +2;
 }
 else
 {
    Console.WriteLine("fel");
    points = points - 1;
 }


 Console.WriteLine($"du fick {points} poäng");



Console.WriteLine("vilket land kommer dansen dabke ifrån");
Console.WriteLine("A:libanon");
Console.WriteLine("B:sverige");
Console.WriteLine("C:palestina");
string dabke=Console.ReadLine();
if(dabke=="C")
{
    Console.WriteLine("rätt");
    points = points +3;
 }
 else
 {
    Console.WriteLine("fel");
    points = points - 2;
 }


 Console.WriteLine($"du fick {points} poäng");
 Console.WriteLine("tryck på valfri knapp för att gå vidare");
 Console.WriteLine("");

Console.ReadLine();