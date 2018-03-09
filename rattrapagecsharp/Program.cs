using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rattrapagecsharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Vecteur2D vect1 = new Vecteur2D();
            Vecteur2D vect2 = new Vecteur2D();

            Vecteur3D vect3 = new Vecteur3D();
            Vecteur3D vect4 = new Vecteur3D();

            Console.WriteLine(vect1.Tostring());
            Console.WriteLine(vect2.Tostring());

            Console.WriteLine(vect3.Tostring());
            Console.WriteLine(vect4.Tostring());

            bool v1 = Vecteur2D.Equals(vect1, vect2);
            bool v2 = Vecteur3D.Equals(vect3, vect4);

            Console.WriteLine(v1);
            Console.WriteLine(v2);

            Console.WriteLine(vect1.Norme());
            Console.WriteLine(vect2.Norme());

            Console.WriteLine(vect3.Norme());
            Console.WriteLine(vect4.Norme());

            Console.ReadLine();
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
        }
    }
}
