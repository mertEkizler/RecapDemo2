using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.RecapDemo2.Entities.Abstract;

namespace YoutubeProject.RecapDemo2.DataAccess.Abstract
{
    public interface ILoggerService
    {
        void Add(IEntity entity);
        void Delete(IEntity entity);
        void Update(IEntity entity);
    }
}
