using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.RecapDemo2.Entities.Abstract;

namespace YoutubeProject.RecapDemo2.Business.Abstract
{
    public interface IPlatformService
    {
        void BuyGameFromPlayer(IEntity player, IEntity game);
        void RefundGameFromPlayer(IEntity player, IEntity game);
    }
}
