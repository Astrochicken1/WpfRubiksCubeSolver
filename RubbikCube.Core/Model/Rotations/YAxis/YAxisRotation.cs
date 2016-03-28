﻿using System;
using System.Collections.Generic;

namespace RubiksCube.Core.Model.Rotations.YAxis
{
    public abstract class YAxisRotation : Rotation
    {
        protected YAxisRotation(double angle, uint times) : base(angle, times)
        {
        }

        protected override IEnumerable<FaceType> MovingFaces => new[] { FaceType.Front, FaceType.Left, FaceType.Back, FaceType.Right };

        protected override IEnumerable<Facie> GetMovingFacies(Face face)
        {
            return face.GetRow(LayerType);
        }

        public override double[,] CreateRotationMatrix(double angle)
        {
            var matrix = new double[4, 4];
            matrix[0, 0] = 1;
            matrix[0, 1] = 0;
            matrix[0, 2] = 0;
            matrix[0, 3] = 0;
            matrix[1, 0] = 0;
            matrix[1, 1] = Math.Cos(angle);
            matrix[1, 2] = Math.Sin(angle);
            matrix[1, 3] = 0;
            matrix[2, 0] = 0;
            matrix[2, 1] = -Math.Sin(angle);
            matrix[2, 2] = Math.Cos(angle);
            matrix[2, 3] = 0;
            matrix[3, 0] = 0;
            matrix[3, 1] = 0;
            matrix[3, 2] = 0;
            matrix[3, 3] = 1;

            return matrix;
        }

        protected static void FlipPosition(Facie facie)
        {
            if (facie.FaciePosition == FaciePositionType.LeftTop)
            {
                facie.FaciePosition = FaciePositionType.RightTop;
            }
            else if (facie.FaciePosition == FaciePositionType.RightTop)
            {
                facie.FaciePosition = FaciePositionType.LeftTop;
            }
            else if (facie.FaciePosition == FaciePositionType.LeftMiddle)
            {
                facie.FaciePosition = FaciePositionType.RightMiddle;
            }
            else if (facie.FaciePosition == FaciePositionType.RightMiddle)
            {
                facie.FaciePosition = FaciePositionType.LeftMiddle;
            }
            else if (facie.FaciePosition == FaciePositionType.LeftBottom)
            {
                facie.FaciePosition = FaciePositionType.RightBottom;
            }
            else if (facie.FaciePosition == FaciePositionType.RightBottom)
            {
                facie.FaciePosition = FaciePositionType.LeftBottom;
            }
        }
    }
}
