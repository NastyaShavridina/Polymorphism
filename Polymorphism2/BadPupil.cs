using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism2
{
    

    class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name)
        {
        }

        public override void Study()
        {
            base.Study();

            Console.WriteLine("плохо");
        }

        public override void Read()
        {
            base.Read();

            Console.WriteLine("хорошо");
        }

        public override void Write()
        {
            base.Write();

            Console.WriteLine("плохо");
        }

        public override void Relax()
        {
            base.Relax();

            Console.WriteLine("много");
        }

        public void ShowBadPupil()
        {
            base.ShowPupil();
        }
        
    }
}
