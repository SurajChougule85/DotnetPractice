using Microsoft.EntityFrameWork;
using PMS;

public class ToDoDb:DbContext{
    public ToDoDb(DbContextOption<ToDoDb>option):
    base(option){}

    public DbSet<Todo> todos => System<Todo>();
}