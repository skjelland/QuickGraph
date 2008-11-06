using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Factories;
using System;
using QuickGraph;

namespace QuickGraph
{
    [PexFactoryClass]
    public partial class EdgeFactory
    {
        [PexFactoryMethod(typeof(Edge<int>))]
        public static Edge<int> Create(int source, int target)
        {
            Edge<int> edge = new Edge<int>(source, target);
            return edge;
        }

    }
}
