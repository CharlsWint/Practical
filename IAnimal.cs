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
    internal interface IAnimal
    {
        string Name { get; set; }
        bool IsAlive { get; set; }
        bool IsTrained { get; set; }

        void Talk();
        void Attack();
        void Eat();
        void Move();
    }   
}
//************************************************MAR26 END OF FILE********************************************