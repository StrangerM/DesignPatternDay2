using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class FileWorker
    {
        public void ClientCode(IComponent file)
        {
            Console.WriteLine($"RESULT: {file.Operation()}\n");
        }

        public void ClientCode2(IComponent folder1, IComponent folder2)
        {
            if (folder1.IsComposite())
            {
                folder1.AddComponent(folder2);
            }

            Console.WriteLine($"RESULT: {folder1.Operation()} ");
        }
    }
}
