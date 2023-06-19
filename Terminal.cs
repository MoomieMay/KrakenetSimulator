using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrakenetSimulator
{
    class Terminal : Maquina
    {
        Router _router;
        //Paquete [] _paquete;
        public Terminal(int Idm, int Ipm, Router router) : base(Idm, Ipm)
        {
            _router = router;
            //Paquete _paquete = new Paquete[Paquete];
        }

        public override void Enviar()
        {
            throw new NotImplementedException();
        }

        public override void Recibir()
        {
            throw new NotImplementedException();
        }
    }
}