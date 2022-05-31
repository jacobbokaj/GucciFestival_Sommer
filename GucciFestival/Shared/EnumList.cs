using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GucciFestival.Shared
{

    namespace Competences
    {
        public enum Competences
        {
            Førstehjælpskursus,
            Elektriker,
            Tømrer,
            Kørekort,
            Rengøring,
            KøkkenErfaring,
            ServiceErfaring
        }
    }


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
            ShiftAvailableRead,
            ShiftsOwn,
            ShiftOwnRead,
        }
    }
    namespace CoordinatorPages
    {
        public enum CoordinatorPages
        {
            ShiftsAvailable,
            ShiftsTaken,
            ShiftCreate,
            Volenteers,
            VolenteersRead,
            ShiftRead,
        }
    }
    namespace TaskStatus
    {
        public enum TaskStatus
        {
            Planning,
            Execution,
            Perform
        }
    }
    namespace StartPage
    {
        public enum StartPage
        {
            MainPage,
            Login,
            CreateUser,
        }
    }
}
