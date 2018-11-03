using System;

namespace DesignPattern.Patterns.Structural.Facade.Ejemplo2
{
    public class Centralita
    {
        private IEmbrague _embrague;
        private IAcelerador _acelerador;
        private IPalancaCambios _palancaCambios;

        public Centralita(IEmbrague embrague, IAcelerador acelerador, IPalancaCambios palancaCambios)
        {
            this._embrague = embrague;
            this._acelerador = acelerador;
            this._palancaCambios = palancaCambios;
        }

        public void AumentarMarcha()
        {
            _acelerador.SoltarAcelerador();
            _embrague.PresionarEmbrague();
            _palancaCambios.PuntoMuerto();
            if (_palancaCambios.GetVelocidadActual() < 5)
                _palancaCambios.InsertarVelocidad(_palancaCambios.GetVelocidadActual() + 1);
            _embrague.SoltarEmbrague();
            _acelerador.PresionarAcelerador();
        }

        public void ReducirMarcha()
        {
            _acelerador.SoltarAcelerador();
            _embrague.PresionarEmbrague();
            _palancaCambios.PuntoMuerto();
            if (_palancaCambios.GetVelocidadActual() > 1)
                _palancaCambios.InsertarVelocidad(_palancaCambios.GetVelocidadActual() - 1);
            _embrague.SoltarEmbrague();
            _acelerador.PresionarAcelerador();
        }


    }

    public interface IPalancaCambios
    {
        int GetVelocidadActual();
        void InsertarVelocidad(int velocidad);
        void PuntoMuerto();
    }

    public interface IAcelerador
    {
        void PresionarAcelerador();
        void SoltarAcelerador();
    }

    public interface IEmbrague
    {
        void SoltarEmbrague();
        void PresionarEmbrague();
    }

    public class Embrague1 : IEmbrague
    {
        public void PresionarEmbrague()
        {
            Console.WriteLine("Embrague pisado");
        }

        public void SoltarEmbrague()
        {
            Console.WriteLine("Embrague suelto");
        }
    }

    public class Acelerador1 : IAcelerador
    {
        public void PresionarAcelerador()
        {
            Console.WriteLine("Acelerando");
        }

        public void SoltarAcelerador()
        {
            Console.WriteLine("Frenando");
        }
    }

    public class PalancaCambios1 : IPalancaCambios
    {
        private int velocidad;
        public int GetVelocidadActual()
        {
            return velocidad;
        }

        public void InsertarVelocidad(int velocidad)
        {
            Console.WriteLine($"Velocidad {velocidad}");
        }

        public void PuntoMuerto()
        {
            Console.WriteLine("En punto muerto");
        }
    }
}