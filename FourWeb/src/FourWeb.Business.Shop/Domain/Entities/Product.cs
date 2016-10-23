using FourWeb.Abstraction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FourWeb.Business.Shop.Domain.Entities
{
    public class Product : EntityBase
    {
        protected Product()
        {
            this.TechnicalDetails = new List<TechnicalDetail>();
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityOnHand { get; private set; }
        public ICollection<TechnicalDetail> TechnicalDetails { get; protected set; }

        public void UpdateQuantityOnHand(int amount)
        {
            this.QuantityOnHand = amount;
        }


        public decimal GetWeightInKg()
        {
            return Convert.ToDecimal(this.TechnicalDetails.Single(x => x.Title == "Peso"));
        }

        public decimal GetLength()
        {
            return Convert.ToDecimal(this.TechnicalDetails.Single(x => x.Title == "Comprimento"));
        }

        public decimal GetHeight()
        {
            return Convert.ToDecimal(this.TechnicalDetails.Single(x => x.Title == "Altura"));
        }

        public decimal GetWidth()
        {
            return Convert.ToDecimal(this.TechnicalDetails.Single(x => x.Title == "Largura"));
        }

        public decimal GetDiameter()
        {
            var length = this.GetLength();
            var width = this.GetWidth();
            var height = this.GetHeight();

            // TODO: Cálculo diâmetro

            throw new NotImplementedException();
        }
    }
}
