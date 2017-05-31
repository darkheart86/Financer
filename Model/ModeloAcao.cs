using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class ModeloAcao
    {
        private int _codigoAcao;
        private string _nomeEmpresa;
        private bool _inativo;
        

        public ModeloAcao()
        {
            this._codigoAcao = 0;
            this._nomeEmpresa = null;
            this._inativo = false;

        }
        public ModeloAcao(int CodigoAcao, string NomeEmpresa)
        {
            this.CodigoAcao = CodigoAcao;
            this.NomeEmpresa = NomeEmpresa;
            this.Inativo = false;
        }
        public ModeloAcao(int CodigoAcao, string NomeEmpresa, bool Inativo)
        {
            this.CodigoAcao = CodigoAcao;
            this.NomeEmpresa = NomeEmpresa;
            this.Inativo = Inativo;
        }
        public void Clear()
        {
            
            this.CodigoAcao = 0;
            this.NomeEmpresa = null;
            this.Inativo = false;
        }

        public int CodigoAcao
        {
            get { return this._codigoAcao; }
            set { _codigoAcao = value; }
        }
        public string NomeEmpresa
        {
            get { return this._nomeEmpresa; }
            set { this._nomeEmpresa = value; }
        }
        public bool Inativo
        {
            get { return this._inativo; }
            set { this._inativo = value; }
        }

    }
}
