﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Domain.Security.Token
{
    public class RefreshToken : JsonWebToken
    {
        public RefreshToken(string token, long expiration) : base(token, expiration) { }
    }
}
