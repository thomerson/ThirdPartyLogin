using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdPartyLogin.Model
{
    public class User: BaseEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
