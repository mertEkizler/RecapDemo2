using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.RecapDemo2.Entities.Abstract;
using YoutubeProject.RecapDemo2.Entities.Concrete;

namespace YoutubeProject.RecapDemo2.Business.ValidationRules.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Person person);
    }
}
