using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    interface ICheckInOutManager
    {
        void CheckOut(int UserID, int BookID);
        void CheckIn(int UserID, int BookID);
    }
}
