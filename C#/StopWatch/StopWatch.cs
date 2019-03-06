using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _start;
        private DateTime _stop;
        private bool _state;

        public DateTime Start()
        {
            if (_state)
            {
                throw new InvalidOperationException("Please stop the last measurement");
            }
            _start = DateTime.Now;
            _state = true;
            return _start;
        }
        public DateTime Stop()
        {
            if (!_state)
            {
                throw new InvalidOperationException("First you should start measurement");
            }
            this._stop = DateTime.Now;
            _state = false;
            return _stop;
        }
        public TimeSpan Duration()
        {
            if (_state)
            {
                return DateTime.Now - _start;
            }
            else
            {
                return _stop - _start;
            }
        }
    }
}
