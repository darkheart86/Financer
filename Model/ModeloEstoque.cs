using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
     public class ModeloEstoque
    {
        #region Atributos   
        int _idEstoque;
        int _idAcao;
        int _quantidade;
        float _valorAcumulado;
        float _valorMedio;
        bool _inativo;
        #endregion  

        #region Propriedades
        public int IdEstoque
        {
            get
            {
                return _idEstoque;
            }

            set
            {
                _idEstoque = value;
            }
        }
        public int IdAcao
        {
            get
            {
                return _idAcao;
            }

            set
            {
                _idAcao = value;
            }
        }
        public int Quantidade
        {
            get
            {
                return _quantidade;
            }

            set
            {
                _quantidade = value;
            }
        }
        public float ValorAcumulado
        {
            get
            {
                return _valorAcumulado;
            }

            set
            {
                _valorAcumulado = value;
            }
        }
        public float ValorMedio
        {
            get
            {
                return _valorMedio;
            }

            set
            {
                _valorMedio = value;
            }
        }
        public bool Inativo
        {
            get
            {
                return _inativo;
            }

            set
            {
                _inativo = value;
            }
        }
        #endregion

        #region Metodos
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
        #endregion
    }
}
