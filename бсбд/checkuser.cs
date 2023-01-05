using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace бсбд
{
    public class checkuser
    {
        public string login { get; set; }

        public string user_status { get; }

        public int id_user { get; }

        public checkuser(string login, string user_status, int id_user)
        {
            this.login = login;
            this.user_status = user_status;
            this.id_user = id_user;
        }
        
    }
}
