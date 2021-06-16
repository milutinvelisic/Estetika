﻿using Estetika.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.Application.Queries
{
    public interface IGetOneUserQuery : IQuery<int, UserDto>
    {
    }
}
