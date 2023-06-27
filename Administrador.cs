using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrakenetSimulator
{
    class Administrador : Maquina
    {

        List<Router> _routers;
        public Administrador(int Idm, int Ipm) : base(Idm, Ipm)
        {
            _routers = new List<Router>();
        }

        public override void Enviar()
        {
            throw new NotImplementedException();
        }

        public override void Recibir(Paquete paq)
        {
            throw new NotImplementedException();
        }

        public void agregarRouter(){
            throw new NotImplementedException();
        }

        public void eliminarRouter(){
            throw new NotImplementedException();
        }

        public void Dijkstra(){
            throw new NotImplementedException();
        }
    }
}