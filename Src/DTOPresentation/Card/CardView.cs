﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aduaba.DTOPresentation.Card
{
    public class CardView
    {
        public string Id { get; set; }
        public string CardNumber { get; set; }

        public string ExpiryDate { get; set; }
        public string CardType { get; set; }
    }
}
