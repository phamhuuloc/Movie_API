using MOVIE_API.Model;
using MOVIE_API.Services;
namespace MOVIE_API.Container {
    public class CustomerServices: ICustomerServices {
        private readonly MysqlDBContext _context;

        public CustomerServices(MysqlDBContext context){
            this._context = context;
        }
    public   List<User> getAllCustomer(){
                return this._context.Users.ToList();
    }
    }
}