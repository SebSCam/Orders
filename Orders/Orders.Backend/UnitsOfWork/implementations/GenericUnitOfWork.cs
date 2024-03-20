﻿using Orders.Backend.Repositories.Interfaces;
using Orders.Backend.UnitsOfWork.Interfaces;
using Orders.Shared.Responses;

namespace Orders.Backend.UnitsOfWork.implementations
{
    public class GenericUnitOfWork<T> : IGenericUnitOfWork<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;

        public GenericUnitOfWork(IGenericRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<ActionResponse<T>> AddAsync(T model)
        {
            return await _repository.AddAsync(model);
        }

        public async Task<ActionResponse<T>> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ActionResponse<IEnumerable<T>>> GetAsync()
        {
            return await _repository.GetAsync();
        }

        public async Task<ActionResponse<T>> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<ActionResponse<T>> UpdateAsync(T model)
        {
            return await _repository.UpdateAsync(model);
        }
    }
}