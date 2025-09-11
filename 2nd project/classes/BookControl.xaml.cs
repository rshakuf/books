using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace _2nd_project.classes
{
    public partial class BookControl : UserControl
    {
        private Book _book;

       
        private bool _hoverShown = false;     
        private bool _showingDialog = false;  

        public BookControl(Book book)
        {
            InitializeComponent();
            _book = book;
            this.DataContext = book;

            this.MouseEnter += BookControl_MouseEnter;
            this.MouseLeave += BookControl_MouseLeave; 
        }

        private void BookControl_MouseEnter(object sender, MouseEventArgs e)
        {
            if (_hoverShown || _showingDialog)
                return;

            _hoverShown = true;
            _showingDialog = true;
            try
            {
                if (_book.IsBorrowed)
                {
                    MessageBox.Show($"{_book.Name} מושאל כבר {_book.DaysSinceBorrowed()} ימים");
                }
                else
                {
                    MessageBox.Show($"{_book.Name} פנוי");
                }
            }
            finally
            {
                _showingDialog = false;
            }
        }

        private void BookControl_MouseLeave(object sender, MouseEventArgs e)
        {
            _hoverShown = false; 
        }
    }
}
