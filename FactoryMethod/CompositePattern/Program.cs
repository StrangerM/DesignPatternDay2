using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWorker worker = new FileWorker();
            FileComponent file = new FileComponent("picture.png");
            Console.WriteLine("FileWorker: I get a file:");
            worker.ClientCode(file);

            FolderComponent roote = new FolderComponent("Root Directory");

            FolderComponent node1 = new FolderComponent("Node 1");

            node1.AddComponent(new FileComponent("data.txt"));
            node1.AddComponent(new FileComponent("data1.txt"));

            FolderComponent node2 = new FolderComponent("Node 2");
            node2.AddComponent(new FileComponent("data2.txt"));

            roote.AddComponent(node1);
            roote.AddComponent(node2);

            Console.WriteLine("FileWorker: Now I've got a file system:");

            worker.ClientCode(roote);

            Console.Write("FileWorker: I don't need to check the components classes even when managing the tree:\n");
            worker.ClientCode2(roote, file);
        }
    }
}
