using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coca
{
    class ExpenderProcess
    {
        private double precio= 4.5;
        private double cambio ;
        private double coins ;
        private double resultInsert = 0;
        private int coca= 2;
        private int fresca = 2;
        private int manzanita = 2;
        private int sprite = 2;
        private int fanta = 2;



        public double Precio { get => precio; set => precio = value; }
        public double Cambio { get => cambio; set => cambio = value; }
        public double Coins { get => coins; set => coins = value; }
        public double ResultInsert { get => resultInsert; set => resultInsert = value; }
        public int Coca { get => coca; set => coca = value; }
        public int Fresca { get => fresca; set => fresca = value; }
        public int Manzanita { get => manzanita; set => manzanita = value; }
        public int Sprite { get => sprite; set => sprite = value; }
        public int Fanta { get => fanta; set => fanta = value; }

        public void CalculoMonetario()
        {
            this.ResultInsert += this.Coins;
            this.Cambio = this.ResultInsert - this.Precio;
        }

        public int ValidarExisteneTotal()
        {
            int res = 0;
            if (this.Coca == 0 && this.Fresca == 0 && this.Fanta == 0 && this.Sprite == 0 && this.Manzanita == 0)
            {
                res = 0;
            }
            else {
                res = 1;
            }
            return res;
        }

        public  int validarExistencias(int num)
        {
            int existencias = 0;

            if (num==1) {
                existencias = this.Coca;            
            }
            if (num == 2)
            {
                existencias = this.Fresca;
            }
            if (num == 3)
            {
                existencias = this.Fanta;
            }
            if (num == 4)
            {
                existencias = this.Sprite;
            }

            if (num == 5)
            {
                existencias = this.Manzanita;
            }
            


            return existencias;
        }


        public void expendercoca()
        {
            if (this.Coca > 0)
            {
                this.Coca -= 1;

            }
            else {
                this.Coca =0;
            }

        }


        public void expenderFresca()
        {
            if (this.Fresca > 0)
            {
                this.Fresca -= 1;

            }
            else
            {
                this.Fresca = 0;
            }

          
        }


        public void expenderFanta()
        {
            if (this.Fanta > 0)
            {
                this.Fanta -= 1;

            }
            else
            {
                this.Fanta = 0;
            }

          
        }


        public void expenderSprite()
        {
            if (this.Sprite > 0)
            {
                this.Sprite -= 1;

            }
            else
            {
                this.Sprite = 0;
            }

          
        }



        public void expenderManzanita()
        {
            if (this.Manzanita > 0)
            {
                this.Manzanita -= 1;

            }
            else
            {
                this.Manzanita = 0;
            }
           
        }


       

    }

}
