using System.Collections;
using System.Collections.Generic;
using Models;

namespace Family_Management.Data.AdultsData
{
    public interface IAdults
    {
        
            void AddAdult(Adult adult);

            IList<Adult> GetAdults();

            Adult getAdult(int Id);

            void Update(Adult adult);

    }
}