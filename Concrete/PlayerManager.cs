using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.RecapDemo2.Business.Abstract;
using YoutubeProject.RecapDemo2.Business.ValidationRules.Abstract;
using YoutubeProject.RecapDemo2.DataAccess.Abstract;
using YoutubeProject.RecapDemo2.Entities.Abstract;
using YoutubeProject.RecapDemo2.Entities.Concrete;

namespace YoutubeProject.RecapDemo2.Business.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private IPersonCheckService _personCheckService;
        private List<ILoggerService> _loggerServices;

        public PlayerManager(IPersonCheckService personCheckService, List<ILoggerService> loggerServices)
        {
            _personCheckService = personCheckService;
            _loggerServices = loggerServices;
        }

        public void Add(IEntity player)
        {
            if (_personCheckService.CheckIfRealPerson((Person)player))
            {
                foreach (var logger in _loggerServices)
                {
                    logger.Add(player);
                }
            }
            else
            {
                throw new Exception($"{player.Name} doğrulamadan geçemedi.");
            }
        }

        public void Delete(IEntity player)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(player);
            }
        }

        public void Update(IEntity player)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Update(player);
            }
        }


    }
}
