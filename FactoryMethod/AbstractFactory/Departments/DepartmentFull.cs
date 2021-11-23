using AbstractFactory.Jackets;
using AbstractFactory.PartsOfJackets;
using BuilderPattern.Jackets;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Departments
{
    public class DepartmentFull : IDepartments
    {
       
        public IJacket OrderJacketA() => new JacketModel1();


        public IJacket OrderJacketB() => new JacketModel2();


        public IJacket OrderJacketC() => new JacketModel3();


        public IParts OrderPartBack() => new Back();


        public IParts OrderPartForward() => new Forward();


        public IParts OrderPartCollar() => new Сollar();


        public IParts OrderPartHood() => new Hood();


        public IParts OrderPartSleew() => new Sleeves();

    }
}
