﻿// LICENSE: LGPL 3 - https://www.gnu.org/licenses/lgpl-3.0.txt

// s. http://blog.marcel-kloubert.de


using System;

namespace MarcelJoachimKloubert.CLRToolbox
{
    /// <summary>
    /// The mother of all objects.
    /// </summary>
    public partial class TMObject : ITMObject
    {
        #region Constructors (2)

        /// <summary>
        /// Initializes a new instance of the <see cref="TMObject" /> class.
        /// </summary>
        /// <param name="syncRoot">The value for <see cref="TMObject._SYNC" /> field..</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="syncRoot" /> is <see langword="null" />.
        /// </exception>
        public TMObject(object syncRoot)
        {
            if (syncRoot == null)
            {
                throw new ArgumentNullException("syncRoot");
            }

            this._SYNC = syncRoot;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TMObject" /> class.
        /// </summary>
        public TMObject()
            : this(new object())
        {

        }

        #endregion Constructors

        #region Properties (1)

        /// <summary>
        /// 
        /// </summary>
        /// <see cref="ITMObject.Tag" />
        public virtual object Tag
        {
            get { return this._tag; }

            set { this._tag = value; }
        }

        #endregion Properties
    }
}
