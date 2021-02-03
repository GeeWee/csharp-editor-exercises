namespace Exercises.Exercise5
{
    public class Exercise5
    {
        /// <summary>
        /// We use MyClass everywhere! But to test it we have to make an interface instead.
        /// Create an interface for MyClass and change all code paths in Exercise5 to use the interface instead!
        /// </summary>

        public MyClass MyFirstClass { get; set; }
        public MyClass MySecondClass { get; set; }
        public MyClass MyThirdClass { get; set; }

        public void DoSomethingWitHFirstClass() => MyFirstClass.DoSomething();

        public Exercise5(MyClass oneClass, MyClass mySecondClass)
        {
            // do something with the classes here
        }

    }

    public class MyClass
    {
        public void DoSomething()
        {
            // does something
        }
    }
}