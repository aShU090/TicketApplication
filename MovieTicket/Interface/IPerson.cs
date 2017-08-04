using System;
using Apttus.Assignment.MovieTicket.Enum;

namespace Apttus.Assignment.MovieTicket
{
    interface IPerson
    {
        String Name { get; set; }
        int Age { get; set; }
        Gender gender { get; set; }
    }
}
