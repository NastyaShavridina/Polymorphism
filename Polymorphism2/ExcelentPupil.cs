using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism2
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name) : base(name)
        {
        }

        public override void Study()
        {
            base.Study();

            Console.WriteLine("отлично");
        }

        public override void Read()
        {
            base.Read();

            Console.WriteLine("отлично");
        }

        public override void Write()
        {
            base.Write();

            Console.WriteLine("отлично");
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
