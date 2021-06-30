using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism2
{
    public class ClassRoom
    {
        private Pupil Pupil1 { get; set; }

        private Pupil Pupil2 { get; set; }

        private Pupil Pupil3 { get; set; }

        private Pupil Pupil4 { get; set; }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            this.Pupil1 = pupil1;

            this.Pupil2 = pupil2;

            this.Pupil3 = pupil3;

            this.Pupil4 = pupil4;
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            this.Pupil1 = pupil1;

            this.Pupil2 = pupil2;
        }

        public ClassRoom(Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            this.Pupil2 = pupil2;

            this.Pupil3 = pupil3;

            this.Pupil4 = pupil4; 
        }

        public void Show()
        {
            if (Pupil1 != null)
            {
                Pupil1.ShowPupil();
            }

            if (Pupil2 != null)
            {
                Pupil2.ShowPupil();
            }

            if (Pupil3 != null)
            {
                Pupil3.ShowPupil();
            }

            if (Pupil4 != null)
            {
                Pupil4.ShowPupil();
            }
           
        }
    }
}
