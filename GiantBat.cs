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
    public class GiantBat : IAnimal
    {
        public string Name { get; set; }
        public bool IsAlive { get; set; } = true;
        public bool IsTrained { get; set; } = true;

        public GiantBat(string name) => Name = name;

        void IAnimal.Talk() => Console.WriteLine("The giant bat screeches.");
        void IAnimal.Attack() => Console.WriteLine("The giant bat swoops down to attack.");
        void IAnimal.Eat() => Console.WriteLine("The giant bat feasts on fruits and insects.");
        void IAnimal.Move() => Console.WriteLine("The giant bat flies through the night sky.");
    }
}
//************************************************MAR26 END OF FILE********************************************