using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFolderVezba.BiznisSloj
{
    public class File : DataBase
    {
        private long velicina;
        public File(string ime,long velicina) 
            : base(ime)
        {
            if (velicina < 0)
            {
                throw new ArgumentException();
            }

            this.velicina = velicina;
        }

        public override long Velicina => velicina;
    }
}
