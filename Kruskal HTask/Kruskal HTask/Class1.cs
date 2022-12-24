using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruskal_HTask
{
	public struct Edge
	{
		public int Source;
		public int Destination;
		public int Weight;
	}

	public struct Graph
	{
		public int VerticesNum;
		public int EdgesNum;
		public Edge[] edge;
	}

	public struct Subset
	{
		public int Parent;
		public int Rank;
	}

	
}
