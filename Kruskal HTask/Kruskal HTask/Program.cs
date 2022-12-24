using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruskal_HTask
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Vertices number: ");
			int Vnum = int.Parse(Console.ReadLine());

			Console.WriteLine("Edges number: ");
			int Enum = int.Parse(Console.ReadLine());

			Graph graph = NewGraph(Vnum, Enum);


			for(int i = 0; i < Enum; i++)
            {
				Console.WriteLine("edge source: ");
				graph.edge[i].Source = int.Parse(Console.ReadLine());

				Console.WriteLine("edge destination: ");
				graph.edge[i].Destination = int.Parse(Console.ReadLine());

				Console.WriteLine("edge weight: ");
				graph.edge[i].Weight = int.Parse(Console.ReadLine());
			}

			Kruskal(graph);

			void Kruskal(Graph G)
			{
			    Vnum = graph.VerticesNum;
				Edge[] result = new Edge[Vnum];
				int i = 0;
				int e = 0;

				Array.Sort(graph.edge, delegate (Edge a, Edge b)
				{
					return a.Weight.CompareTo(b.Weight);
				});

				Subset[] subsets = new Subset[Vnum];

				for (int v = 0; v < Vnum; ++v)
				{
					subsets[v].Parent = v;
					subsets[v].Rank = 0;
				}

				while (e < Vnum - 1)
				{
					Edge nextEdge = graph.edge[i++];
					int x = Find(subsets, nextEdge.Source);
					int y = Find(subsets, nextEdge.Destination);

					if (x != y)
					{
						result[e++] = nextEdge;
						Union(subsets, x, y);
					}
				}

				Print(result, e);
			}


			Console.ReadLine();
		}
		
		static Graph NewGraph(int Vnum, int Enum)
		{
			Graph graph = new Graph();
			graph.VerticesNum = Vnum;
			graph.EdgesNum = Enum;
			graph.edge = new Edge[graph.EdgesNum];

			return graph;
		}

		static int Find(Subset[] subsets, int i)
		{
			if (subsets[i].Parent != i)
				subsets[i].Parent = Find(subsets, subsets[i].Parent);

			return subsets[i].Parent;
		}

		static void Union(Subset[] subsets, int u, int v)
		{
			int uroot = Find(subsets, u);
			int vroot = Find(subsets, v);

			if (subsets[uroot].Rank < subsets[vroot].Rank)
				subsets[uroot].Parent = vroot;
			else if (subsets[uroot].Rank > subsets[vroot].Rank)
				subsets[vroot].Parent = uroot;
			else
			{
				subsets[vroot].Parent = uroot;
				++subsets[uroot].Rank;
			}
		}

		static void Print(Edge[] result, int e)
		{
			for (int i = 0; i < e; ++i)
				Console.WriteLine("{0} --> {1} == {2}", result[i].Source, result[i].Destination, result[i].Weight);
		}

		
	}
}
