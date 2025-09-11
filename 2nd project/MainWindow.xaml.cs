using System.Windows;
using _2nd_project.classes;
using System.Collections.Generic;

namespace _2nd_project
{
    public partial class MainWindow : Window
    {   
        public MainWindow()
        {
            InitializeComponent();

            List<Book> books = new List<Book>
            {
                new Book { Name="little woman", Language="English", Pages=260, ImagePath="C:\\Users\\User\\source\\repos\\2nd project\\2nd project\\images\\rooooooooooooo.jpg", BorrowDate=System.DateTime.Now.AddDays(-3) },
                new Book { Name="beni goren", Language="Hebrew", Pages=380, ImagePath="C:\\Users\\User\\source\\repos\\2nd project\\2nd project\\images\\boooooooooooooooooooooooo.png" },
                new Book { Name="english for begginers", Language="English", Pages=600, ImagePath="C:\\Users\\User\\Desktop\\rotem\\2nd project\\2nd project\\hbg-title-beginners-english-learn-british-english-as-a-foreign-language-17.webp", BorrowDate=System.DateTime.Now.AddDays(-4) },
                new Book { Name="the sleeping beauty", Language="English", Pages=280, ImagePath="C:\\Users\\User\\source\\repos\\2nd project\\2nd project\\images\\bo.jpg" },
                new Book { Name="the scream", Language="English", Pages=160, ImagePath="C:\\Users\\User\\source\\repos\\2nd project\\2nd project\\images\\screammmmmmmmmmmmmmmmmmm.jpg", BorrowDate=System.DateTime.Now.AddDays(-6) }
            };

            foreach (var book in books)
            {
                BookControl bc = new BookControl(book);
                BookStackPanel.Children.Add(bc);
            }
        }
    }
}
