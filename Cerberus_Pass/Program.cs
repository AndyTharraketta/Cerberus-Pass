namespace Cerberus_Pass
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Main UI-Flow
            //using Cerberus_Pass;

            PasswordEntry? pass1 = new PasswordEntry(title: "Steam", login: "WaldmeisterSD", password: "P@ssword");
            PasswordEntry? pass2 = new PasswordEntry(title: "Steam", login: "WaldmeisterSD", password: "P@ssword", website: "https://store.steampowered.com", note: "Mein cooler Steam-Acount");

            Console.WriteLine(value: pass1.Website.Length);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(value: "\t\tWillkommen im Cerberus-Pass!");
            Console.ResetColor();

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine(value: "\nWähle was Du tun willst: ");

            Console.WriteLine(value: """
                1. Passwort-Liste ausgeben
                2. Passwort mit ID ausgeben
                3. Neues Passwort erstellen
                4. Vorhandenes Passwort bearbeiten
                5. Passwort löschen
                """);
            Console.ResetColor();

        }
    }
}
