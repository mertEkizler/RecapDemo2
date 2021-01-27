using System;
using System.Collections.Generic;
using System.Text;
using YoutubeProject.RecapDemo2.Entities.Abstract;

namespace YoutubeProject.RecapDemo2.Entities.Concrete
{
    public class Game : IEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
