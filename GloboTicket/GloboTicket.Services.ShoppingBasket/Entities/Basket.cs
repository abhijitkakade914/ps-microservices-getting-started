﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloboTicket.Services.ShoppingBasket.Entities
{
    public class Basket
    {
        public Guid BasketId { get; set; }

        public Guid UserId { get; set; }
    }
}
