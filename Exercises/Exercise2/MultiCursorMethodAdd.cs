using System.Collections.Generic;
using Exercises.Exercise4;

namespace Exercises.Exercise2
{
    public class MultiCursorMethodAdd
    {
        /// <summary>
        /// Oh no! We have to implement our own fruit salad.
        /// Create a class, and give it some AddX() methods for each fruit.
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