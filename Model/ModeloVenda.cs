using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ModeloVenda
    {
        #region Atributos
        int _codigoVenda;
        int _codigoAcao;
        float _valorVendaBruta;
        float _valorVendaLiquida;
        float _lucroBruto;
        float _lucroLiquido;
        float _porcentagemIR;
        float _irCalculado;
        string _data;
        int _quantidade;
        bool _inativo;
        #endregion

        #region Propriedades
        public int CodigoVenda
        {
            get
            {
                return _codigoVenda;
            }

            set
            {
                _codigoVenda = value;
            }
        }
        public int CodigoAcao
        {
            get
            {
                return _codigoAcao;
            }

            set
            {
                _codigoAcao = value;
            }
        }
        public float ValorVendaBruta
        {
            get
            {
                return _valorVendaBruta;
            }

            set
            {
                _valorVendaBruta = value;
            }
        }
        public virtual float ValorVendaLiquida //*
        {
            get
            {
                return ValorVendaBruta - IRCalculado;
            }

            //set
            //{
            //    _valorVendaLiquida = value;
            //}
        }  
        public float LucroBruto //* 
        {
            get
            {
                return _lucroBruto;
            }

            set
            {
                _lucroBruto = value;
            }
        }
        public virtual float LucroLiquido
        {
            //Seria ValorVendaLiquida - ValorMedio de estoque
            get
            {
                return _lucroLiquido;
            }

            set
            {
                _lucroLiquido = value;
            }
        }
        public float PorcentagemIR
        {
            get
            {
                return _porcentagemIR;
            }

            set
            {
                _porcentagemIR = value;
            }
        }
        public float IRCalculado//Campo calculado
        {
            get
            {
                return ValorVendaBruta * (PorcentagemIR / 100);
            }

            //set
            //{
            //    _irCalculado = value;
            //}
        }
        public string Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
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
        public void Clear()
        {
            this.CodigoVenda = 0;
            this.CodigoAcao = 0;
            this.ValorVendaBruta = 0;
            //this.ValorVendaLiquida = 0;
            this.LucroBruto = 0;
            this.LucroLiquido = 0;
            this.PorcentagemIR = 0;
            //this.IRCalculado = 0;
            //this.Data = ;
            this.Quantidade = 0;
            this.Inativo = false;

        }
        #endregion

        #region Metodos
        public ModeloVenda()
        {
            this.Clear();
            this.Data = DateTime.Now.ToShortDateString();
        }
        //Precisa terminar de construir...
        public ModeloVenda(int codigoAcao, float ValorVendaBruta, string data, int quantidade, bool inativo)
        {
            try
            {                
                this.CodigoAcao = 0;
                this.ValorVendaBruta = 0;
                //this.ValorVendaLiquida = 0;
                this.LucroBruto = 0;
                this.LucroLiquido = 0;
                this.PorcentagemIR = 0;
                //this.IRCalculado = 0;
                this.Data = data;
                this.Quantidade = 0;
                this.Inativo = false;

            }
            catch (Exception e)
            {
               throw new Exception(e.Message);
            }
        }
        #endregion



    }
}
