using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuHR
{
    public class Workers
    {
        public string ФИО { get; set; }
        public string Тип { get; set; }
        public DateTime ВступилВДолжность { get; set; }
        public string Начальник { get; set; }
        public string Подчиненные { get; set; }
        public float Зарплата { get; set; }
        public double  РасчетнаяЗарплата { get; set; }
    }
}
