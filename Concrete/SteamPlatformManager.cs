using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.RecapDemo2.Business.Abstract;
using YoutubeProject.RecapDemo2.Entities.Abstract;
using YoutubeProject.RecapDemo2.Entities.Concrete;

namespace YoutubeProject.RecapDemo2.Business.Concrete
{
    public class SteamPlatformManager : IPlatformService
    {
        private List<ISalesService> _salesServices;

        public SteamPlatformManager(List<ISalesService> salesServices)
        {
            _salesServices = salesServices;
        }

        public void BuyGameFromPlayer(IEntity player, IEntity game)
        {
            foreach (var sale in _salesServices)
            {
                sale.Discount((Game)game);
            }
            Console.WriteLine($"{player.Name}, {game.Name} oyununu Steam'den satın aldı.");
        }

        public void RefundGameFromPlayer(IEntity player, IEntity game)
        {
            Console.WriteLine($"{player.Name}, {game.Name} oyununu Steam'e iade etti.");
        }
    }
}