﻿// LICENSE: LGPL 3 - https://www.gnu.org/licenses/lgpl-3.0.txt

// s. http://blog.marcel-kloubert.de

using System.Collections.Generic;
using System.Linq;

namespace MarcelJoachimKloubert.CLRToolbox.Helpers
{
    static partial class CollectionHelper
    {
        #region Methods (1)

        // Public Methods (1) 

        /// <summary>
        ///
        /// </summary>
        /// <see cref="Enumerable.Single{TSource}(IEnumerable{TSource})" />
        /// <remarks>Replaced in .NET 3.5 for .NET 2.0</remarks>
        public static T Single<T>(IEnumerable<T> seq)
        {
            return global::System.Linq.Enumerable.Single<T>(seq);
        }

        #endregion Methods
    }
}