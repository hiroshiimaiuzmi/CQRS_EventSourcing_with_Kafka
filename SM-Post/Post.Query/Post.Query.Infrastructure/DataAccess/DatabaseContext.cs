using Microsoft.EntityFrameworkCore;
using Post.Query.Domain.Entities;

namespace Post.Query.Infrastructure.DataAccess;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions options) : base(options){}

    public DbSet<PostEntity> Posts => Set<PostEntity>();
    public DbSet<CommentEntity> Comments => Set<CommentEntity>();
}