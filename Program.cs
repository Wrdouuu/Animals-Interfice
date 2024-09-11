using System;

class ANIMALSEDIBLES
{
  static void Main(string[] args)
  {
    Animals[] animals = new Animals[2];
    animals[0] = new Tiger();
    animals[1] = new Chicken();

    foreach (Animals animal in animals)
    {
      Console.WriteLine(animal.MakeSound());
    }
  }
}
