﻿namespace LabAnimal
{
    internal class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood)
        {
        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + System.Environment.NewLine + "DJAAF";
        }
    }
}