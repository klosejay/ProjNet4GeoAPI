using System;
using System.Collections.Generic;
using System.Text;

namespace ProjNet.CoordinateSystems.Projections
{
    internal class GaussKruger:TransverseMercator
    {
        public GaussKruger(IEnumerable<ProjectionParameter> parameters) : base(parameters)
        {
            Name = "Gauss_Kruger";
        }
    }
}
