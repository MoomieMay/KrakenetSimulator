using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrakenetSimulator
{
    class Router : Maquina
    {
        List<Terminal> _terminales;
        List<Router> _routers;
        int [] _anchodebanda;
        List<Paquete> _paquetes;

        // Paquetito [] _paquetitos
        Administrador _administrador;
        public Router(int Idm, int Ipm, Administrador admin) : base(Idm, Ipm)
        {
           _terminales = new List<Terminal>();
           _routers = new List<Router>();
           _anchodebanda = new int[0];
           _administrador =  admin;
           _paquetes = new List<Paquete>();
           //_paquetitos = new Paquetito[0];
        }

        public override void Enviar()
        {
            throw new NotImplementedException();
        }

        public override void Recibir(Paquete paq)
        {
            _paquetes.Add(paq);
        }

        public void dividir(){
            throw new NotImplementedException();
        }

        public void armar(){
            throw new NotImplementedException();
        }

        public void reenviar (){
            throw new NotImplementedException();
        }

        public void agregarRouter(Router nrouter, int ab){
            _routers.Add(nrouter);
            _anchodebanda[_routers.IndexOf(nrouter)] = ab;
        }

        public void agregarTerminal(Terminal nterminal){
            _terminales.Add(nterminal);
        }
        // REVISAR
        public void eliminarRouter(Router router){
            _anchodebanda[_routers.IndexOf(router)] = -1;
            _routers.Remove(router);
        }

        public void eliminarTerminal(Terminal terminal){
            _terminales.Remove(terminal);
        }

        public void modificarAnchodebanda(){
            throw new NotImplementedException();
        }
    }
}