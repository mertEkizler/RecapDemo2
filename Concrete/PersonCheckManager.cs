using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.RecapDemo2.Business.ValidationRules.Abstract;
using YoutubeProject.RecapDemo2.Entities.Abstract;
using YoutubeProject.RecapDemo2.Entities.Concrete;

namespace YoutubeProject.RecapDemo2.Business.ValidationRules.Concrete
{
    public class PersonCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            if (person.Name.Trim().Length > 0 && person.LastName.Trim().Length > 0 && person.NationalityId.Trim().Length == 11 && person.DateOfBirth.Year > 1900) ;
            {
                return true;
            }
        }
    }
}
