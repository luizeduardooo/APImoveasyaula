using MinhaApiBonita.DTO;
using MinhaApiBonita.Entity;
using System.Collections.Generic;

namespace MinhaApiBonita.Contracts.Repository
{
    public interface IUserRepository
    {
        Task Add(UserDTO user);
        Task Update(UserEntity user);
        Task Delete(int id);
        Task<UserEntity> GetById(int id);
        Task<IEnumerable<UserEntity>> Get();
    }
}
