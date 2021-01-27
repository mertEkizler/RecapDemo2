using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.RecapDemo2.Entities.Abstract;

namespace YoutubeProject.RecapDemo2.Business.Abstract
{
    public interface IPlayerService
    {
        void Add(IEntity player);
        void Delete(IEntity player);
        void Update(IEntity player);

    }
}
