using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerberus_Pass
{   
    // PascalCase => BegriffstrennungImmerErsterBuchstabeGroß
    // => Properies, Funkionen / Methods, Classes, Namespaces, Enums
    internal class PasswordEntry
    {
        public string Title { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Website { get; set; }
        public string Note { get; set; }

        public PasswordEntry(string title, string login, string password, string website = "", string note = "")
        {
            Title = title;
            Login = login;
            Password = password;
            Website = website;
            Note = note;
        }
    }
}
