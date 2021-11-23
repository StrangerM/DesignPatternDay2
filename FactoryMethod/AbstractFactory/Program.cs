using AbstractFactory;
using AbstractFactory.Departments;
using AbstractFactory.Jackets;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentFull department = new DepartmentFull();
            JacketModel1 modelA= (JacketModel1)department.OrderJacketA();
            JacketModel2 modelB = (JacketModel2)department.OrderJacketB();
            JacketModel3 modelC = (JacketModel3)department.OrderJacketC();
            Factory factory = new Factory(department, modelA);
            factory.Create();
            factory.Create();
            Factory factory2 = new Factory(department, modelB);
            Factory factory3 = new Factory(department, modelC);
            for (int x = 0; x < 5; x++)
            {
                factory2.Create();
            }
            for (int x = 0; x < 3; x++)
            {
                factory3.Create();
            }
        }
    }
}
