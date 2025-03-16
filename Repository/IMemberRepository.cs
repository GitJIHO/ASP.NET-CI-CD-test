// Repositories/IMemberRepository.cs
using testapi.Entities;
using System.Threading.Tasks;

namespace testapi.Repositories
{
    public interface IMemberRepository
    {
        Task<Member> GetByIdAsync(int id);
        Task<Member> AddAsync(Member member);
        Task<Member> UpdateAsync(Member member);
        Task DeleteAsync(int id);
    }
}
