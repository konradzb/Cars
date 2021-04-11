using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.Model;

namespace Cars.Service
{
    public class StaffDummyDataGenerator : IStaffDummyDataGenerator
    {
        Random random = new Random();
        private List<string> names = new List<string> { "Marian", "Maciej", "Andrzej" };

        private List<string> surnames = new List<string> { "Nowak", "Kowalski", "Lewandowski" };

        private DateTime dateOfBirth = new DateTime(1978,2,10);

        private List<string> positions = new List<string> { "Menedżer", "Pracownik", "Kierowca" };

        public void fakeEmployeeGenerator(ref List<Staff> staff, int numberOfObjectsTocreate)
        {
            for(int i=0;i<numberOfObjectsTocreate;i++)
            {
                staff.Add(new Staff(this.names[randomIntNumber()], this.surnames[randomIntNumber()], dateOfBirth, this.positions[randomIntNumber()]));
            }
        }

        private int randomIntNumber()
        {
            return random.Next(0, 3);
        }
    }
}
