﻿using System;
using System.Linq;
using System.Threading.Tasks;
using EWork.Data.Interfaces;
using EWork.Models;
using EWork.Services.Interfaces;

namespace EWork.Services
{
    public class JobManager : IJobManager
    {
        private readonly IRepository<Job> _repository;

        public JobManager(IRepository<Job> repository) => _repository = repository;

        public Task AddAsync(Job item) => _repository.AddAsync(item);

        public Task DeleteAsync(Job item) => _repository.DeleteAsync(item);

        public Task<Job> FindAsync(Predicate<Job> predicate) => _repository.FindAsync(predicate);

        public IQueryable<Job> GetAll() => _repository.GetAll();

        public Task UpdateAsync(Job item) => _repository.UpdateAsync(item);
    }
}