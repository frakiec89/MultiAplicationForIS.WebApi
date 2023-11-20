using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MultiAplicationForIS.SQLDB.Model
{
    [Index(nameof(Email), IsUnique = true)]
    internal class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// емейл у полбзователя должен быть уникальный 
        /// </summary>
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
