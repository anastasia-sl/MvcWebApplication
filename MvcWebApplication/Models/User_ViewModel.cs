using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace MvcWebApplication.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Users(int id, string name, string lastName)
        {
            Id = id;
            FirstName = name;
            LastName = lastName;
        }
        public string PrintInfo() => $"{Id}. {FirstName} ({LastName})";
    }
}
