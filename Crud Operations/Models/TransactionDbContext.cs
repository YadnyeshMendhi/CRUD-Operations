using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace Crud_Operations.Models
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> Options) : base(Options)
        {}

        public DbSet<Transaction> Transactions { get; set; }
    }
}
