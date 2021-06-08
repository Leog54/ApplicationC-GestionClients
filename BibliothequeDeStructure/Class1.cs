using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothequeDeStructure
{
    public class Client
    {
        private string id;
        private string email;
        private string Nom;
        private string prenom;
        private string psw;
        private string telephone;
        private string numRue;
        private string nomRue;
        private string ville;
        private string codePostal;
        private string Statut;



        public string getID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string getEmail
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string getNom
        {
            get
            {
                return Nom;
            }
            set
            {
                Nom = value;
            }
        }

        public string getPrenom
        {
            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
            }
        }

        public string getPsw
        {
            get
            {
                return psw;
            }
            set
            {
                psw = value;
            }
        }

        public string getTel
        {
            get
            {
                return telephone;
            }
            set
            {
                telephone = value;
            }
        }

        public string getNumRue
        {
            get
            {
                return numRue;
            }
            set
            {
                numRue = value;
            }
        }

        public string getNomRue
        {
            get
            {
                return nomRue;
            }
            set
            {
                nomRue = value;
            }
        }

        public string getVille
        {
            get
            {
                return ville;
            }
            set
            {
                ville = value;
            }
        }

        public string getCP
        {
            get
            {
                return codePostal;
            }
            set
            {
                codePostal = value;
            }
        }

        public string getStatut
        {
            get
            {
                return Statut;
            }
            set
            {
                Statut = value;
            }
        }


    }
}
