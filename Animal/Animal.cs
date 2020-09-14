using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Animal
    {
        public string name { get; set; }
        public string sound { get; set; }
        public int idNum { get; }
        public static int numOfAnimal = 1;
        public Animal()
        {

        }
        public Animal(string name, string sound, int idNum)
        {
            this.name = name;
            this.sound = sound;
            this.idNum = idNum;
        }
        public static int numofAnimal()
        {
            return numOfAnimal++;
        }
        public string MakeSound()
        {
            return name + sound;
        }

    }
}
