﻿using System.Collections.Generic;

namespace RubiksCube.Core.Model.Rotations.ZAxis
{
    internal class BackFaceCounterClockwise : ZAxisRotation
    {
        public BackFaceCounterClockwise(LayerType layerType, double angle, uint times) : base(layerType, angle, times)
        {
        }

        protected override IEnumerable<FaceType> AxisMovingFaces => new[] { FaceType.Back };

        protected override void Move(Cube cube, FaceType faceType, Facie facie)
        {
            MoveFromUpToRight(cube, faceType, facie);
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

            if (faceType == FaceType.Up)
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
            }
            else if (faceType == FaceType.Down)
            {
                if (facie.Position == FaciePositionType.MiddleUp)
                {
                    facie.Position = FaciePositionType.LeftMiddle;
                }
                else if (facie.Position == FaciePositionType.RightUp)
                {
                    facie.Position = FaciePositionType.LeftDown;
                }
            }
            else if (faceType == FaceType.Left)
            {
                if (facie.Position == FaciePositionType.LeftUp)
                {
                    facie.Position = FaciePositionType.RightUp;
                }
                else if (facie.Position == FaciePositionType.LeftMiddle)
                {
                    facie.Position = FaciePositionType.MiddleUp;
                }
                else if (facie.Position == FaciePositionType.LeftDown)
                {
                    facie.Position = FaciePositionType.LeftUp;
                }
            }
            else if (faceType == FaceType.Right)
            {
                if (facie.Position == FaciePositionType.RightMiddle)
                {
                    facie.Position = FaciePositionType.MiddleUp;
                }
                else if (facie.Position == FaciePositionType.RightDown)
                {
                    facie.Position = FaciePositionType.LeftUp;
                }
            }
        }
    }
}
