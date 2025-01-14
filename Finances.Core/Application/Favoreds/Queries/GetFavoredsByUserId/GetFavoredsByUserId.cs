﻿using Finances.Common.Data;
using MediatR;
using System;
using System.Collections.Generic;

namespace Finances.Core.Application.Favoreds.Queries.GetFavoredsByUserId
{
    public class GetFavoredsByUserId : IRequest<JsonDefaultResponse>
    {
        public Guid UserId { get; set; }
    }
}
