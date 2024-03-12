// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Markus!");
//Rakendus küsib kasutjalt valida tema sugu (m/f)
//Rakendus küsib kasutjalt sisestada tema perekonnanime
//lähtudes kasutja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr.[kasutaja perekonnanimi]" / "Welcome, Ms.[kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid maha string (sõne) formaadis 

Console.WriteLine("Please enter your last name:");
string userLastName = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName} !");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName} !");
}
else
{
    Console.WriteLine($"Welcome, {userLastName} !");
}
