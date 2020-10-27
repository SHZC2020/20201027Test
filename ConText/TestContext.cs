using helloworldAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace helloworldAPI.ConText
{
    public class TestContext:DbContext
    {
        public TestContext(DbContextOptions<TestContext> options):base(options)
        {


        }
        public DbSet<Student> Student{get;set;}
    }
}