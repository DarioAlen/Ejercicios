using System;
using System.Collections.Generic;
using System.Text;

namespace Indumentaria.Entidades
{
    public class TiendaRopa
    {
        private List<Persona> _personas; //que alguien lo maneje según sea clienteempresa o clientepersona, luego realizará casteo.
        private List<Prenda> _prendas;
        private string _nombreTienda;
        private string _direccion;
        private List<Orden> _ordenes;
        private List<TipoIndumentaria> _tipoIndumentarias;

        private int _autoincrementar;
        private int _numeroAutoIncrementalTipoIndumentaria;
        private int _numeroAutoIncrementalPrenda;
        private int _numeroAutoIncrementalOrden;
        public TiendaRopa(string nombreTienda, string direccion)
        {
            _nombreTienda = nombreTienda;
            _direccion = direccion;
            _personas = new List<Persona>();
            _prendas = new List<Prenda>();
        }

        public string NombreTienda
        {
            get { return _nombreTienda; }
        }

        public string Direccion
        {
            get { return _direccion; }
        }

        public void AgregarPersona(Persona p)
        {
            _personas.Add(p);
        }
        //Prenda, orden y marcaropa lo maneja con autoincremental esta clase,
        //public void AgregarPrenda(Prenda p)
        //{
        //    p.CodigoPrenda = AutoIncrementar();
        //    _prendas.Add(p);
        //}

        //public void AgregarOrden(Orden o)
        //{
        //    o.CodigoOrden = AutoIncrementar();
        //    _ordenes.Add(o);
        //}

        //public void AgregarTipoIndumentaria(TipoIndumentaria tp)
        //{
        //    tp.CodigoTipoIndumentaria = AutoIncrementar();
        //    _tipoIndumentarias.Add(tp);

        //}
        public void AgregarPrenda(Prenda p)
        {
            p.CodigoPrenda = AutoIncrementarSegunObjeto(p);
            _prendas.Add(p);
        }

        public void AgregarOrden(Orden o)
        {
            o.CodigoOrden = AutoIncrementarSegunObjeto(o);
            _ordenes.Add(o);
        }

        public void AgregarTipoIndumentaria(TipoIndumentaria tp)
        {
            tp.CodigoTipoIndumentaria = AutoIncrementarSegunObjeto(tp);
            _tipoIndumentarias.Add(tp);

        }

        public void ModificarOrden(int codigo)
        {

        }

        public int AutoIncrementar()
        {
            return _autoincrementar++;
        }

        //private int AutoIncrementarV2(object a)
        //{
        //    if (a is Orden)
        //    {
        //        return _numeroAutoIncrementalOrden++;
        //    }
        //    else
        //    {
        //        if (a is TipoIndumentaria)
        //        {
        //            return _numeroAutoIncrementalTipoIndumentaria++;
        //        }

        //        else
        //        {
        //            return _numeroAutoIncrementalPrenda++;
        //        }
        //    }
        //}


        private int AutoIncrementarSegunObjeto(object a)
        {
            if (a is Orden)
            {
                return _numeroAutoIncrementalOrden++;
            }
            else if (a is TipoIndumentaria)
            {

                return _numeroAutoIncrementalTipoIndumentaria++;
            }

            else
            {
                return _numeroAutoIncrementalPrenda++;
            }
          
        }
        //private TipoIndumentaria AutoIncrementarV2(object a)
        //{

        //    TipoIndumentaria tp;
        //    TipoIndumentaria or;
        //    if (a is TipoIndumentaria)
        //    {
        //        tp = (TipoIndumentaria)a; //castear..
        //        return tp;
        //    }
        //    else
        //    {
        //        or = (TipoIndumentaria)a;
        //        return or;
        //    }
        //}
        //public int AutoIncrementarObj(object a)
        //{
        //    int TipoInd = 0;
        //    int Orden = 0;
        //    int Prenda = 0;

        //    if (a is TipoIndumentaria)
        //    {
        //        return TipoInd++;
        //    }
        //    else
        //    {
        //        if (a is Orden)
        //        {

        //            return Orden++;

        //        }

        //    }





        //Verlo. No es tan claro..
        //public int AutoIncrementarSegunObjeto(object a)
        //{

        //    _numeroAutoIncremental++;
        //    TipoIndumentaria tp;
        //    Orden or;
        //    Prenda p;
        //    if (a is TipoIndumentaria)
        //    {
        //        tp = (TipoIndumentaria)a;
        //        tp.CodigoTipoIndumentaria = AutoIncrementar();

        //    }
        //    else if (a is Orden)
        //    {
        //        or = (Orden)a;

        //    }

        //}

        //public void Eliminar(int codigo)
        //{

        //}


    }
}
