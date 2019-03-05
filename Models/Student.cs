using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSQlite.Models
{
    public class Student
    {
       public int StudentId { get; set; }
       public string FirstName{ get; set; }
       public string LastName { get; set; }
       public string School { get; set; }
       public DateTime StartDate { get; set; }
    }
}
