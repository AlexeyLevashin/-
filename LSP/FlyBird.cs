using System;

namespace LSP
{
    public class FlyBird:InterfaceAll, InterfaceFly
    {
        public string BirdSay()
        {
            return "Я летающая птица";
        }
        public string Statement()
        {
            return "я умею летать";
        }

    }
}
