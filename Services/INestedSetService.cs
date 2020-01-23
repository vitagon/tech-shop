using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Services
{
    public interface INestedSetService
    {
        SortedDictionary<int, T> BuildTreeAsDictionary<T>(ref List<T> entitiesList, int parentId = 0) where T : NestedSet<T>;
        List<T> BuildTreeAsList<T>(ref List<T> entitiesList, int parentId = 0) where T : NestedSet<T>;
        List<T> DictionaryTreeToList<T>(SortedDictionary<int, T> tree) where T : NestedSet<T>;
        List<T> SortListTree<T>(List<T> treeList) where T : NestedSet<T>;
        SortedDictionary<int, T> SortDictionaryTree<T>(SortedDictionary<int, T> tree) where T : NestedSet<T>;

        void PrintTree<T>(List<T> treeList) where T : NestedSet<T>;
        void PrintTree<T>(SortedDictionary<int, T> tree) where T : NestedSet<T>;
        string PrintTreeToString<T>(List<T> treeList) where T : NestedSet<T>;
    }
}
