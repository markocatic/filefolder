using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFolderVezba.BiznisSloj
{
    public abstract class DataBase
    {
        private DataBase roditelj = null;
        private string ime;

        private string Ime
        {
            get => ime;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    ime = value;
            }
        }

        public abstract long Velicina { get; }

        public string Putanja
        {
            get
            {
                if (this.Roditelj == null)
                    return this.ime;
                string tmp = $"{this.Roditelj.Putanja}\\{this.ime}";
                return tmp;
            }
        }

        public virtual bool daLiJeObjekatUStablu(DataBase obj)
        {
            DataBase mojRoot = this.Root;
            DataBase objRoot = obj.Root;
            return mojRoot == objRoot;
        }

        protected DataBase(string ime)
        {
            if (string.IsNullOrEmpty(ime))
            {
                throw new ArgumentException();
            }

            this.ime = ime;
        }

        public DataBase Root
        {
            get
            {
                if (this.Roditelj == null)
                {
                    return this;
                }

                return this.Roditelj.Root;
            }
        }

        public DataBase Roditelj
        {
            get => roditelj;
            set => roditelj = value;
        }
    }
}
