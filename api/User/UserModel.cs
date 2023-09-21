namespace MOVIE_API.Model{
    public class User{
        public int id {get;set;}
        public string username  {get;set;}
        public string email {get;set;} 
        public string password {get;set;}
        public string profilePic {get;set;}
        public double wallet_balance {get;set;}
        public double point  {get;set;} 
        public double  money_spended {set;get;}  
        public string phone  {set;get;}
        public Boolean isAdmin {set;get;}
        public string face_id {set;get;}

    }
}