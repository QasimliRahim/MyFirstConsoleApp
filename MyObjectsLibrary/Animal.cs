using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObjectsLibrary
{
    public class Animal
    {
        //properties




        public string Gender { get; set; }

        public string Color { get; set; }

        public bool IsDomestic { get; set; }

        public  string Enviroment { get; set; }

        public int Speed { get; set; }

        public string Voice { get; set; }

        public string Name { get; set; }



        // Cinsi
        // rengi
        // col heyvani
        // yasadigi muhit
        // qacis sureti
        // yasama omru


        //Methods

        public Boolean ToEat()
        {
            return true;

        }

        public void IncreaseSpeed(int newSpeed)
        {
            this.Speed = this.Speed + newSpeed;
        } 


        public void MakeNoise(string voice)
        {
            this.Voice = voice;
        }


        public void Kitten(int farrow)
        {

            this.Gender = Convert.ToString(farrow);
        }


        public Animal GetNewAnimal()
        {

            // yeni animal obyekti duzeldirik
              Animal child = new Animal();


            // duzeltdiyimiz obyektin adini quzu teyin edirik
            child.Name = "Quzu";


            //bu obyekti deyer olaraq qaytaririq
            return child;

        }


        public Animal GetWhiteLamb()
        {

            Animal GetLamb = new Animal();

            GetLamb.Name = "Ag quzu";

            return GetLamb;

        }


        public Animal GetBlackLamb()
        {

            Animal BlackLamb = new Animal();

            BlackLamb.Name = "Qara quzu";

            return BlackLamb;
        }



        // Qidalanmaq
        // Qacmaq
        // Ses cixarmaq
        // Balalamaq
       



        







    }
}
