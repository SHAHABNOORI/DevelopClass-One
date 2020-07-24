using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Pattern
{
    public abstract class TransferMoney
    {
        protected TransferMoney Successor;

        protected TransferMoney(TransferMoney successor)
        {
            Successor = successor;
        }

        public abstract ResponceContext Execute(RequestContext requestContext);
    }
}