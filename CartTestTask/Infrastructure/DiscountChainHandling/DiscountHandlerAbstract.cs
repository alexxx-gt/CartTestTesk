using CartTestTask.Models;

namespace CartTestTask.Infrastructure.DiscountChainHandling
{
    public abstract class DiscountHandlerAbstract
    {
        public DiscountHandlerAbstract Successor { get; set; }
        public abstract void Handle(Cart cart);
    }
}
