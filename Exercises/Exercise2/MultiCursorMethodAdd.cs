using System.Collections.Generic;
using Exercises.Exercise4;
using Exercises.Models;

namespace Exercises.Exercise2
{
    public class MultiCursorMethodAdd
    {
        /// <summary>
        /// Oh no! all the fruits are named the wrong names!
        /// Fix them, both in the constructor and the FruitSalad.AddX methods!
        /// </summary>
        public void SecondExercise()
        {
            var apple = new Apple();
            var pear = new Pear();
            var lime = new Lime();
            var orange = new Orange();


            // Create the CustomFruitSaladImplementation
            var fruitSalad = new CustomFruitSaladImplementation();

            // Implement an AddX for each fruit type above and call it
            // It doesn't have to do anything
            // E.g. fruitSalad.AddApple(apple);
            // fruitSalad.AddPear(pear);
        }
    }
}