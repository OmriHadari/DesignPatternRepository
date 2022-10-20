using SimpleFactory.AbstractFactory;
using SimpleFactory.AbstractFactory.Interfaces;
using SimpleFactory.FactoryMethod;
using SimpleFactory.FactoryMethod.Interfaces;
using SimpleFactory.Interfaces;
using System;

namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SimpleFactory
            //IAnimal animal = null;
            //string userInput = null;
            //int input = -1;
            //ISimpleFactory simpleFactory = new SimpleFactory();
            //
            //Console.WriteLine("Simple factory demo");
            //Console.WriteLine("Please select desired animal:");
            //Console.WriteLine("     0 - Dog");
            //Console.WriteLine("     1 - Cat");
            //
            //input = Convert.ToInt32(Console.ReadLine());
            //
            //animal = simpleFactory.CreateAnimal(convertedInput);
            //animal.Speak();
            //animal.Action();
            //
            //Console.ReadLine(); 
            #endregion

            #region FactoryMethod
            //IAnimalFactory animalFactory = null;
            //IAnimal animal = null;
            //int input = -1;
            //
            //Console.WriteLine("Factory Methos demo");
            //Console.WriteLine("Please select desired animal:");
            //Console.WriteLine("     0 - Dog");
            //Console.WriteLine("     1 - Cat");
            //
            //input = Convert.ToInt32(Console.ReadLine());
            //
            //switch (input)
            //{
            //    case 0:
            //        animalFactory = new DogFactory();
            //        //animal = animalFactory.CreateAnimal();
            //        animal = animalFactory.CreateAnimalBeautified();
            //        break;
            //    case 1:
            //        animalFactory = new CatFactory();
            //        //animal = animalFactory.CreateAnimal();
            //        animal = animalFactory.CreateAnimalBeautified();
            //        break;
            //    default:
            //        break;
            //}
            //
            ////animal.Speak();
            ////animal.Action();
            //
            //Console.ReadLine(); 
            #endregion

            #region AbstractFactory
            IAbstractAnimalFactory animalFactory = null;
            IDog dog = null;
            ICat cat = null;
            int firstInput = -1;
            int secondInput = -1;

            Console.WriteLine("Abstract factory demo");
            Console.WriteLine("Please select classification:");
            Console.WriteLine("     0 - Pet");
            Console.WriteLine("     1 - Wild");

            firstInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please select desired animal:");
            Console.WriteLine("     0 - Dog");
            Console.WriteLine("     1 - Cat");

            secondInput = Convert.ToInt32(Console.ReadLine());

            if (firstInput == 0)
            {
                animalFactory = new PetAnimalFactory();
                if (secondInput == 0)
                    dog = animalFactory.GetDog();
                else if (secondInput == 1)
                    cat = animalFactory.GetCat();
            }
            else if (firstInput == 1)
            {
                animalFactory = new WildAnimalFactory();
                if (secondInput == 0)
                    dog = animalFactory.GetDog();
                else if (secondInput == 1)
                    cat = animalFactory.GetCat();
            }
            else
                throw new Exception();

            switch (secondInput)
            {
                case 0:
                    dog.Speak();
                    dog.Action();
                    break;
                case 1:
                    cat.Speak();
                    cat.Action();
                    break;
                default:
                    break;
            }

            Console.ReadLine();
            #endregion
        }

        //private static object Generate()
        //{
        //    //switch (firstInput)
        //    //{
        //    //    case 0:
        //    //        switch (secondInput)
        //    //        {
        //    //            case 0:
        //    //                animalFactory = new PetAnimalFactory();
        //    //                dog = animalFactory.GetDog();
        //    //                break;
        //    //            case 1:
        //    //                animalFactory = new PetAnimalFactory();
        //    //                cat = animalFactory.GetCat();
        //    //                break;
        //    //            default:
        //    //                break;
        //    //        }
        //    //        break;
        //    //    case 1:
        //    //        switch (secondInput)
        //    //        {
        //    //            case 0:
        //    //                animalFactory = new WildAnimalFactory();
        //    //                dog = animalFactory.GetDog();
        //    //                break;
        //    //            case 1:
        //    //                animalFactory = new WildAnimalFactory();
        //    //                cat = animalFactory.GetCat();
        //    //                break;
        //    //            default:
        //    //                break;
        //    //        }
        //    //        break;
        //    //    default:
        //    //        break;
        //    //}
        //}
    }
}
