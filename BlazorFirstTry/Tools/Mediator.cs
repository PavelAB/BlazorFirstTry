using System.ComponentModel;

namespace BlazorFirstTry.Tools
{
    public class Mediator<TMessage>
    {
        public static Mediator<TMessage> Instance = new();

        private Mediator() { }


        private Action<TMessage>? _broadcast;

        public void Register(Action<TMessage> action)
        {
            _broadcast += action;
        }
        public void Unregister(Action<TMessage> action)
        {
            _broadcast -= action;
        }
        public void Send(TMessage message)
        {
            _broadcast?.Invoke(message);
        }


    }
}
