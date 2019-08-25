using Microsoft.EntityFrameworkCore;
using SocialApp.API.Models;

namespace SocialApp.API.Data
{
    //Entity FrameworkCode First
    //Model Creation
    //DBContext inherit
    //DBSet Same like table in DB
    //Add Connection String in AppSetting.json file
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> option):base(option)
        {
        }
        public DbSet<Employee> Employees{get;set;}
        public DbSet<User> Users{get;set;}
    }
}