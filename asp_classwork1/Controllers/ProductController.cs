﻿using asp_classwork1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_classwork1.Controllers
{
    public class ProductController : Controller
    {
        List<Card> _cards = new List<Card>
        {
            new Card(1, "card1", "Lorem Ipsum is simply dummy text of the printing ", "data:image/jpeg;base64,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", 1200),
            new Card(2, "card2", "Lorem Ipsum is simply dummy text of the printing ", "data:image/jpeg;base64,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", 2200),
            new Card(3, "card3", "Lorem Ipsum is simply dummy text of the printing ", "data:image/jpeg;base64,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", 3400)

        };
        public ActionResult Product()
        {
            return View(_cards);
        }
    }
}
