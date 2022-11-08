using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) : base(options)
        {

        }
       

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}