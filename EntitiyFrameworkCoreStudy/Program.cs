// See https://aka.ms/new-console-template for more information
using EntitiyFrameworkCoreStudy.Data;
using EntitiyFrameworkCoreStudy.Entites;
using Microsoft.EntityFrameworkCore;


namespace EntitiyFrameworkCoreStudy
{
    class program
    {
        static void Main(String[] args)
        {
            using (var db = new EfStudyDbContext())
            {
                // 1. SELECT 쿼리
                // 1) DbSet<User> selectList = db.Users;
                // 2) List<User> selectList = db.Users.ToList().Where().OrderBy();
                // 3) IEnumerable<User> selectList = db.Users.AsEnumerable();
                // 4) IQueryable<User> selectList = from user in db.User select user;

                // # IEnumerable vs IQueryable
                // Extension Query => 작성이 가능
                // 1. IEnumerable => 쿼리 => 데이터(10명) => Client => Slow
                // 2. IQueryable => 쿼리 => 데이터(10명) => Server => Fast

                // 2. INSERT 쿼리
                // db.Users.Add(User);
                // db.SaveChanges();

                // 3. UPDATE 쿼리
                //var user = new User { UserId = 1, UserName = "장길동" };
                //db.Entry(user).State = EntityState.Modified;
                //db.SaveChanges();

                // 4. DELETE 쿼리
                // DELETE FROM User WHERE UserId = 2;
                //var user = new User { UserId = 2 };
                //db.Users.Remove(user);
                //db.SaveChanges();
            }
        }

    }

}
