﻿using System.Collections.Generic;
using System.Windows.Media;
using WpfApplication.Domain.Enum;

namespace WpfApplication.Domain.Entity
{
    public class Face
    {
        public Face()
        {
            Facies = new List<Face>();
        }

        public FaceType Type { get; set; }

        public FaciePositionType FaciePositionType { get; set; }

        public Color Color { get; set; }

        public IList<Face> Facies { get; set; }
    }
}