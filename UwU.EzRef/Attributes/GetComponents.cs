using System;

namespace UwU.EzRef
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    [PropertyType(typeof(Array))]
    public class GetComponents : Attribute
    {
    }
}