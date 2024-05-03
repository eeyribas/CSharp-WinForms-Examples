using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_ItemSorter
{
    public class SortAlphabetically : IComparer
    {
        public SortAlphabetically()
        {

        }

        public int Compare(object x, object y)
        {
            string element1 = ((ListViewItem)x).Text.ToUpper();
            string element2 = ((ListViewItem)y).Text.ToUpper();

            return element1.CompareTo(element2);
        }
    }

    class SortByTitle : IComparer
    {
        public SortByTitle()
        {

        }

        public int Compare(object x, object y)
        {
            string element1 = ((ListViewItem)x).SubItems[1].Text;
            string element2 = ((ListViewItem)y).SubItems[1].Text;
            string[] sort = { "Specialist", "Lecturer", "Ass. Professor", "Dr.", "Prof Dr."};

            if (Array.IndexOf(sort, element1) > Array.IndexOf(sort, element2))
                return 1;
            else if (Array.IndexOf(sort, element1) < Array.IndexOf(sort, element2))
                return -1;
            else
                return 0;
        }
    }

    class SortNumbers : IComparer
    {
        public SortNumbers()
        {

        }

        public int Compare(object x, object y)
        {
            int element1 = int.Parse(((ListViewItem)x).SubItems[2].Text);
            int element2 = int.Parse(((ListViewItem)y).SubItems[2].Text);

            return Math.Sign(element1 - element2);
        }
    }

    class SortDate : IComparer
    {
        public SortDate()
        {

        }

        public int Compare(object x, object y)
        {
            DateTime element1 = DateTime.Parse(((ListViewItem)x).SubItems[3].Text);
            DateTime element2 = DateTime.Parse(((ListViewItem)y).SubItems[3].Text);

            return element1.CompareTo(element2);
        }
    }
}
