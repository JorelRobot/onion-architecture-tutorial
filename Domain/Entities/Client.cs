using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client : AuditableBaseEntity
    {
        private int _edad;

        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Edad
        {
            get
            {
                if (this._edad <= 0)
                {
                    this._edad = new DateTime(DateTime.Now.Subtract(this.Birthday).Ticks).Year - 1;
                }

                return this._edad;
            }
        }
    }
}
