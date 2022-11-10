namespace Mediator.Mediator
{
    public abstract class ICollague
    {
        private IMediator mediator;

        public IMediator Mediator
        {
            get;
        }

        public ICollague(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public void Comminicate(string message)
        {
            this.mediator.Send(message, this);
        }

        public abstract void Receive(string messaje);
    }
}
