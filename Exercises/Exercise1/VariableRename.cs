using System.Collections.Generic;
using Exercises.Exercise4;

namespace Exercises.Exercise1
{
    public class VariableRename
    {
        /// <summary>
        /// Oh no! all the fruits are named the wrong names!
        /// Fix them, both in the constructor and the FruitSalad.AddX methods!
        /// </summary>
        public void FirstExercise()
        {
            var pear = new Apple();
            var apple = new Pear();
            var orange = new Lime();
            var lime = new Orange();


            // Creat the CustomFruitSaladImplementation
            var fruitSalad = new FruitSalad();

            fruitSalad.AddApple(pear);
            fruitSalad.AddPear(apple);
            fruitSalad.AddLime(orange);
            fruitSalad.AddOrange(lime);
        }
    }
}