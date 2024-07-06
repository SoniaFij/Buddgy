using Microsoft.EntityFrameworkCore;

namespace BudgetTracker.Models
{
    public class BudgetTrackerDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public BudgetTrackerDbContext(DbContextOptions<BudgetTrackerDbContext> options)
            : base(options)
        {
            

        }
    }
}
