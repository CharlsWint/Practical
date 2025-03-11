//#############################################################################################################
/*
 * Matthew
 * St10258193
 * Group 2
 * PROG6221
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical
{
    //*****************************************************************************************************
    public class Wolf : IAnimal
    {
        public string Name { get; set; }
        public bool IsAlive { get; set; } = true;
        public bool IsTrained { get; set; } = false;

        public Wolf(string name) => Name = name;

        void IAnimal.Talk() => Console.WriteLine("The wolf growls.");
        void IAnimal.Attack() => Console.WriteLine("The wolf lunges and bites.");
        void IAnimal.Eat() => Console.WriteLine("The wolf devours its prey.");
        void IAnimal.Move() => Console.WriteLine("The wolf prowls through the forest.");
    }
}
//************************************************MAR26 END OF FILE********************************************