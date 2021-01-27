using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.RecapDemo2.Entities.Abstract;

namespace YoutubeProject.RecapDemo2.Business.Abstract
{
    public interface IGameService
    {
        void Add(IEntity game);
        void Delete(IEntity game);
        void Update(IEntity game);

    }
}