using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Model;

namespace Cars.Service
{
    interface IStaffDummyDataGenerator
    {
        void fakeEmployeeGenerator(ref List<Employee> staff ,int numberOfObjectsTocreate);
    }
}
