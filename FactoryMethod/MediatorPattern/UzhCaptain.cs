﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class UzhCaptain : Captain
    {
        public UzhCaptain(Mediator mediator) : base(mediator)
        {

        }
        public override void Notify(string message)
        {
            Console.WriteLine("Message to Uzh cap" + message);
        }
    }
}
