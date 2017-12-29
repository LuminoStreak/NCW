using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreDal;

namespace CoreWebTest
{
    [TestClass]
    public class DalUnitTest: BaseTest
    {
        [TestMethod]
        public void Insert()
        {
            using(var repository = new Repository<User>(base.Context))
            {
                var userData = new User{
                    FirstName = "user",
                    LastName = "01",
                    Email = "test@test.com"
                };
                repository.Insert(userData);
            }
        }

        [TestMethod]
        public void InsertWithChild()
        {
            using(var repository = new Repository<User>(base.Context))
            {
                var userData = new User{
                    FirstName = "user",
                    LastName = "04",
                    Email = "test@test.com",
                    UserDepartment = new UserDepartment()
                    {
                        DeptNo = 1,
                        DeptName = "Dept01",
                        Location = "LOC01",
                        Capacity = 10                        
                    }
                };
                repository.Insert(userData);
            }
        }

        [TestMethod]
        public void Update()
        {
            using(var repository = new Repository<User>(base.Context))
            {
                var user = repository.Get(2);
                user.LastName = "02";                
                repository.Update(user);
            }
        }

                [TestMethod]
        public void UpdateAddChild()
        {
            var userDepartment = new UserDepartment()
                                {
                                    DeptNo = 1,
                                    DeptName = "Dept02",
                                    Location = "LOC01",
                                    Capacity = 10                        
                                };

            using(var repository = new Repository<User>(base.Context))
            {
                var user = repository.Get(2);
                user.LastName = "02";                
                user.UserDepartment = userDepartment;
                repository.Update(user);
            }
        }

         [TestMethod]
        public void Delete()
        {
            using(var repository = new Repository<User>(base.Context))
            {
                var user = repository.Get(4);
                               
                repository.Delete(user);
            }
        }


    }
}
