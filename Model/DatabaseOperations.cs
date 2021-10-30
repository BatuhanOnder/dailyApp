using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily.Model
{
    class DatabaseOperations
    {
        DailyApplicationEntities db = new DailyApplicationEntities();

        public DatabaseOperations()
        {
            
        }

        public bool login(string username, string password) {
            v_login user = db.v_login.Where(w => w.username == username && w.password == password).FirstOrDefault();
            if (user != null)
            {
                return true;
            }
            return false;
        }



    }
}
