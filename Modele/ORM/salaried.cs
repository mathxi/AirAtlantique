using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirAtlantique.Modele.ORM
{
    class salaried
    {

        private int idsalaried;
        private string name;
        private string firstName;
        private int registrationNumber;
        private bool availibility;
        private string dateBirth;
        private string dateHiring;

        public string DateHiring
        {
            get { return dateHiring; }
            set { dateHiring = value; }
        }


        public string DateBirth
        {
            get { return dateBirth; }
            set { dateBirth = value; }
        }


        public bool Availibility
        {
            get { return availibility; }
            set { availibility = value; }
        }


        public int RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int IdSalaried
        {
            get { return idsalaried; }
            set { idsalaried = value; }
        }
    }
}
