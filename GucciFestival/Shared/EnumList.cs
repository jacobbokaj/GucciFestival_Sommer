﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GucciFestival.Shared
{

    namespace NavigateMenus
    {
        public enum NavigateMenus
        {
            MainSide,
            Coordinator,
            Volenteer
        }

    }
    namespace VolenteerPages
    {
        public enum VolenteerPages
        {
            ShiftsAvailable,
            ShiftsOwn,
            ShiftRead
        }
    }
    namespace CoordinatorPages
    {
        public enum CoordinatorOwnPages
        {
            ShiftsAvailable,
            ShiftsTaken,
            ShiftCreate,
            Volenteers,
            VolenteersRead,
            ShiftRead,
        }
    }
}