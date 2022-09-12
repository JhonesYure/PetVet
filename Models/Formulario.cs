using System;
using System.Collections.Generic;
using ATV03_JhonesYure;

namespace ATV03_JhonesYure
{
    public class Formulario
    {
        private List<Listagem> list;

        public void AddLista(Listagem item)
        {
            list.Add(item);
        }
        public Formulario()
        {
            list = new List<Listagem>();
        }

        public List<Listagem> liste()
        {
            return list;
        }
        public int listarAgendamento()
        {
            return list.Count;
        }
       
    }
}