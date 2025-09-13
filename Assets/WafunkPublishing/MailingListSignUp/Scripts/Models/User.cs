
using System;

namespace com.wafunkpublishing
{
    [Serializable]
    public class User
    {
        public string email;
        public ContactField fields;
        public string[] groups;
    }

    [Serializable]
    public class ContactField
    {
        public string name;
    }
}
