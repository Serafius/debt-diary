using DebtDiary.Core;
using System.Data.Entity;

namespace DebtDiary.DataProvider
{
    public class DebtDiaryDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Debtor> Debtors { get; set; }
        public DbSet<Operation> Operations { get; set; }

        public DebtDiaryDbContext() : base("datasource=localhost;port=3306;username=root;password=;database=studentdb")
        { }
    }
}
