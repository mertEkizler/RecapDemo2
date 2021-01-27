using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.RecapDemo2.Business.Abstract;
using YoutubeProject.RecapDemo2.DataAccess.Abstract;
using YoutubeProject.RecapDemo2.Entities.Abstract;
using YoutubeProject.RecapDemo2.Entities.Concrete;

namespace YoutubeProject.RecapDemo2.Business.Concrete
{
    public class WinterSalesManager : ISalesService
    {
        private List<ILoggerService> _loggerServices;

        public WinterSalesManager(List<ILoggerService> loggerServices)
        {
            _loggerServices = loggerServices;
        }
        public void Discount(Game game)
        {
            game.Price *= (double)0.90;
        }

    }
}
