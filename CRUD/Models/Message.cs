using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageQuestion { get; set; }
        public string MessageAnswer { get; set; }
        public Message()
        {

        }
    }
}
