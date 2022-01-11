﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Logging
{
    public interface ILogger
    {
        /// <summary>
        /// Level info, error,warning 
        /// </summary>
        /// <param name="level"></param>
        /// <param name="message"></param>
        void Log(string level, string message);

    }
}
