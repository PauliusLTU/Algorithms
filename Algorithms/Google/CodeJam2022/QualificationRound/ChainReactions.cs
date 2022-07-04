using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Google.CodeJam2022.QualificationRound.ChainReactions
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int num_test_cases = Convert.ToInt32(Console.ReadLine());
            for (int t = 0; t < num_test_cases; t++)
            {
                SolveProblem(t + 1);
            }
        }

        private static void SolveProblem(int num_test_case)
        {
            Chains chains = ReadChains();
            long maxFunFactor = GetMaxFunFactor(chains);

            Console.WriteLine("Case #{0}: {1}", num_test_case, maxFunFactor);
        }

        private static Chains ReadChains()
        {
            Chains chains = new Chains();

            Console.ReadLine();

            string[] line = Console.ReadLine().Split(' ');
            int[] funFactors = Array.ConvertAll(line, int.Parse);

            line = Console.ReadLine().Split(' ');
            int[] parentIndexes = Array.ConvertAll(line, int.Parse);

            for (int i = 0; i < funFactors.Length; i++)
            {
                int parentIndex = parentIndexes[i];

                Node parentNode = null;
                int depth = 0;

                if (parentIndex > 0)
                {
                    parentNode = chains[parentIndex];
                    depth = parentNode.Depth + 1;
                }
                chains.Add(i + 1, new Node(funFactors[i], parentNode, depth));
            }

            return chains;
        }

        private static long GetMaxFunFactor(Chains chains)
        {
            long maxFunFactor = 0;

            var depthGroups = chains.Values.
                GroupBy(n => n.Depth).
                Select(g => new { Depth = g.Key, Nodes = g }).
                OrderByDescending(ng => ng.Depth);

            foreach (var depthGroup in depthGroups)
            {
                var parentGroups = depthGroup.Nodes.
                    GroupBy(n => n.Parent).
                    Select(g => new { Parent = g.Key, ChildNodes = g.OrderBy(n => n.FunFactor).ToArray() });

                foreach (var parentGroup in parentGroups)
                {
                    Node[] childNodes = parentGroup.ChildNodes;

                    if (childNodes.Length > 1)
                    {
                        maxFunFactor += childNodes.Skip(1).Sum(n => n.FunFactor);
                    }

                    if (parentGroup.Parent != null)
                    {
                        parentGroup.Parent.FunFactor = Math.Max(parentGroup.Parent.FunFactor, childNodes[0].FunFactor);
                    }
                    else
                    {
                        maxFunFactor += childNodes[0].FunFactor;
                    }
                }
            }

            return maxFunFactor;
        }

        private class Chains : Dictionary<int, Node>
        {
        }

        private class Node
        {
            internal Node(long funFactor, Node parent, int depth)
            {
                FunFactor = funFactor;
                Parent = parent;
                Depth = depth;
            }

            internal long FunFactor { get; set; }

            internal Node Parent { get; private set; }

            internal int Depth { get; private set; }
        }
    }
}
