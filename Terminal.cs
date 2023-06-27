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
        List<Paquete> _paquete;


        public Terminal(int Idm, int Ipm, Router router) : base(Idm, Ipm)
        {
            _router = router;
            _paquete = new List<Paquete>();
        }

        public override void Enviar()
        {
            _router.Recibir(_paquete[0]);
            _paquete.RemoveAt(0);
        }

        public override void Recibir(Paquete paq)
        {
            Console.WriteLine("el paquete {0} fue recibido", paq);
        }

        // Crea el paquete que sera enviado por la red (agregar los parametros del paquete)
        public void CrearPaquete ()
        {
            Paquete paq = new Paquete();
            _paquete.Add(paq);

        }
    }
}