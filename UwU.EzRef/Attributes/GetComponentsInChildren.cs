using System;

namespace UwU.EzRef
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    [PropertyType(typeof(Array))]
    public class GetComponentsInChildren : Attribute
    {
        public bool includeInactive { get; set; }

        public GetComponentsInChildren()
        {
            includeInactive = false;
        }

        public GetComponentsInChildren(bool includeInactive)
        {
            this.includeInactive = includeInactive;
        }
    }
}