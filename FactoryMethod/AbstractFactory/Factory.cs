using AbstractFactory.Departments;
using AbstractFactory.PartsOfJackets;
using BuilderPattern.Jackets;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class Factory
    {
        private IJacket _jacket { get; set; }
        private Back _Back { get; set; }
        private Forward _Forward { get; set; }
        private Hood _Hood { get; set; }
        private Sleeves _Sleew { get; set; }
        private Сollar _Collar { get; set; }

        public Factory(IDepartments department, IJacket jacket)
        {
            _jacket = jacket;
            _Back = (Back)department.OrderPartBack();
            _Forward = (Forward)department.OrderPartForward();
            _Hood = (Hood)department.OrderPartHood();
            _Sleew = (Sleeves)department.OrderPartSleew();
            _Collar = (Сollar)department.OrderPartCollar();
        }

        public void Create()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"Зшивання спини {_jacket.GetType().Name} {_Back.GetType().Name}, з передом моделі {_Forward.GetType().Name}, пришивання рукавів моделі- {_Sleew.GetType().Name}, пришивання коміру моделі- {_Collar}, пришивання капюшона моделі- {_Hood.GetType().Name} ");
        }
    }
}
