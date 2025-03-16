// Services/MemberService.cs
using testapi.Entities;
using testapi.Repositories;
using System.Threading.Tasks;

namespace testapi.Services
{
    public class MemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public async Task<Member> GetByIdAsync(int id)
        {
            return await _memberRepository.GetByIdAsync(id);
        }

        public async Task<Member> CreateAsync(Member member)
        {
            return await _memberRepository.AddAsync(member);
        }

        public async Task<Member> UpdateAsync(Member member)
        {
            return await _memberRepository.UpdateAsync(member);
        }

        public async Task DeleteAsync(int id)
        {
            await _memberRepository.DeleteAsync(id);
        }
    }
}
