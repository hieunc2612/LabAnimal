namespace LabAnimal
{
    internal class Animal
    {
        public string name { get; protected set; }
        public string favouriteFood { get; protected set; }

        public Animal(string name, string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.name} and my favourite food is {this.favouriteFood}";
        }
    }
}