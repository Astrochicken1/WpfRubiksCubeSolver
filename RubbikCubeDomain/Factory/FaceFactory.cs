﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using RubiksCube.Entity;
using RubiksCube.Enums;

namespace RubiksCube.Factory
{
    public interface IFaceFactory
    {
        Face CreateFace(FaceType type);
    }

    public class FaceFactory : IFaceFactory
    {
        public Face CreateFace(FaceType type)
        {
            switch (type)
            {
                case FaceType.Front:
                    return CreateFace(type, Colors.Red);
                case FaceType.Top:
                    return CreateFace(type, Colors.Blue);
                case FaceType.Bottom:
                    return CreateFace(type, Colors.Green);
                case FaceType.Left:
                    return CreateFace(type, Colors.White);
                case FaceType.Right:
                    return CreateFace(type, Colors.Yellow);
                case FaceType.Back:
                    return CreateFace(type, Colors.Orange);
            }

            return null;
        }

        private static Face CreateFace(FaceType faceType, Color color)
        {
            return new Face
            {
                Type = faceType, 
                Color = color,
                Facies = new List<Face> {
                    CreateSubFace(faceType, FaciePositionType.Middle, color),        
                    CreateSubFace(faceType, FaciePositionType.MiddleTop, color),        
                    CreateSubFace(faceType, FaciePositionType.MiddleBottom, color),        
                    CreateSubFace(faceType, FaciePositionType.RightMiddle, color),        
                    CreateSubFace(faceType, FaciePositionType.RightTop, color),        
                    CreateSubFace(faceType, FaciePositionType.RightBottom, color),        
                    CreateSubFace(faceType, FaciePositionType.LeftMiddle, color),        
                    CreateSubFace(faceType, FaciePositionType.LeftTop, color),        
                    CreateSubFace(faceType, FaciePositionType.LeftBottom, color)
                }
            };
        }

        private static Face CreateSubFace(FaceType faceType, FaciePositionType faciePositionType, Color color)
        {
            return new Face
            {
                Key = String.Format("{0}{1}", faceType, faciePositionType),
                Type = faceType,
                Color = color,
                FaciePositionType = faciePositionType
            };
        }
    }
}