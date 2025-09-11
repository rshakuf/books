using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_project.classes
{
    public class Book
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public string ImagePath { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; } 

        public bool IsBorrowed => !ReturnDate.HasValue;

        public int DaysSinceBorrowed()
        {
            if (BorrowDate == default) return 0;
            return (DateTime.Now - BorrowDate).Days;
        }
    }
}
