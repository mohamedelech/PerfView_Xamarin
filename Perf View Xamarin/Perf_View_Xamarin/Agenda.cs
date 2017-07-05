using SQLite;
using System;

namespace Perf_View_Xamarin
{
    public class Agenda
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public DateTime Date { get; set; }

        public Agenda()
        {
        }
    }

}