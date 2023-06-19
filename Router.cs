using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrakenetSimulator
{
    class Router : Maquina
    {
        Terminal [] _terminales;
        Router [] _routers;
        int [] _anchodebanda;

        // Paquetito [] _paquetitos
        Administrador _administrador;
        public Router(int Idm, int Ipm, Administrador admin) : base(Idm, Ipm)
        {
           _terminales = new Terminal[0];
           _routers = new Router[0];
           _anchodebanda = new int[0];
           _administrador =  admin;
           //_paquetitos = new Paquetito[0];
        }

        public override void Enviar()
        {
            throw new NotImplementedException();
        }

        public override void Recibir()
        {
            throw new NotImplementedException();
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

        public void agregarRouter(){
            throw new NotImplementedException();
        }

        public void agregarTerminal(){
            throw new NotImplementedException();
        }
        
        public void eliminarRouter(){
            throw new NotImplementedException();
        }

        public void eliminarTerminal(){
            throw new NotImplementedException();
        }

        public void modificarAnchodebanda(){
            throw new NotImplementedException();
        }
    }
}