using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeveloperTest.TreeClasses;

namespace DeveloperTestRunner
{
    internal class BuildTreeTests : Tests
    {
        public void BuildTreeTest()
        {
            Input[] inputs = new Input[]
            {
                    new Input(1),
                    new Input(3,1),
                    new Input(19,3),
                    new Input(22,1),
                    new Input(4,1),
                    new Input(5,22),
            };
            
            TreeNode rootNode = Implementation.BuildTree(inputs);
            var treeNodes = new List<TreeNode>();
            rootNode.Traverse(x => treeNodes.Add(x));

            Tester.AreEqual(treeNodes[0].Id, 1);

            Tester.AreEqual(treeNodes[1].Id, 3);
            Tester.AreEqual(treeNodes[1].Parent.Id, treeNodes[0].Id);
            Tester.AreEqual(treeNodes[1].Parent.Id, 1);

            Tester.AreEqual(treeNodes[2].Id, 19);
            Tester.AreEqual(treeNodes[2].Parent.Id, treeNodes[1].Id);
            Tester.AreEqual(treeNodes[2].Parent.Id, 3);

            Tester.AreEqual(treeNodes[3].Id, 22);
            Tester.AreEqual(treeNodes[3].Parent.Id, treeNodes[0].Id);
            Tester.AreEqual(treeNodes[3].Parent.Id, 1);

            Tester.AreEqual(treeNodes[4].Id, 5);
            Tester.AreEqual(treeNodes[4].Parent.Id, treeNodes[3].Id);
            Tester.AreEqual(treeNodes[4].Parent.Id, 22);

            Tester.AreEqual(treeNodes[5].Id, 4);
            Tester.AreEqual(treeNodes[5].Parent.Id, treeNodes[0].Id);
            Tester.AreEqual(treeNodes[5].Parent.Id, 1);
        }
    }
}
