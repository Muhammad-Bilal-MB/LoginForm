using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Form
{
    class Class1
    {
        static DataClasses1DataContext db = null;

        public static void add_user(info l)
        {
            db = new DataClasses1DataContext();
            db.add_user(l.fname, l.lname, l.email, l.pass);
        }
    }
}
