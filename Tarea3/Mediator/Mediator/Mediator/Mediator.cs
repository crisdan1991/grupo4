namespace Mediator.Mediator
{
    class Mediator : IMediator
    {
        private List<ICollague> collagues;

        public Mediator()
        {
            collagues = new List<ICollague>();
        }

        public void Add(ICollague collague)
        {
            this.collagues.Add(collague);
        }

        public void Send(string menssage, ICollague collague)
        {
            foreach (var c in this.collagues)
            {
                if(collague !=c)
                {
                    c.Receive(menssage);
                }
            }
        }
    }
}
