int ProductIndex = 0;

string[] Products = new string[100]; //Detta indikerar så många rader som användaren kan skriva in.


Console.WriteLine("Skriv in produkter. Avsluta med att skriva 'exit'.");
Console.WriteLine();//Använder för att snygga till resultatet

string Exit = "exit"; //skapar en string för att användaren ska kunna skriva exit och det skall avbrytas.
string ExitUpper = Exit.ToUpper(); //skapar en sträng i en sträng och lägger till ToUpper för att kunna skriva med STORA bokstäver.


for (; ; ) //Här gör jag en loop för att användaren ska kunna mata in fler rader.
{
    Console.Write("Ange produkt: ");
    string Product1 = Console.ReadLine();
    Products[ProductIndex] = Product1; // Här lägger jag in befintliga strings och arrrays i en string för att allting ska samlas i 
    //en och samma.
    ProductIndex++;//detta används för att få hela listan att matas ut och inte endast ett värde.

    if (Product1.Contains(Exit)) //Trim används för att användaren ska kunna skriva mellanslag utan att påverka resultatet.

        //Här bryter jag inmatningen genom att användaren får skriva "exit"
        break;

    if (Product1.Contains(ExitUpper)) //I denna if-sats blir inmatningen avbruten om användaren skriver "EXIT".
    {
        break;
        
    }
    }
    Console.WriteLine();//Använder för att snygga till resultatet

    Console.WriteLine("Du angav följande produkter(sorterade): ");

    Console.WriteLine();//Använder för att snygga till resultatet

    Array.Sort(Products); //Använder Array.sort för att sortera produkterna i utmatningen.

    foreach (string Product2 in Products)//Här skapar jag en ny sträng i en sträng för att kunna mata ut listan.
    {
        if (Product2 != null) //Här använder if-sats för att ta bort tomma rader i utmatningen.
        {

       
        if (Product2 != Exit) //Här ser jag till att exit inte skrivs ut i utmatningen.
            if (Product2 !=  ExitUpper ) // Här ser jag till att EXIT inte skrivs ut i utmatningen

              
                Console.WriteLine("* " + Product2.Trim()); //Här skrivs produkterna ut och .Trim() används för att ta bort eventuella mellanslag
                                                           //ifall sådana skulle förekomma. Man kan alltså använda sig av mellanslag men i utskriften kommer dessa att försvinna.
        }//Försökte få in trim på exit, men lyckades inte och tiden rann ut. Du kanske kan ge mig förslag på var det skulle kunna implementeras.
    }
    Console.WriteLine(); //Använder för att snygga till resultatet

    Console.WriteLine("Press any key to continue . . .");

