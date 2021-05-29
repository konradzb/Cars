using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Model;

namespace Cars.Service
{
    interface IEmployeeDummyDataGenerator
    {
        void fakeEmployeeGenerator(ref List<Model.User> staff ,int numberOfObjectsTocreate);
    }
}
