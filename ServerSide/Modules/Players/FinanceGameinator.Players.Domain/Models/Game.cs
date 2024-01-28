﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceGameinator.Players.Domain.Models
{
    public class Game
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public Game(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
