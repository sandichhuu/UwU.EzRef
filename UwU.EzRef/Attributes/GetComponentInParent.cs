using System;

namespace UwU.EzRef
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class GetComponentInParent : Attribute
    {
    }
}