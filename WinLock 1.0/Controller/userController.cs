using System;
using System.Collections.Generic;
using System.Text;

namespace com.codeBlack.winLock.Controller
{
    internal class userController
    {
        public string accountHolderName;
        public string accountHolderRole;

        string getHolderName()
        {
            return accountHolderName;
        }

        string getHolderRole()
        {
            return accountHolderRole;
        }
    }
}
