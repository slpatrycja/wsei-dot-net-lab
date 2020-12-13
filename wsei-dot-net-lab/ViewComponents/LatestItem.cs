using System.Linq;
using Microsoft.AspNetCore.Mvc;
using wsei_dot_net_lab.Database;

namespace wsei_dot_net_lab.ViewComponents
{
    public class LatestItem : ViewComponent
    {
        private readonly ExchangesDbContext _dbContext;
        public LatestItem(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IViewComponentResult Invoke()
        {
            var latestItem = _dbContext.Items
                .OrderByDescending(x => x.Id).First();
            return View("Index", latestItem);
        }
    }
}