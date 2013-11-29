﻿// LICENSE: LGPL 3 - https://www.gnu.org/licenses/lgpl-3.0.txt

// s. http://blog.marcel-kloubert.de


using System;

namespace MarcelJoachimKloubert.CLRToolbox.Data
{
    /// <summary>
    /// Common implementation of an <see cref="IConverter" /> object.
    /// </summary>
    public partial class CommonConverter : ConverterBase
    {
        #region Constructors (2)

        /// /// <summary>
        /// Initializes a new instance of the <see cref="CommonConverter" /> class.
        /// </summary>
        /// <param name="syncRoot">The value for the <see cref="TMObject._SYNC" /> field.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="syncRoot" /> is <see langword="null" />.
        /// </exception>
        public CommonConverter(object syncRoot)
            : base(syncRoot)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommonConverter" /> class.
        /// </summary>
        public CommonConverter()
            : base()
        {

        }

        #endregion Constructors

        #region Methods (2)

        // Public Methods (1) 

        /// <summary>
        /// 
        /// </summary>
        /// <see cref="ConverterBase.ChangeType{T}(object)" />
        public override T ChangeType<T>(object value, IFormatProvider provider)
        {
            this.ParseInputValueForChangeType<T>(ref value, provider);

            if (value is T)
            {
                return (T)value;
            }

            return value != null ? (T)global::System.Convert.ChangeType(value, typeof(T), provider) : default(T);
        }
        // Private Methods (1) 

        partial void ParseInputValueForChangeType<T>(ref object value, IFormatProvider provider);

        #endregion Methods
    }
}
