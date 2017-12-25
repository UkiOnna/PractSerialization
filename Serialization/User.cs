using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
   public class User
    {
        [NonSerialized]
        [JsomIgnore]
        private int id;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public Person Person { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
