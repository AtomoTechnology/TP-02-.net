using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private string _nombreUsuario;
        private string _nombre;
        private string _clave;
        private string _apellido;
        private string _email;
        private bool _habilitado;
        //private int _idPersona;
        private int _tipopersona;

        public int TipoPersona
        {
            get { return _tipopersona; }
            set { _tipopersona = value; }
        }




        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }


        public string  Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

     

        public string  Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
       

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
     

        public string  Email
        {
            get { return _email; }
            set { _email = value; }
        }
 

        public bool Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }



    }
}
