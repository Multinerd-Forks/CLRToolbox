﻿// LICENSE: LGPL 3 - https://www.gnu.org/licenses/lgpl-3.0.txt

// s. http://blog.marcel-kloubert.de


using System;
using System.Collections.Generic;

namespace MarcelJoachimKloubert.CLRToolbox.Helpers
{
    static partial class CollectionHelper
    {
        #region Methods (1)

        // Public Methods (1) 

        /// <summary>
        /// Returns the one and only element of a sequence.
        /// </summary>
        /// <typeparam name="T">Type of the elements.</typeparam>
        /// <param name="seq">The sequence.</param>
        /// <returns>The element.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="seq" /> is <see langword="null" />.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// <paramref name="seq" /> does not exactly contain one element (none or more than one).
        /// </exception>
        public static T Single<T>(IEnumerable<T> seq)
        {
            if (seq == null)
            {
                throw new ArgumentNullException("seq");
            }

            IList<T> list = seq as IList<T>;
            if (list != null)
            {
                switch (list.Count)
                {
                    case 0:
                        throw new InvalidOperationException(_ERR_MSG_SINGLE_NO_ELEMENTS);

                    case 1:
                        return list[0];
                }
            }
            else
            {
                using (IEnumerator<T> enumerator = seq.GetEnumerator())
                {
                    if (!enumerator.MoveNext())
                    {
                        throw new InvalidOperationException(_ERR_MSG_SINGLE_NO_ELEMENTS);
                    }

                    T result = enumerator.Current;
                    if (!enumerator.MoveNext())
                    {
                        return result;
                    }
                }
            }

            throw new InvalidOperationException(_ERR_MSG_SINGLE_MORE_THAN_ONE_ELEMENT);
        }

        #endregion Methods
    }
}
