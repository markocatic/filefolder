using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileFolderVezba.BiznisSloj;

namespace FileFolderVezba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Folder folder1 = new Folder("Folder1");
            File file1 = new File("File1",3);
            folder1.dodaj(file1);
            File file2 = new File("File2",4);
            folder1.dodaj(file2);
            folder1.dodaj(file2);
            Folder folder2 = new Folder("Folder2");
            folder1.dodaj(folder2);
            File file3 = new File("File3", 2);
            folder2.dodaj(file3);
            Folder folder3 = new Folder("Folder3");
            folder1.dodaj(folder3);
            File file4 = new File("File4", 1);
            folder3.dodaj(file4);
            File file5 = new File("File5", 4);
            folder3.dodaj(file5);
            Folder folder4 = new Folder("Folder4");
            folder2.dodaj(folder4);
            Folder folder5 = new Folder("Folder5");
            folder2.dodaj(folder5);
            File file7 = new File("File7", 2);
            File file8 = new File("File8", 3);
            folder4.dodaj(file7);
            folder4.dodaj(file8);
            File file9 = new File("File9", 6);
            File file10 = new File("File10", 2);
            folder5.dodaj(file9);
            folder5.dodaj(file10);
            long velicina = folder1.Velicina;
        }
    }
}
