using System;

namespace chapterTwoDelegatesAndTypes

{
    //declare delegate type
    delegate void StringProcessor(string input);

    class Person
    {
        readonly string name;

        public Person(string name)
        {
            this.name = name;
        }

        //compatible instance method of delegate type StringProcessor defined above
        public void Say(string message)
        {
            Console.WriteLine("{0} says: {1}", name, message);
        }
    }

    class Background
    {
        //compatible instance method of delegate type StringProcessor defined above
        public static void Note(string note)
        {
            Console.WriteLine(" ( {0} ) ", note);
        }
    }

    class SimpleDelegateUse
    {
        private static void Main()
        {
            Person jon = new Person("Jon");
            Person tom = new Person("Tom");
            StringProcessor jonsVoice, tomsVoice, background;

            //the next three lines are three delegate instances
            jonsVoice = new StringProcessor(jon.Say);  
            tomsVoice = new StringProcessor(tom.Say);
            background = new StringProcessor(Background.Note);

            //this calls the Say method on the Person object with the name Jon
            jonsVoice("Hello, son.");    
            tomsVoice.Invoke("Hello, Daddy!");
            background("An airplane flies past.");

        }
    }
}