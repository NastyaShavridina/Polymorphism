using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism2
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name)
        { 
        
        }

        public override void Study()
        {
            base.Study();

            Console.WriteLine("хорошо");
        }

        public override void Read()
        {
            base.Read();

            Console.WriteLine("прекрасно");
        }

        public override void Write()
        {
            base.Write();

            Console.WriteLine("хорошо");
        }

        public override void Relax()
        {
            base.Relax();

            Console.WriteLine("достаточно");
        }

        public void ShowBadPupil()
        {
            base.ShowPupil();
        }
    }
}
