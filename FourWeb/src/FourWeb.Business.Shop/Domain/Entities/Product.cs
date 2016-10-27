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


        public double GetWeightInKg()
        {
            return Convert.ToDouble(this.TechnicalDetails.Single(x => x.Title == "Peso"));
        }

        public double GetLength()
        {
            return Convert.ToDouble(this.TechnicalDetails.Single(x => x.Title == "Comprimento"));
        }

        public double GetHeight()
        {
            return Convert.ToDouble(this.TechnicalDetails.Single(x => x.Title == "Altura"));
        }

        public double GetWidth()
        {
            return Convert.ToDouble(this.TechnicalDetails.Single(x => x.Title == "Largura"));
        }

        public double GetDiagonal()
        {
            var length = this.GetLength();
            var width = this.GetWidth();
            var height = this.GetHeight();

            return Math.Sqrt((length * length) + (width * width) + (height * height));
        }
    }
}
