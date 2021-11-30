using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerSideLogAnalyzer.Models
{
    public class LogModel
    {
        public int idLogs { get; set; }
        public DateTime Date { get; set; }
        public string Discription { get; set; }
    }
}
