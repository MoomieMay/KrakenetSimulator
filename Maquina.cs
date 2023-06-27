using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrakenetSimulator
{    
    abstract class Maquina 
    {
        public int Id ;
        public int Ip ;

        public Maquina (int Idm, int Ipm){
            Id = Idm;
            Ip = Ipm;
        }

        public abstract void Enviar ();

        public abstract void Recibir (Paquete paq);
    }
}