using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI1.Entities;
using WebAPI1.Models;

namespace WebAPI1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    
    public class EnterpriseController : ControllerBase
    {
        private readonly isha_sys_devContext _db;
        
        public EnterpriseController(isha_sys_devContext db)
        {
            _db = db;
        }
        public class TreeNode
        {
            public string Id { get; set; }       // 節點的 ID
            public string Name { get; set; }     // 節點的名稱
            public List<TreeNode> Children { get; set; }  // 子節點集合
        }
        
        [HttpGet("GetEnterprise")]
        public IActionResult GetEnterprise()
        {
           
            // 預先載入企業、公司及工廠的關聯資料
            var enterprises = _db.EnterpriseNames
                .Include(e => e.CompanyNames)
                .ThenInclude(c => c.FactoryNames)
                .ToList();

            // 建立樹狀結構
            var enterprise_name = enterprises.Select(e => new TreeNode
            {
                Id = e.Id.ToString(),
                Name = e.enterprise,
                Children = e.CompanyNames.Select(c => new TreeNode
                {
                    Id = c.Id.ToString(),
                    Name = c.company,
                    Children = c.FactoryNames.Select(f => new TreeNode
                    {
                        Id = f.Id.ToString(),
                        Name = f.factory,
                        Children = new List<TreeNode>() // 工廠沒有子節點
                    }).ToList()
                }).ToList()
            }).ToList();

            return Ok(enterprise_name);
        }
    }
    
}
