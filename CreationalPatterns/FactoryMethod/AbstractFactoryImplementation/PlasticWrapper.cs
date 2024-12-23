using System;

namespace FactoryMethod.AbstractFactoryImplementation;

public class PlasticWrapper : IWrapper
{
    public string GetWrapper()
    {
        return "Plastic Wrapper";
    }
}
