﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public interface IUser
    {
        bool Login(string userName, string password);
    }
}