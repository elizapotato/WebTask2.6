using System;
using Microsoft.AspNetCore.Http;

namespace Web._931803.Chegodaeva.Lab6.Models
{
    public class FileViewModel
    {
        public string Name { get; set; }
        public IFormFile FilePath { get; set; }
    }
}
