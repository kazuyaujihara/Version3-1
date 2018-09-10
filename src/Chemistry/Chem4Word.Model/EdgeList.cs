﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chem4Word.Model
{
    public class EdgeList :HashSet<Bond>
    {
        public static EdgeList operator ^(EdgeList a, EdgeList b)
        {
            var copy = new EdgeList();
            copy.UnionWith(a);
            copy.SymmetricExceptWith(b);
            return copy;
        }


        public static EdgeList operator + (EdgeList a, EdgeList b)
        {
            var copy = new EdgeList();
            copy.UnionWith(a);
            copy.UnionWith(b);
            return copy;
        }

        public override string ToString()
        {
            var ids = this.Select(b=>b.Id).ToArray();
            Array.Sort(ids);

            return "[" + string.Join(",", ids) + "]";
        }
    }

    public class EdgeListComparer : IEqualityComparer<EdgeList>
    {
        public bool Equals(EdgeList x, EdgeList y)
        {
            return x.ToString() == y.ToString();
        }

        public int GetHashCode(EdgeList obj)
        {
            return (obj?.ToString().GetHashCode())??0;
        }
    }
}
