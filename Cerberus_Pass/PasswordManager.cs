using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerberus_Pass
{
    internal class PasswordManager
    {
        private List<PasswordEntry> vault;

        public PasswordManager()
        {
            // vault = new List<PasswordEntry>();
            // vault = new();
            // vault = [];
            vault = [];
        }
        //public List<PasswordEntry> GetAll()
        //{
        //    return vault;
        //}
        public List<PasswordEntry> GetAll() => vault;
       
        public PasswordEntry CreateEntry(
            string title,
            string login,
            string password,
            string website = "",
            string note = "")
        {
            PasswordEntry newEntry = new PasswordEntry(
                title,
                login,
                password,
                website,
                note);
            vault.Add(newEntry);
            return newEntry;
        }
       
    }
}
