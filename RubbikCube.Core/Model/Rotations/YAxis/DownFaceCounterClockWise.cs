﻿using System.Collections.Generic;

namespace RubiksCube.Core.Model.Rotations.YAxis
{
    internal class DownFaceCounterClockwise : YAxisRotation
    {
        public DownFaceCounterClockwise(LayerType layerType, double angle, uint times) : base(layerType, angle, times)
        {
        }

        protected override IEnumerable<FaceType> AxisMovingFaces => new[] { FaceType.Down };

        protected override void Move(Cube cube, FaceType faceType, Facie facie)
        {
            MoveFromFrontToLeft(cube, faceType, facie);
        }

        protected override void FlipMovingFacePosition(Facie facie)
        {
            if (facie.Position == FaciePositionType.LeftUp)
            {
                facie.Position = FaciePositionType.RightUp;
            }
            else if (facie.Position == FaciePositionType.MiddleUp)
            {
                facie.Position = FaciePositionType.RightMiddle;
            }
            else if (facie.Position == FaciePositionType.RightUp)
            {
                facie.Position = FaciePositionType.RightDown;
            }
            else if (facie.Position == FaciePositionType.RightMiddle)
            {
                facie.Position = FaciePositionType.MiddleDown;
            }
            else if (facie.Position == FaciePositionType.RightDown)
            {
                facie.Position = FaciePositionType.LeftDown;
            }
            else if (facie.Position == FaciePositionType.MiddleDown)
            {
                facie.Position = FaciePositionType.LeftMiddle;
            }
            else if (facie.Position == FaciePositionType.LeftDown)
            {
                facie.Position = FaciePositionType.LeftUp;
            }
            else if (facie.Position == FaciePositionType.LeftMiddle)
            {
                facie.Position = FaciePositionType.MiddleUp;
            }
        }

        protected override void FlipAdjacentFacesPosition(Facie facie, FaceType faceType)
        {
            if (facie.Position == FaciePositionType.LeftDown)
            {
                facie.Position = FaciePositionType.RightDown;
            }
            else if (facie.Position == FaciePositionType.RightDown)
            {
                facie.Position = FaciePositionType.LeftDown;
            }
        }
    }
}
