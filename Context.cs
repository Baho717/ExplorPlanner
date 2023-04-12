using ExplorPlanner.Models;
using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
   public Context() : base(){}
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sqlite database
        options.UseSqlite(@"Data Source=test.db");
    }
   
   public DbSet<Schedule>? Schedule {get;set;}
   public DbSet<Category>? Categories {get;set;}
   public DbSet<Event>? Events {get;set;}
   public DbSet<User>? Users {get;set;}

}