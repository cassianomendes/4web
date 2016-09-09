using FourWeb.Abstraction.Domain.Entities;
using System.Collections.Generic;

namespace FourWeb.Business.Manager.Domain.Entities
{
    public class Product : EntityBase
    {
        private IList<TechnicalDetail> _technicalDetails;

        public Product(string title, string description, decimal price, int quantityOnHand, int category, string image = "")
        {
            this.Title = title;
            this.Description = description;
            this.Price = price;
            this.QuantityOnHand = quantityOnHand;
            this.CategoryId = category;
            this.Image = image;
            this._technicalDetails = new List<TechnicalDetail>();
        }
        
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityOnHand { get; private set; }
        public int CategoryId { get; private set; }
        public string Image { get; private set; }
        public Category Category { get; private set; }
        public ICollection<TechnicalDetail> TechnicalDetails
        {
            get { return _technicalDetails; }
            private set { _technicalDetails = new List<TechnicalDetail>(value); }
        }

        public void AddTechnicalDetail(TechnicalDetail item)
        {
            _technicalDetails.Add(item);
        }

        public void UpdatePrice(decimal price)
        {
            this.Price = price;
        }

        public void UpdateInfo(string title, string description, int category)
        {
            this.Title = title;
            this.Description = description;
            this.CategoryId = category;
        }
    }
}
