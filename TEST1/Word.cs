using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1
{
    class Word
    {
        public String palabra
        {
            get;
            set;
        }

        public String traduccion
        {
            get;
            set;
        }        

        // Overload for the [] operator.
        // This allows for you to access a data member of the Movie class as if the Movie was an array.
        //
        // Example:
        //              Movie m = new Movie();
        //              String title = m[0];
        //
        //              The String title now holds m.Title's value.
        //
        // This is going to be used for your sorting algorithms. If you look at the already implemented 
        // quickSort function, it takes in the columnIndex of which column was clicked by the user to 
        // trigger the sort. Having this overload lets us do something like movies[i][columnIndex] to
        // easily get access to the Year for example if the columnIndex is 3.
        public String this[int _column]
        {
            get
            {
                switch (_column)
                {
                    case 0:
                        return palabra;
                        break;
                    case 1:
                        return traduccion;
                        break;                    
                    default:
                        return palabra;
                        break;
                }
            }
        }

        // This function does the same thing as the overloaded [] operator above but
        // in function form.
        //
        // Example:
        //              Movie m = new Movie();
        //              String title = m.GetDataMemberByColumn(0);
        //
        //              The String title now holds m.Title's value.
        public String GetDataMemberByColumn(int _column)
        {
            switch (_column)
            {
                case 0:
                    return palabra;
                    break;
                case 1:
                    return traduccion;
                    break;
                default:
                    return palabra;
                    break;
            }
        }
    }   
}
