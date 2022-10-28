using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp306_MaziarHassanzadeh_Lab2.Pages
{
    public class IndexModel 
    {
        public string Student { get; set; }
        public DateTime TheTime { get; set; } = DateTime.Now;
    }
}
