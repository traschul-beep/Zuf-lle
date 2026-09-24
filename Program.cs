/*
var zufall = new Random();
int meineZahl;

Console.WriteLine(zufall.Next()); // 9 ställige Zahl zufällig 
Console.WriteLine(zufall.Next(100));           // (100) eine zufällige Zahl zwischen 1 und 100
Console.WriteLine(zufall.Next(100, 1000));           // (100, 1000) zufällige Zahl zwischen 100 und 1000
meineZahl = zufall.Next(100);

Console.WriteLine(meineZahl);
*/

// Zahlenraten 1 bis 100
// Computer wählt zufällige geheime Zahl, die erraten werden muss
// Programm gibt wieder, ob Zahl korrekt, zu klein, zu groß
// Ist Antwort richtig gibt es eine Ausgabe

// Erweitert: Versuche werden gezhlt und
// Anzahl der Versuche die man hat vorgegen, bevor man verliert

using System.ComponentModel.Design;

var zufall = new Random();
int geheimzahl = zufall.Next(0, 101); // Zahlen von 0 bis 100

int versuche = 0;
int maximaleVersuche = 7;
// bool erraten = false;       // Muss nicht mehr unbedingt aufgeführt werden, weil wegen dem break
                               // das bool übersehen und nicht mehr beachtet wird


Console.WriteLine("--- Zahlenraten von 0 bis 100 ---");
Thread.Sleep(1000);  // Wartet kurz bevor die neue Zeile ausgegeben wird
Console.WriteLine($"Du hast {maximaleVersuche} Versuche, um meine Geheimzahl zu erraten. Überlege weise!");
Thread.Sleep(1000);  // Wartet kurz bevor die neue Zeile ausgegeben wird

// Schleife läuft, solange Zahl nicht erraten wurde und noch Versuche übrig sind

while (versuche < maximaleVersuche)
{
    Thread.Sleep(1000);
    Console.Write($"\nVersuch {versuche + 1}: Gib deinen Tip ein: ");
    
  
// Eingabe lesen und direkt umwandeln
    string eingabe = Console.ReadLine();
    Thread.Sleep(1000);
    //int gerateneZahl = Convert.ToInt32(eingabe);   // Falls die Eingabe mit der Prüfung ob Zahl eingegeben wurde oder nicht, dann
    // reicht das

    int gerateneZahl;                               // Prüft, ob die Eingabe eine Zahl war
    if (!int.TryParse(eingabe, out gerateneZahl))
    {
        Console.WriteLine(("Das ist KEINE gültige Zahl! Bitte gebe NUR Zahlen ein"));
        continue;                                    // springt an den Anfang der Schleife, ohne einen Versuch abzuziehen
    }
    versuche++; // Versuche zählen

    if (gerateneZahl == geheimzahl)
    {
        Console.WriteLine($"Klasse! Du hast meine Geheimzahl nach {versuche} Versuchen erraten :)");
        break; // Zahl erraten
    }
    else if (gerateneZahl < geheimzahl)
    {
        Console.WriteLine("Meine Zahl ist Grösser.");
    }
    else
    {
        Console.WriteLine("Meine Zahl ist Kleiner");
    }
    if (versuche == maximaleVersuche && gerateneZahl != geheimzahl)
    {
        Console.WriteLine($"\nSchade, du hast geloost! Meine Geheimzahl war: {geheimzahl}");
    }
 }
Thread.Sleep(2000);
Console.WriteLine("\nDrücke eine beliebige Taste zum Beenden des Spiels.");


/*
var zufall = new Random();

Console.WriteLine("Ich denke mir eine Geheimzahl aus!");
Thread.Sleep(1000);
int geheimZahl = zufall.Next(100) + 1;
int antwort = -1;

while (true)
{
    Console.WriteLine("Errate meine Geheimzahl: ");
    antwort = Convert.ToInt32(Console.ReadLine());


    if (antwort > geheimZahl)
    {
        Console.WriteLine("Deine Antwort ist zu groß!\n\n");
    }
    if (antwort < geheimZahl)
    {
        Console.WriteLine("Deine Antwort ist zu klein!\n\n");
    }
    if (antwort == geheimZahl)
    {
        Console.WriteLine($"Jaaaa, {antwort} ist genau richtig!");
        break; //Verlässt die derzeitige Schleife
    }

}
*/

