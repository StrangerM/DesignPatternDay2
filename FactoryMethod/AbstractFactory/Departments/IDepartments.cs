using AbstractFactory.PartsOfJackets;
using BuilderPattern.Jackets;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Departments
{
    interface IDepartments
    {
        IJacket OrderJacketA();
        IJacket OrderJacketB();
        IJacket OrderJacketC();

        IParts OrderPartBack();
        IParts OrderPartForward();
        IParts OrderPartCollar();
        IParts OrderPartHood();
        IParts OrderPartSleew();

    }
}
