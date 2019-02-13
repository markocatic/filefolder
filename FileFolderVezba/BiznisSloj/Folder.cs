using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFolderVezba.BiznisSloj
{
    public class Folder : DataBase
    {
        public static bool daLiJeObjekatUStablu(Folder root, DataBase obj)
        {
            if ((root == null) || (obj == null))
                return false;
            bool jeste = root.lista.Contains(obj);
            if (jeste)
                return true;
            foreach (DataBase item in root.lista)
            {
                Folder itemCast = item as Folder;
                if (itemCast != null)
                {
                    jeste = Folder.daLiJeObjekatUStablu(itemCast, obj);
                    if (jeste)
                        return true;
                }
            }
            return false;
        }
        public Folder(string ime) : base(ime)
        {
        }

        private List<DataBase> lista = new List<DataBase>();
        public override long Velicina
        {
            get
            {
                long velicinaTmp = 0;
                foreach (DataBase item in this.lista)
                    velicinaTmp += item.Velicina;
                return velicinaTmp;
            }
        }

        public void dodaj(DataBase obj)
        {
            if (obj == null)
            {
                return;
            }
            if(this.daLiJeObjekatUStablu(obj))
                return;
            obj.Roditelj = this;
            this.lista.Add(obj);
        }
    }
}
