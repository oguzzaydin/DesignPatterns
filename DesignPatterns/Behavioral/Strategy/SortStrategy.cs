﻿using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Strategy
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}