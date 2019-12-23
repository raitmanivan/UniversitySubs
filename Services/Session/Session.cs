using EE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Session
{
    public class Session
    {
        private static Session instance = null;
        private Session() { }

        public static Session getInstance()
        {
            if (instance == null)
            {
                instance = new Session();
            }
            return instance;
        }

        public User user { get; set; }

        public bool Logout()
        {
            try
            {
                this.user = null;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
