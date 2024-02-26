using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace FactoryPatternApp
{
    
    static class PhoneFactory
    {
        
        public static ICallable GetPhone(string phoneType)
        {
            switch (phoneType.ToLower())
            {
                case "android":
                    return new AndroidPhone();
                case "apple":
                case "iphone":
                    return new ApplePhone();
                default:
                    return new AndroidPhone();
            }
        }
    }
}

