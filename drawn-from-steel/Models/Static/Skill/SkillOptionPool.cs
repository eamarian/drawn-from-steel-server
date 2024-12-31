using Microsoft.EntityFrameworkCore;

namespace DrawnFromSteel.Models.Static.Skill
{
    public class SkillOptionPool
    {
        public int SkillOptionId { get; set; }
        public int SkillPoolId { get; set; }
        public int Count { get; set; } = 1;
    }
}
