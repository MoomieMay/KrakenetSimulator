using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrakenetSimulator
{
    //RECORDATORIO: ELIMINAR TODAS LAS LINEAS COMENTADAS AL FINAL
    class Router : Maquina
    {
        List<Terminal> _terminales;
        List<Router> _routers;
        List<int> _anchodebanda;
        //int [] _anchodebanda;
        Queue<Paquete> _paquetes;

        // Queue<Paquetito> _paquetitos
        Administrador _administrador;
        public Router(int Idm, int Ipm, Administrador admin) : base(Idm, Ipm)
        {
           _terminales = new List<Terminal>();
           _routers = new List<Router>();
           _anchodebanda = new List<int>();
           //_anchodebanda = new int[10];
           _administrador =  admin;
           _paquetes = new Queue<Paquete>();
           //_paquetitos = new Queue<Paquetito>();
        }

        public override void Enviar()
        {
            throw new NotImplementedException();
        }

        public override void Recibir(Paquete paq)
        {
            _paquetes.Enqueue(paq);
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
            _anchodebanda.Add(ab);
            //_anchodebanda[_routers.IndexOf(nrouter)] = ab;
        }

        public void agregarTerminal(Terminal nterminal){
            _terminales.Add(nterminal);
        }
        // REVISAR
        public void eliminarRouter(Router router){
            //_anchodebanda[_routers.IndexOf(router)] = -1;
            int i = _routers.IndexOf(router);
            _routers.Remove(router);
            _anchodebanda.RemoveAt(i);
        }

        public void eliminarTerminal(Terminal terminal){
            _terminales.Remove(terminal);
        }

        public void modificarAnchodebanda(){
            throw new NotImplementedException();
        }
        // METODOS DE PRUEBAS (No Finales)
        public void verRouters(){
            foreach(var obj in _routers)
            {
                Console.WriteLine($" el Id del router es: {obj.Id}");
                Console.WriteLine($"el indice es: {_routers.IndexOf(obj)}");
            }
            foreach(int obj in _anchodebanda)
            {
                Console.WriteLine($"el ancho de banda del router es {obj}");
                Console.WriteLine($"el indice es: {_anchodebanda.IndexOf(obj)}");
            } 
        }
    }
}