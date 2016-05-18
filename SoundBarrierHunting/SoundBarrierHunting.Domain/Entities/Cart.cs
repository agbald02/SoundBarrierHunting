using System.Collections.Generic;
using System.Linq;


namespace SoundBarrierHunting.Domain.Entities
{
    public class Cart
    {
        private List<Cartline> lineCollection = new List<Cartline>();

        public void AddItem(Product product, int quantity)
        {
            Cartline line = lineCollection
                .Where(p => p.Product.ID == product.ID)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new Cartline
                                    {
                                        Product = product,
                                        Quantity = quantity});
                                    }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Product product)
        {
            lineCollection.RemoveAll(l => l.Product.ID == product.ID);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Product.Price * e.Quantity);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<Cartline> Lines
        {
            get { return lineCollection; }
        }
    }

    public class Cartline
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
