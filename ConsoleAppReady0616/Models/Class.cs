using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReady0616.Models
{
    public class Class
    {
        public int Id { get; set; }

        public int RoomNo { get; set; } = 0;
        public string Name { get; set; }


        public List<Student> Students { get; set; } = new();
    }
}
