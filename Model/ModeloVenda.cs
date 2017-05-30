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
        int _codigoVenda;                           //primario
        int _codigoAcao;                            //primario
        float _valorVendaAcao;                      //primario
        float _valorVendaBruta;                     //calculado
        float _valorVendaLiquida;                   //calculado
        float _lucroBruto;                          //
        float _lucroLiquido;                        //calculado
        float _porcentagemIR;                       //primario
        float _irCalculado;                         //calculado
        float _valorMedioDeEstoque;                 //primario
        string _data;                               //primario
        int _quantidade;                            //primario
        bool _inativo;                              //primario
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
        public float ValorVendaAcao
        {
            get
            {
                return _valorVendaAcao;
            }


            set
            {
                _valorVendaAcao = value;
            }
        }
        public float ValorVendaBruta //*
        {
            get
            {
                return Quantidade * ValorVendaAcao;
            }

            
        }
        public float ValorVendaLiquida //*
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
        public float LucroBruto
        {
            get
            {
                return (_lucroBruto - ValorVendaLiquida);
            }

            set
            {
                _lucroBruto = value;
            }
        }
        public virtual float LucroLiquido//*
        {
            //Seria ValorVendaLiquida - ValorMedio de estoque
            get
            {
                return ValorVendaLiquida - IVV;
            }

           
        }
        public float PorcentagemIR//*
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
        public float IRCalculado//*
        {
           
            get
            {   // IrCalculado sobre venda bruta
                return ValorVendaBruta * (PorcentagemIR / 100);

                //IR Calculado sobre lucro
            }

            //set
            //{
            //    _irCalculado = value;
            //}
        }
        public float ValorMedioDeEstoque
        {
            get
            {
                //return _valorMedioDeEstoque;
                if (_valorMedioDeEstoque >= 0)
                {
                    return _valorMedioDeEstoque;
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                _valorMedioDeEstoque = value;
            }
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
        public float IVV//*
        {
            get
            {
               return Quantidade * ValorMedioDeEstoque;
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
            this.ValorVendaAcao = 0;
            this.PorcentagemIR = 0;
            this.ValorMedioDeEstoque = 0;
            this.Data = DateTime.Now.ToShortDateString();
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
                this.PorcentagemIR = 0;
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
