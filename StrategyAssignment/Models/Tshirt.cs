using StrategyAssignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment.Models
{
    class Tshirt
    {

        private IPaymentStrategy _paymentStrategy;

        public string Name { get; }
        public Color Color { get; }
        public Size Size { get; }
        public Fabric Fabric { get; }

        #region Payment Strategy
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            if (paymentStrategy == null)
            {
                throw new ArgumentNullException(nameof(paymentStrategy));
            }
            _paymentStrategy = paymentStrategy;
        }
        public void Pay()
        {
            _paymentStrategy.DoPayment(this);
        }

        #endregion

        #region Constructors

        public Tshirt(string name, Color color, Size size, Fabric fabric)
        {
            this.Name = name;
            this.Color = color;
            this.Size = size;
            this.Fabric = fabric;
            
        }

        public Tshirt(string name,Color color, Size size, Fabric fabric,IPaymentStrategy paymentStrategy) : this(name,color, size, fabric)
        {
            if (paymentStrategy == null)
            {
                throw new ArgumentNullException(nameof(paymentStrategy));
            }
            _paymentStrategy = paymentStrategy;

        }

        #endregion

    }
}
