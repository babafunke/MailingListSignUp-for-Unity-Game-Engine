
using System;

namespace com.wafunkpublishing
{
    [Serializable]
    public class User
    {
        public string name;
        public string email;

        public User(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
    }
}
