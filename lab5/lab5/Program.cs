using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Printer
    {
        public string IAmPrinting(Object obj)
        {
            return obj.ToString();
        }
    }
   interface IPerson//в интерфейсе и абстр классе одноименные методы
    {
        void Move();
    }
    abstract class Movement
    {
        public abstract void Move();
    }
    class Person : Movement, IPerson
    {
        public string name;
        public int age=18;
        public override void Move()
        {
            Console.WriteLine("Человек идет");
        }

        public override string ToString()
        {
            if (String.IsNullOrEmpty(name))
            {
                return "Имя не определено";
            }
            return "Продюссера зовут " + name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }


    interface ITVprogram
    {
        void Watch();
        void Show();
    }
    abstract class TVprogram
    {
        public int agelimit;
        public double time;
    }

    class Film : TVprogram, ITVprogram
    {
        public string name;
        public int year;
        public int limit = 16;
        public Film(string name, int year, double time, int agelimit)
        {
            this.year=year;
            this.name=name;
            this.time=time;
            this.agelimit=agelimit;
        }
        public void Watch()
        {
            if (agelimit > limit)
            {
                Console.WriteLine("Вам разрешено смотреть этот фильм");
            }
            else
            {
                Console.WriteLine("Вам рано еще смотреть этот фильм");
            }
        }
        public override string ToString()
        {
            return $"Возрастное ограничение на просмотр этого фильма {agelimit}";
        }
        public virtual void Show()
        {
            Console.WriteLine("\n\nНазвание: "+name+"\n"+ "Год: " + year + "\n"+"Продолжительность: " + time + "\n"+"Возрастное ограничение: " + agelimit + "\n");
        }
    }

    class News : TVprogram, ITVprogram
    {
        public string theme;
        public string speackers;
        public int limit = 18;
        public News( string theme, string speackers, double time,int agelimit)
        {
            this.theme = theme;
            this.speackers = speackers;
            this.agelimit = agelimit;
            this.time = time;  
        }
        public override string ToString()
        {
            return $"Возрастное ограничение этих новостей {limit}";
        }
        public void Watch()
        {
            if (agelimit > limit)
            {
                Console.WriteLine("Вам разрешено смотреть новости");
            }
            else
            {
                Console.WriteLine("Вам рано смотреть");
            }
        }
        public virtual void Show()
        {
            Console.WriteLine("\n\nТема: " + theme + "\n" + "Ведущие: " + speackers + "\n" + "Продолжительность: " + time + "\n" + "Возрастное ограничение: " + agelimit + "\n");
        }
        public override bool Equals(object obj)
        {
            if (obj == null) // проверка
            {
                Console.WriteLine("Что-то не так");
                return false;
            }

            obj = obj as News;
            if (obj != null)
            {
                Console.WriteLine("Это действительно новости");
                return true;
            }

            Console.WriteLine("Это не новости!");
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    class Filmic: TVprogram, ITVprogram//художественный фильм
    {
        public string name;
        public int limit = 12;
        public Filmic(string name, double time, int agelimit)
        {
            this.name = name;
            this.agelimit = agelimit;
            this.time = time;
        }
        public override string ToString()
        {
            return $"Возрастное ограничение этого художественного фильма {limit}";
        }
        public void Watch()
        {
            if (agelimit > limit)
            {
                Console.WriteLine("Вам разрешено смотреть фильм");
            }
            else
            {
                Console.WriteLine("Вам рано смотреть");
            }
        }
        public virtual void Show()
        {
            Console.WriteLine("\n\nНазвание: " + name + "\n" + "Продолжительность: " + time + "\n" + "Возрастное ограничение: " + agelimit + "\n");
        }
    }

     class Cartoon : TVprogram, ITVprogram
    {
        public string name;
        static int limit = 8;
        public Cartoon(string name, double time,int agelimit)
        {
            this.name = name;
            this.agelimit = agelimit;
            this.time = time;
        }
        public override string ToString()
        {
            return $"Возрастное ограничение этого мультфильма {limit}";
        }
        public void Watch()
        {
            if (agelimit > limit)
            {
                Console.WriteLine("Вам можно смотреть мультфильм");
            }
            else
            {
                Console.WriteLine("Вам нельзя это смотреть");
            }
        }
        public virtual void Show()
        {
            Console.WriteLine("\n\nНазвание: " + name + "\n" + "Продолжительность: " + time + "\n" + "Возрастное ограничение: " + agelimit + "\n");
        }
     }
    class Advertisment: TVprogram, ITVprogram
    {
        public double limit = 4.00;
        public Advertisment( int agelimit)
        {
            this.agelimit = agelimit;
        }
        public override string ToString()
        {
            return $"Максимальное время рекламы {limit}";
        }
        public void Watch()
        {
            if (agelimit < limit)
            {
                Console.WriteLine("Достаточное количество");
            }
            else
            {
                Console.WriteLine("Чересчур рекламы");
            }
        }
        public virtual void Show()
        {
            Console.WriteLine("\n\nПродолжительность рекламы: "  + agelimit + "\n");
        }
    }

    sealed class Director : Person, IPerson
    {
        public int Age;
        public string Name { get; set; }
        public string Surname { get; set; }
        public Director( string surname, string name, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public  void Information()
        {
            Console.WriteLine("\n\nДанные режиссера: "+ Surname +" "+ Name+" "+ Age);
        }
        public override bool Equals(object obj)
        {
            if (obj == null) // проверка
            {
                Console.WriteLine("Что-то не так");
                return false;
            }

            obj = obj as Director; 
            if (obj != null)
            {
                Console.WriteLine("Это действительно режиссер.");
                return true;
            }

            Console.WriteLine("Это не режиссер!");
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
   

        class Program
        {
            static void Main(string[] args)
            {
                Person person = new Person();
                person.name = "Елена";
                Console.WriteLine(person.name+" "+person.age+" ");
                Person person1 = new Person();
                person1.name = "Elena";
                Console.WriteLine(person1.ToString());
                Console.WriteLine(person1.GetHashCode());
                person1.Move();
                Film film1 = new Film("Бойцовский клуб", 1999, 1.03, 18);
                film1.Show();
                Console.WriteLine(film1.ToString());
                film1.Watch();
                News news1 = new News("Погода", "Иванов И. и Иванов К.", 45, 21);
                news1.Show();
                Console.WriteLine(news1.ToString());
                news1.Watch();
                Filmic filmic1 = new Filmic("Форрест Гамп", 1.30, 10);
                filmic1.Show();
                Console.WriteLine(filmic1.ToString());
                filmic1.Watch();
                Cartoon cartoon1 = new Cartoon("Русалочка", 1.10, 6);
                cartoon1.Show();
                Console.WriteLine(cartoon1.ToString());
                cartoon1.Watch();
                Advertisment advertisment1 = new Advertisment(6);
                advertisment1.Show();
                Console.WriteLine(advertisment1.ToString());
                advertisment1.Watch();
                Director director1 = new Director("Berton", "Tim", 45);
                director1.Information();
                if(director1 is Director)
                { 
                 Console.WriteLine("Это известный режиссер");
                }
               if(film1 is News)
               {
                  Console.WriteLine("Бред");
               }
               else
               
                Console.WriteLine("Фильм не является новостями");
            

            }
        }
    
}


