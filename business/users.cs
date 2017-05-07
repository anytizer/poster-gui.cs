using dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using users;

namespace business
{
    public class users
    {
        public string apply(string email)
        {
            string apply = endpoints.apply;

            user user = new user()
            {
                email = email,
                on = System.DateTime.Now.ToShortDateString(),
            };

            poster poster = new poster();
            string output = poster.post(apply, user);

            return output;
        }
    }
}
