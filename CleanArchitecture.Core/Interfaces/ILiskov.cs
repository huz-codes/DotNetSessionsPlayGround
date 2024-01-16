namespace CleanArchitecture.Core.Interfaces
{
    public interface ILiskov{}

    public class MainUsing
    {
        private IAnimal _animal;

        public void ShowHowDodRuns()
        {
            _animal = new Dog();
            _animal.Run();
        }

        public void ShowHowSharkSwims()
        {
            _animal = new Shark();
            _animal.Run();
        }

    }

    public interface IAnimal
    {
        void Eat();
        void Run();
    }

    public class Dog : IAnimal
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class Cat : IAnimal
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class Shark : IAnimal
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Swim();
        }

        private void Swim()
        {

        }
    }

}
