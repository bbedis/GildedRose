using System.Collections.Generic;

namespace csharp.Handlers
{
    public abstract class Handler<T> : IHandler<T> where T : class
    {
        protected static readonly Dictionary<T, int> dic = new Dictionary<T, int>();
        private IHandler<T> Next { get; set; }

        public virtual void Handle(T request)
        {
            Next?.Handle(request);
        }

        public IHandler<T> SetNext(IHandler<T> next)
        {
            Next = next;
            return Next;
        }
    }
}
