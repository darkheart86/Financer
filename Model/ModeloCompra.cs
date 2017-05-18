using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class ModeloCompra 
    {
        int _codigoCompra;
        int _codigoAcao;
        float _valorCompra;
        string _data;
        int _quantidade;
        bool _inativo;

        public ModeloCompra()
        {
            this.Clear();
            this.Data = DateTime.Now.ToShortDateString();
        }
        public ModeloCompra(int codigoAcao, float valorCompra, string data, int quantidade, bool inativo)
        {
            try
            {
                this.CodigoAcao = codigoAcao;
                this.ValorCompra = valorCompra;
                this.Data = data;
                this.Quantidade = quantidade;
                this.Inativo = inativo;
                
            }
            catch (Exception e)
            {
               throw new Exception(e.Message);
            }
        }


        public int CodigoCompra { get => _codigoCompra; set => _codigoCompra = value; }
        public int CodigoAcao { get => _codigoAcao; set => _codigoAcao = value; }
        public float ValorCompra { get => _valorCompra; set => _valorCompra = value; }
        public string Data { get => _data; set => _data = value; }
        public int Quantidade { get => _quantidade; set => _quantidade = value; }
        public bool Inativo { get => _inativo; set => _inativo = value; }

        public void Clear()
        {
            this.CodigoCompra = 0;
            this.CodigoAcao = 0;
            this.ValorCompra = 0;
            //this.Data = ;
            this.Quantidade = 0;
            this.Inativo = false;

        }


       
    }
}
