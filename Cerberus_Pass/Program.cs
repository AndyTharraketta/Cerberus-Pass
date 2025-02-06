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

            var manager = new PasswordManager();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(value: "\t\tWillkommen im Cerberus-Pass!");
            Console.ResetColor();

            do
            {

                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine(value: "\nWähle was Du tun willst: ");

                Console.WriteLine(value: """
                    1. Passwort-Liste ausgeben
                    2. Passwort mit ID ausgeben
                    3. Neues Passwort erstellen
                    4. Vorhandenes Passwort bearbeiten
                    5. Passwort löschen
                    """);
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        // Liste ausgeben
                        var vault = manager.GetAll();
                        Console.WriteLine(value: vault);
                        break;
                    case "2":
                        // Passwort anhand ID ausgeben
                        break;
                    case "3":
                        // Erstellen
                        Console.WriteLine("Gebe einen Titel für den Eintrag an: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Gebe einen Login für den Eintrag an: ");
                        string login = Console.ReadLine();
                        Console.WriteLine("Gebe einen Passwort für den Eintrag an: ");
                        string password = Console.ReadLine();
                        var newEntry = manager.CreateEntry(title, login, password);
                        Console.WriteLine(value: "Neuer Eintrag erfolgreich erstellt");
                        Console.WriteLine(value: newEntry);     // Gibt Type aus;
                        break;
                    case "4":
                        // Update
                        break;
                    case "5":
                        // Delete
                        break;
                    default:
                        // Fehler anzeigen -> Eingabe-Hint (1-5)
                        // Eingabe wiederholen
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();

            } while (true);






        }
    }
}
