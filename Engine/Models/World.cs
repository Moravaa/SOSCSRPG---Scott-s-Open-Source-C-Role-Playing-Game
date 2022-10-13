﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, string imageName)
        {
            Location loc = new Location();
            loc.XCordinate = xCoordinate;
            loc.YCordinate = yCoordinate;
            loc.Name = name;
            loc.Description = description;
            loc.ImageName = imageName;

            _locations.Add(loc);
        }

        public Location LocationAt(int xCoordinte, int yCoordinate)
        {
            foreach(Location loc in _locations)
            {
                if (loc.XCordinate == xCoordinte && loc.YCordinate == yCoordinate)
                {
                    return loc;
                }
            }

            return null;
        }
    }
}