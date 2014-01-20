﻿// LICENSE: LGPL 3 - https://www.gnu.org/licenses/lgpl-3.0.txt

// s. http://blog.marcel-kloubert.de


namespace MarcelJoachimKloubert.CLRToolbox.Diagnostics.Remoting
{
    /// <summary>
    /// A basic remote debugger.
    /// </summary>
    public abstract class RemoteDebuggerBase : IRemoteDebugger
    {
        #region Fields (1)

        /// <summary>
        /// An unique object for thread safe operations.
        /// </summary>
        protected readonly object _SYNC = new object();

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteDebuggerBase"/> class.
        /// </summary>
        protected RemoteDebuggerBase()
        {

        }

        #endregion Constructors

        #region Methods (3)

        // Public Methods (3) 

        /// <summary>
        /// 
        /// </summary>
        /// <see cref="IRemoteDebugger.Close()" />
        public abstract void Close();

        /// <summary>
        /// 
        /// </summary>
        /// <see cref="IRemoteDebugger.Open(string, string, byte[])" />
        public abstract void Open(string user, string pwd, byte[] client);

        /// <summary>
        /// 
        /// </summary>
        /// <see cref="IRemoteDebugger.SendMessage(int, string)" />
        public abstract string SendMessage(int id, string args);

        #endregion Methods
    }
}
