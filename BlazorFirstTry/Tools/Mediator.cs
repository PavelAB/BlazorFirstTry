using BlazorFirstTry.Models;
using System.ComponentModel;

namespace BlazorFirstTry.Tools
{
    public record KeyForDict(int X, int Y);
    public class Mediator<TMessage>
    {
        public static Mediator<TMessage> Instance = new();

        private Mediator() { }


        //private Action< TMessage>? _broadcast;
        private Dictionary<KeyForDict, Action<TMessage>> _box = new();

        public void Register(KeyForDict key, Action<TMessage> action)
        {
            if(!(_box.ContainsKey(key)))
                _box.Add(key, action);
        }
        public void Unregister(KeyForDict key, Action<TMessage> action)
        {
            if (_box.ContainsKey(key))
                _box.Remove(key);
        }
        public void Send(KeyForDict key, TMessage message)
        {
            IEnumerable<Action<TMessage>> _broadcast = _box
                .Where(c =>
                    Math.Abs(key.X - c.Key.X) < 2 &&
                    Math.Abs(key.Y - c.Key.Y) < 2 &&
                    !(key.X == c.Key.X && key.Y == c.Key.Y)).Select(c => c.Value);

            foreach(Action<TMessage> action in _broadcast)
            {
                action.Invoke(message);
            }
        }


    }
}
