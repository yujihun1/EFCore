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
                #region + sql 예시
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
                #endregion


                #region + Linq의 분류(2가지)
                // # Linq 분류(2가지)
                // 1. 쿼리 구문
                // from user in users
                // where ....
                // select new;

                // 2. 메서드 구문
                // db.Users.Where().ToList(); 
                #endregion


                // .Where(), OrderBy()
                // 1. .Where()
                // SELECT * FROM Users WHERE UserId = 1;

                //var list = db.Users.ToList();
                //var list = db.Users.Where(u => u.UserName == "임길동");

                //foreach (var user in list)
                //{
                //    Console.WriteLine(
                //        $"{user.UserId}.{user.UserName}({user.Birth})");
                //}

                // 게시물 1개 수정 -> 데이터 가져옴
                // 특정 데이터 1개 가져오기
                // .First(), .FirstOrDefault(), .Single(), .SingleOrDefault()
                //var user = db.Users.First();
                //Select Top 1 * From Users

                //var user = db.Users.Single(u => u.UserId == 1);
                // SELECT TOP 1 * FROM Users WHERE USERNAME = "임길동";

                // SingleOrDefault() vs FirstOrDefault()   
                // SingleOrDefault() 권장

                // # OrderBy()
                // 1,2,3,4,5,6

                // # OrderByDescending()
                // 6,5,4,3,2,1

                var list = db.Users.OrderByDescending(u => u.Birth).ToList();

                foreach (var user in list)
                {
                    Console.WriteLine(
                        $"{user.UserId}.{user.UserName}({user.Birth})");
                }

            }
        }

    }

}
