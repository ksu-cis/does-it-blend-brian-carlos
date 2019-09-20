using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// Interface for items that can be blended.
    /// </summary>
    interface IBlendable
    {
        /// <summary>
        /// Blends object
        /// </summary>
        /// <returns>String describing the blended object</returns>
        string Blend();
    }
}
