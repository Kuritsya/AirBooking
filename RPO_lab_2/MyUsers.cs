using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RPO_lab_2
{
    public class MyUsers
    {
        public MyUsers() { }
        public MyUsers(int id_user, string FIO_user, DateTime birthday_user, int seria_pasport, int number_pasport,
                     string email, string login, string password)
        {
            id_user = idUser;
            FIO_user = FIOUser;
            birthday_user = birthdayUser;
            seria_pasport = seriaPasport;
            number_pasport = numberPasport;
            email = emailUser;
            login = loginUser;
            password = passwordUser;
        }

        [Key]
        public int idUser { get; set; }
        public string FIOUser { get; set; }
        public DateTime birthdayUser { get; set; }
        public int seriaPasport { get; set; }
        public int numberPasport { get; set; }
        public string emailUser { get; set; }
        public string loginUser { get; set; }
        public string passwordUser { get; set; }
    }
}
