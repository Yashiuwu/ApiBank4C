﻿using Ardalis.Specification;

namespace Aplication.Interface
{
    public interface IRepositoryAsync<T> : IRepositoryBase<T> where T : class
    {
    }

    public interface IReadRepositoryAsync<T> : IRepositoryBase<T> where T : class
    {

    }
}
