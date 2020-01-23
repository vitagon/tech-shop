using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShop.Models;

namespace TechShop.Services
{
    public class NestedSetService : INestedSetService
    {
        public SortedDictionary<int, T> BuildTreeAsDictionary<T>(ref List<T> entitiesList, int parentId = 0) where T: NestedSet<T>
        {
            SortedDictionary<int, T> treeAsDictionary = new SortedDictionary<int, T>();

            for (int i = entitiesList.Count - 1; i >= 0; i--)
            {
                T entity = entitiesList[i];
                if (entity.ParentId == parentId)
                {
                    SortedDictionary<int, T> children = BuildTreeAsDictionary(ref entitiesList, entity.Id);

                    if (children.Count != 0)
                    {
                        entity.Children = children;
                    }
                    treeAsDictionary[entity.Id] = entity;
                    entitiesList.RemoveAll(x => x.Id == entity.Id);
                }
            }
            return SortDictionaryTree(treeAsDictionary);
        }

        public List<T> BuildTreeAsList<T>(ref List<T> entitiesList, int parentId = 0) where T : NestedSet<T>
        {
            SortedDictionary<int, T> treeAsDictionary = BuildTreeAsDictionary(ref entitiesList, parentId);
            List<T> treeAsList = DictionaryTreeToList(treeAsDictionary);
            return SortListTree(treeAsList);
        }

        public List<T> DictionaryTreeToList<T>(SortedDictionary<int, T> tree) where T : NestedSet<T>
        {
            List<T> entitiesList = new List<T>();

            foreach (KeyValuePair<int, T> keyValuePair in tree)
            {
                T entity = keyValuePair.Value;

                if (entity.Children != null && entity.Children.Count != 0)
                {
                    entity.ChildrenList = DictionaryTreeToList(entity.Children);
                }
                entitiesList.Add(entity);
            }
            return entitiesList;
        }

        public void PrintTree<T>(List<T> treeList) where T : NestedSet<T>
        {
            foreach (T entity in treeList)
            {
                int lvl = entity.Level;
                string lvlPrefix = "";
                for (int i = 1; i < lvl; i++)
                {
                    lvlPrefix += "-";
                }
                StringBuilder description = new StringBuilder();
                description.Append("{");
                description.Append($"lft: {entity.Lft}, ");
                description.Append($"rgt: {entity.Rgt}");
                //description.Append($"id: {entity.Id}");
                description.Append("}");
                Console.WriteLine(lvlPrefix + entity.Name + " " + description.ToString());
                if (entity.ChildrenList != null && entity.ChildrenList.Count != 0)
                {
                    PrintTree(entity.ChildrenList);
                }
            }
        }

        public string PrintTreeToString<T>(List<T> treeList) where T : NestedSet<T>
        {
            StringBuilder treeString = new StringBuilder();
            foreach (T entity in treeList)
            {
                int lvl = entity.Level;
                string lvlPrefix = "";
                for (int i = 1; i < lvl; i++)
                {
                    lvlPrefix += "-";
                }
                StringBuilder description = new StringBuilder();
                description.Append("{");
                description.Append($"lft: {entity.Lft}, ");
                description.Append($"rgt: {entity.Rgt}");
                description.Append("}");
                if (lvl == 0)
                {
                    treeString.Append(lvlPrefix + entity.Name + " " + description.ToString() + "\r\n\r\n");
                }
                else
                {
                    treeString.Append(lvlPrefix + entity.Name + " " + description.ToString() + "\r\n");
                }
                
                if (entity.ChildrenList != null && entity.ChildrenList.Count != 0)
                {
                    string childStr = PrintTreeToString(entity.ChildrenList);
                    treeString.Append(childStr);
                }

                if (lvl == 1) treeString.Append("\r\n");
            }
            return treeString.ToString();
        }

        public void PrintTree<T>(SortedDictionary<int, T> tree) where T : NestedSet<T>
        {
            foreach (KeyValuePair<int, T> keyValuePair in tree)
            {
                T entity = keyValuePair.Value;
                int lvl = entity.Level;
                string lvlPrefix = "";
                for (int i = 1; i < lvl; i++)
                {
                    lvlPrefix += "-";
                }
                Console.WriteLine(lvlPrefix + entity.Name + " {" + entity.Id + "}");
                if (entity.Children != null && entity.Children.Count != 0)
                {
                    PrintTree(entity.Children);
                }
            }
        }

        public List<T> SortListTree<T>(List<T> treeList) where T : NestedSet<T>
        {
            treeList.Sort((a, b) =>
            {
                if (a.Rgt > b.Rgt) return 1;
                if (a.Rgt < b.Rgt) return -1;
                return 0;
            });

            foreach (T entity in treeList)
            {
                if (entity.ChildrenList != null && entity.ChildrenList.Count > 1)
                {
                    List<T> sortedChildList = SortListTree(entity.ChildrenList);
                    entity.ChildrenList = sortedChildList;
                }
            }
            return treeList;
        }

        public SortedDictionary<int, T> SortDictionaryTree<T>(SortedDictionary<int, T> tree) where T : NestedSet<T>
        {
            SortedDictionary<int, T> sortedDictionary = new SortedDictionary<int, T>(tree);
            sortedDictionary.OrderBy(kSelector => kSelector.Value.Rgt);

            foreach (KeyValuePair<int, T> kvPair in sortedDictionary)
            {
                T entity = kvPair.Value;
                if (entity.ChildrenList != null && entity.ChildrenList.Count > 1)
                {
                    SortedDictionary<int, T> sortedChildDictionary = SortDictionaryTree(entity.Children);
                    entity.Children = sortedChildDictionary;
                }
            }
            return sortedDictionary;
        }
    }
}
