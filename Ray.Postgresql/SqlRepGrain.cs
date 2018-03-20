﻿using Ray.Core;
using Ray.Core.EventSourcing;

namespace Ray.Postgresql
{
    public abstract class SqlRepGrain<K, S, W> : RepGrain<K, S, W>, ISqlGrain
    where S : class, IState<K>, new()
    where W : MessageWrapper
    {
        public abstract SqlGrainConfig ESSQLTable { get; }
    }
}
