using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism2
{
    public class ClassRoom
    {
        private List<Pupil> Pupils;

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            Pupils = new List<Pupil> {pupil1, pupil2, pupil3, pupil4};
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            Pupils = new List<Pupil> { pupil1, pupil2};
        }

        public ClassRoom(Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            Pupils = new List<Pupil> { pupil2, pupil3, pupil4 };
        }

        public void Show()
        {
            foreach (var pupil in Pupils)
            {
                if (pupil != null)  
                   pupil.ShowPupil();
            }
           
        }
    }
}
