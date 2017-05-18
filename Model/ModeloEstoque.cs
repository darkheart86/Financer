using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
     public class ModeloEstoque
    {
        int _idEstoque;
        int _idAcao;
        int _quantidade;
        float _valorAcumulado;
        float _valorMedio;
        bool _inativo;

        public int IdEstoque { get => _idEstoque; set => _idEstoque = value; }
        public int IdAcao { get => _idAcao; set => _idAcao = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public float ValorAcumulado { get => _valorAcumulado; set => _valorAcumulado = value; }
        public float ValorMedio
        {
            get
            {
                if (_quantidade != 0)
                {
                    return _valorAcumulado  / _quantidade;
                }
                else
                {
                    return _valorAcumulado;
                }

            }
            private set
            {
                _valorMedio = value;
            }
        }
        public bool Inativo { get => _inativo; set => _inativo = value; }
     

        public ModeloEstoque()
        {
            this.IdAcao = 0;
            this.Quantidade = 0;
            this.ValorAcumulado = 0;
            this.ValorMedio = 0;
        }
        public ModeloEstoque(int idAcao, int quantidade, float valorAcumulado)
        {
            this.IdAcao = idAcao;
            this.Quantidade = quantidade;
            this.ValorAcumulado = valorAcumulado;
        }
        public void Clear()
        {
            this.IdAcao = 0;
            this.Quantidade = 0;
            this.ValorAcumulado = 0;
            this.ValorMedio = 0;
        }
    }
}
