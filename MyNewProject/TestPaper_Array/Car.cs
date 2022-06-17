using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewProject.TestPaper_Array
{
    class Engine
    {
        int engine_id;
        int clean_date;

        public Engine(int engine_id, int clean_date)
        {
            this.engine_id = engine_id;
            this.clean_date = clean_date;
        }
        public void DisplayEngine()
        {
            Console.Write(engine_id + " " + clean_date);
        }
    }
    class SubEngine
    {
        string subenginetype;
        Engine eng;

        public SubEngine(string subenginetype, Engine eng)
        {
            this.subenginetype = subenginetype;
            this.eng = eng;
        }
        public void DisplaySubEngine()
        {
            Console.Write(subenginetype + " ");
        }
        class Gear
        {
            string geartype;
            Engine eng;
            SubEngine subeng;

            public Gear(string geartype,Engine eng,SubEngine subeng)
            {
                this.geartype = geartype;
                this.eng = eng;
                this.subeng = subeng;
            }
            public void DisplayGear()
            {
                Console.Write(geartype + " ");
            }
        }

        class Car
        {
            int carId;
            string carcolor;
            Engine eng;
            SubEngine subeng;
            Gear gr;

            Car(int carId,string carcolor,Engine eng,SubEngine subeng,Gear gr)
            {
                this.carId = carId;
                this.carcolor = carcolor;
                this.eng = eng;
                this.subeng=subeng;
                this.gr = gr;
            }
            void show()
            {
                Console.Write(carId+" "+carcolor+" ");
                eng.DisplayEngine();
                gr.DisplayGear();
            }
            static void Main(string[] args)
            {
               // Car c = new Car(123, "Black", new Engine(00000111, 05-11-2022,(new Gear("Auto")));
                //c.show();
            }


        }
    }
}
