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
    public class Boar : IAnimal
    {
        public string Name { get; set; }
        public bool IsAlive { get; set; } = true;
        public bool IsTrained { get; set; } = false;

        public Boar(string name) => Name = name;

        void IAnimal.Talk() => Console.WriteLine("The boar snorts loudly.");
        void IAnimal.Attack() => Console.WriteLine("The boar charges aggressively.");
        void IAnimal.Eat() => Console.WriteLine("The boar munches on roots and leaves.");
        void IAnimal.Move() => Console.WriteLine("The boar trots around the area.");
    }
}
//************************************************MAR26 END OF FILE********************************************