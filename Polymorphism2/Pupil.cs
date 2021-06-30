using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism2
{
    public delegate void PupilDelegate();

    public abstract class Pupil
    {
        private string Name { get; set; }

       public PupilDelegate PupilDelegate { get; set; }

        public Pupil(string name)
        {
            this.Name = name;
        }

        public virtual void Study()
        {
            Console.WriteLine($"Ученик {Name}. Учится : ");
        }

        public virtual void Read()
        {
            Console.WriteLine($"Ученик {Name}. Читает : ");
        }

        public virtual void Write()
        {
            Console.WriteLine($"Ученик {Name}. Пишет : ");
        }

        public virtual void Relax()
        {
            Console.WriteLine($"Ученик {Name}. Отдыхает : ");
        }

        public virtual void ShowPupil()
        {
            PupilDelegate = new PupilDelegate(Study);

            PupilDelegate += Read;

            PupilDelegate += Write;

            PupilDelegate += Relax;

            PupilDelegate.Invoke();
        }
    }
}
