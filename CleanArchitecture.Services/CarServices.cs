using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;

namespace CleanArchitecture.Services
{
    public class CarServices : ICarServices
    {
        private readonly IRepository<Cars> _repository;
        public CarServices(IRepository<Cars> repository)
        {
            _repository = repository;
        }

        public async ValueTask<Cars> Create(Cars car)
        {
            return await _repository.AddAsync(car);
        }
    }
}
