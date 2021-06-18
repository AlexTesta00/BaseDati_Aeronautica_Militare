using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeronauticaMilitare
{
    class IdGenerator
    {
        private int lenght;

        public IdGenerator() 
        {
            this.lenght = 0;
        }

        public string generateIdCode(int lenght) 
        {
            Random random = new Random();
            const string chars = "qwertyuiopasdfghjklzxcvbnm0123456789";
            return new string(Enumerable.Repeat(chars, lenght)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
