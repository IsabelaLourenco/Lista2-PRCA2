using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRCAEX10
{
    class Retangulo
    {
        private int b;
        private int h;
        private int a;

        public Retangulo()
        {
            b = 0;
            h = 0;
            a = 0;
        }

        public Retangulo(int b, int h, int a)
        {
            this.b = b;
            this.h = h;
            this.a = a;
        }

        public void setB(int b)
        {
            this.b = b;
        }
        public void setH(int h)
        {
            this.h = h;
        }
     
        public int getA()
        {
            return this.a;
        }
        public void area()
        {
            this.a = this.b * this.h;
        }
    }
}
