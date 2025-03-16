// Controllers/MemberController.cs
using Microsoft.AspNetCore.Mvc;
using testapi.Entities;
using testapi.Services;

namespace testapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly MemberService _memberService;

        public MemberController(MemberService memberService)
        {
            _memberService = memberService;
        }

        /// <summary>
        /// Get a member by ID.
        /// </summary>
        /// <param name="id">The ID of the member</param>
        /// <returns>A member object</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Member>> GetById(int id)
        {
            var member = await _memberService.GetByIdAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            return Ok(member);
        }

        /// <summary>
        /// Create a new member.
        /// </summary>
        /// <param name="member">The member to create</param>
        /// <returns>The created member object</returns>
        [HttpPost]
        public async Task<ActionResult<Member>> Create(Member member)
        {
            var createdMember = await _memberService.CreateAsync(member);
            return CreatedAtAction(nameof(GetById), new { id = createdMember.Id }, createdMember);
        }

        /// <summary>
        /// Update an existing member.
        /// </summary>
        /// <param name="id">The ID of the member to update</param>
        /// <param name="member">The updated member object</param>
        /// <returns>The updated member object</returns>
        [HttpPut("{id}")]
        public async Task<ActionResult<Member>> Update(int id, Member member)
        {
            if (id != member.Id)
            {
                return BadRequest();
            }

            var updatedMember = await _memberService.UpdateAsync(member);
            if (updatedMember == null)
            {
                return NotFound();
            }
            return Ok(updatedMember);
        }

        /// <summary>
        /// Delete a member by ID.
        /// </summary>
        /// <param name="id">The ID of the member to delete</param>
        /// <returns>Empty result</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _memberService.DeleteAsync(id);
            return NoContent();
        }
    }
}
