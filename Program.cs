using System;

var zufall = new Random();
int geheimzahl = zufall.Next(0, 101); // Zahlen von 0 bis 100

int gesamtPunkte = 0;
bool spielLeauft = true;
while (spielLeauft)
{

    int versuche = 0;
    int maximaleVersuche = 7;
    // bool erraten = false;       // Muss nicht mehr unbedingt aufgeführt werden, weil wegen dem break
    // das bool übersehen und nicht mehr beachtet wird


    Console.WriteLine("--- Zahlenraten von 0 bis 100 ---");
   
    Console.WriteLine($"Du hast {maximaleVersuche} Versuche, um meine Geheimzahl zu erraten. \nÜberlege weise!");
 

    // Schleife läuft, solange Zahl nicht erraten wurde und noch Versuche übrig sind

    while (versuche < maximaleVersuche)
    {

        Console.Write($"\nVersuch {versuche + 1}: Gib deinen Tip ein: ");


        // Eingabe lesen und direkt umwandeln
        string eingabe = Console.ReadLine();

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
            gesamtPunkte += (maximaleVersuche - versuche + 1) * 10;
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
    Console.Write("\nMöchtest du noch einmal spielen? (j/n)");
    string antwort = Console.ReadLine().ToLower(); // Macht aus JA oder J automatisch ja oder j
    if (antwort != "ja" && antwort != "j")
    {
        spielLeauft = false;
        Console.WriteLine($"\nDanke fürs Spielen! Dein Endstand: {gesamtPunkte} Punkte. \nBis zum nächsten mal :-)");
    }
}
