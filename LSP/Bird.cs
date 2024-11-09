using System;

namespace LSP
{
    public abstract class Bird
    {
        public virtual string BirdSay()
        {
            return "Я птица";
        }
        public virtual string Statement()
        {
            return "Я должна уметь летать";
        }
    }
}
