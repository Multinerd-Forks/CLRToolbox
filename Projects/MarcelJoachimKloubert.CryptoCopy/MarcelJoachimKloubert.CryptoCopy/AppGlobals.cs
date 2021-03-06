﻿// LICENSE: GPL 3 - https://www.gnu.org/licenses/gpl-3.0.txt

// s. http://blog.marcel-kloubert.de


using System;

namespace MarcelJoachimKloubert.CryptoCopy
{
    internal static class AppGlobals
    {
        #region Fields (3)

        internal const int DEFAULT_PWD_INTERATIONS = 1000;
        internal static readonly byte[] DEFAULT_SEED = new Guid("{56C56871-9E69-4BED-9421-A4158D895129}").ToByteArray();
        internal const string FILENAME_META = "0.bin";

        #endregion Fields
    }
}
