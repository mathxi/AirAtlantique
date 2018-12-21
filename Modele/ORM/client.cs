using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.ORM
{
    class client
    {
        private int id;
        private string name;
        private string surname;
        private string mail;
        private string password;
        private string adress;
        private int postalCode;
        private string city;
        private int phone;

        public client(int thisid, string thisname, string thissurname, string thismail, string thispassword, string thisadress, int thispostalcode, string thiscity, int thisphone)
        {
            Id = thisid;
            Name = thisname;
            Surname = thissurname;
            Mail = thismail;
            Password = thispassword;
            Adress = thisadress;
            PostalCode = thispostalcode;
            City = thiscity;
            Phone = thisphone;
        }





        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }



        public string City
        {
            get { return city; }
            set { city = value; }
        }




        public int PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }



        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }




        public string Password
        {
            get { return password; }
            set { password = value; }
        }






        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }






        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }





        public string Name
        {
            get { return name; }
            set { name = value; }
        }





        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        public static Modele.ORM.client TryConnection(string coMail, string CoPassword)
        {
            return Modele.DAL.Request.ClientRequest.TryConnection(coMail, CoPassword);
        }



    }
}
