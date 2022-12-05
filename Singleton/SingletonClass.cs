namespace Singleton
{
    internal class SingletonClass
    {
        private SingletonClass() { }

        private static SingletonClass? _instance; 

        public static SingletonClass Instance { 
            get
            {
                if(_instance is null)
                    _instance= new SingletonClass();

                return _instance;
            }
        }
        
        public void SomeMethod()
        {
            Console.WriteLine("This is a complex build logic.");
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
