using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A base class representing fruit
    /// </summary>
    public abstract class Fruit : IBlendable
    {
        // Virtual means derived classes have the OPTION to override
        public abstract string Blend();
    }
}
