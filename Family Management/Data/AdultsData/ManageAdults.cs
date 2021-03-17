using System.Collections.Generic;
using System.Linq;
using FileData;
using Models;

namespace Family_Management.Data.AdultsData
{
    public class ManageAdults: IAdults
    {
        private FileContext fileContext;

        public ManageAdults(FileContext file)
        {
            fileContext = file;
        }
        public void AddAdult(Adult adult)
        {
            int max;
            if (fileContext.Adults.Count==0)
            {
                max = 1;
                adult.Id = max;
            }
            else
            {
                max = fileContext.Adults.Max(a => a.Id);
                adult.Id = (++max);
            }
             
            fileContext.Adults.Add(adult);
            fileContext.SaveChanges();
        }

        public IList<Adult> GetAdults()
        {
            return fileContext.Adults;
        }
    }
    }
