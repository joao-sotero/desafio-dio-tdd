using System.Collections.Generic;
using System.Linq;

namespace NewTalents
{
    public  class Calculadora
    {
        private List<string> Historico;
        private string _data;

        public Calculadora(string data)
        {
            Historico = new List<string>();
            _data = data;
        }

        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;
            AddHistorico(res);
            return res;
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            AddHistorico(res);
            return res;
        }

        public int Multipicar(int val1, int val2)
        {
            int res = val1 * val2;
            AddHistorico(res);
            return res;
        }

        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;
            AddHistorico(res);
            return res;
        }

        public List<string> PegarHistorico()
        {
            return Historico.Skip(0).Take(3).ToList();
        }

        private void AddHistorico(int res)
        {
            Historico.Insert(0, $"Res di {res} - data: {_data}");
        }
    }
}
