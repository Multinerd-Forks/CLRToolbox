﻿// LICENSE: LGPL 3 - https://www.gnu.org/licenses/lgpl-3.0.txt

// s. http://blog.marcel-kloubert.de

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Principal;
using System.Threading;

namespace MarcelJoachimKloubert.CLRToolbox.Diagnostics
{
    partial class LoggerFacadeBase
    {
        #region Nested Classes (1)

        private sealed partial class LogMessage : TMObject, ILogMessage
        {
            #region Fields (9)

            private Assembly _assembly;
            private IList<LoggerFacadeCategories> _categories;
#if !WINDOWS_PHONE
            private global::System.Runtime.Remoting.Contexts.Context _context;
#endif
            private Guid _id;
            private string _logTag;
            private MemberInfo _member;
            private object _message;
            private IPrincipal _principal;
            private Thread _thread;
            private DateTimeOffset _time;

            #endregion Fields

            #region Properties (10)

            public Assembly Assembly
            {
                get { return this._assembly; }

                set { this._assembly = value; }
            }

            public IList<LoggerFacadeCategories> Categories
            {
                get { return this._categories; }

                set { this._categories = value; }
            }

#if !WINDOWS_PHONE

            public global::System.Runtime.Remoting.Contexts.Context Context
            {
                get { return this._context; }

                set { this._context = value; }
            }

#endif

            public Guid Id
            {
                get { return this._id; }

                set { this._id = value; }
            }

            public string LogTag
            {
                get { return this._logTag; }

                set { this._logTag = value; }
            }

            public MemberInfo Member
            {
                get { return this._member; }

                set { this._member = value; }
            }

            public object Message
            {
                get { return this._message; }

                set { this._message = value; }
            }

            public IPrincipal Principal
            {
                get { return this._principal; }

                set { this._principal = value; }
            }

            public Thread Thread
            {
                get { return this._thread; }

                set { this._thread = value; }
            }

            public DateTimeOffset Time
            {
                get { return this._time; }

                set { this._time = value; }
            }

            #endregion Properties

            #region Methods (4)

            // Public Methods (4) 

            public override bool Equals(object other)
            {
                if (other is IIdentifiable)
                {
                    return this.Equals(other as IIdentifiable);
                }

                if (other is Guid)
                {
                    return this.Equals((Guid)other);
                }

                return base.Equals(other);
            }

            public bool Equals(IIdentifiable other)
            {
                return other != null ? this.Equals(other.Id) : false;
            }

            public bool Equals(Guid other)
            {
                return this.Id == other;
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            #endregion Methods
        }

        #endregion Nested Classes
    }
}