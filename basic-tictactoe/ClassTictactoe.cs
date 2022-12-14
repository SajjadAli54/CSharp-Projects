using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic
{
    class ClassTictactoe
    {
        String userOne = "O";
        String userTwo = "X";
        bool toggle = true;

        public void setToggle(bool v)
        {
            toggle = v;
        }

        public bool getToggle() {
            return toggle;
        }

        public String getUserOne()
        {
            return userOne;
        }

        public String getUserTwo()
        {
            return userTwo;
        }
    }
}
