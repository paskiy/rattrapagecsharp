using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rattrapagecsharp
{
    class Vecteur2D
    {
        protected double abscisseX;
        protected double ordonneY;
        private static int nbreVectcreer;

        public Vecteur2D()
        {
            this.abscisseX = 0;
            this.ordonneY = 0;

        }

        public Vecteur2D(double abscisse, double ordonne)
        {
            this.abscisseX = abscisse;
            this.ordonneY = ordonne;
            nbreVectcreer++;
        }

        public Vecteur2D(Vecteur2D vecteur2D)
        {
            this.abscisseX = vecteur2D.abscisseX;
            this.ordonneY = vecteur2D.ordonneY;
        }
        public double AbscisseX
        {
            get { return this.abscisseX; }
            set { this.abscisseX = value; }
        }

        public double OrdonneY
        {
            get { return this.ordonneY; }
            set { this.ordonneY = value; }
        }

        public string Tostring()
        {

            return "X=" +this.abscisseX + "-"+"Y="+this.ordonneY;
        }

        public static bool Equals(Vecteur2D vect1, Vecteur2D vect2)
        {
            if ((vect1.abscisseX == vect2.abscisseX) && (vect1.ordonneY == vect2.ordonneY))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public double Norme()
        {
            double x = this.abscisseX * this.abscisseX;
            double y = this.ordonneY * this.ordonneY;
            double z = x + y;
            double result = Math.Sqrt(z);
            return result;
        }
       
    }

    class Vecteur3D : Vecteur2D
    {
        protected double Z;

        public Vecteur3D()
        {
            this.Z = 0;
        }
        public Vecteur3D(double abscisse, double ordonne, double z) : base(abscisse, ordonne)
        {
            this.Z = z;
        }

        public Vecteur3D(Vecteur3D vecteur3D)
        {
            this.abscisseX = vecteur3D.abscisseX;
            this.ordonneY = vecteur3D.ordonneY;
            this.Z = vecteur3D.Z;
            
        }
       
        public double TroisiemedimensionZ
        {
            get { return this.Z; }
            set { this.Z = value; }
        }

        public static bool Equals(Vecteur3D vect1, Vecteur3D vect2)
        {
            if ((vect1.abscisseX == vect2.abscisseX) && (vect1.ordonneY == vect2.ordonneY) && (vect1.Z == vect2.Z))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        new public string Tostring()
        {

            return "X=" + this.abscisseX + "-" + "Y=" + this.ordonneY + "Z=" + this.Z;
        }

        new public double Norme()
        {
            double x = this.abscisseX * this.abscisseX;
            double y = this.ordonneY * this.ordonneY;
            double t = this.Z * this.Z;
            double z = x + y + t;
            double result = Math.Sqrt(z);
            return result;
        }
    }
}
