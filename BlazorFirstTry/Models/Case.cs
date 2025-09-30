using BlazorFirstTry.Models.Enums;

namespace BlazorFirstTry.Models
{
    public class Case
    {
        private int _x;
        private int _y;
        private bool _isHidden;
        private State? _state; 

        public int X 
        {
            get
            {
                return _x;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }
        }
        public bool IsHidden
        {
            get
            {
                return _isHidden;
            }
            set
            {
                _isHidden = value;
            }

        }
        public State? CaseState
        {
            get
            {
                return _state;
            }
            set 
            { 
                _state = value; 
            }
        }
        public Case(int x, int y)
        {
            _x = x;
            _y = y;
            _isHidden = true;
        }
    }
}
