﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using RubiksCube.Core;
using RubiksCube.Core.Model;
using Point = System.Windows.Point;

namespace RubiksCube.UI
{
    public partial class RubiksCubeControl : IDisposable
    {
        private readonly IPositionsFactory positionsFactory;
        private readonly IRubiksCubeSolver cubeSolver;
        private readonly AnimationEngine movementEngine;
        private Cube cube;
        private bool disposed;

        public RubiksCubeControl()
        {
            cubeSolver = new RubiksCubeSolver();
            positionsFactory = new PositionsFactory();
            movementEngine = new AnimationEngine();

            DataContext = this;

            InitializeComponent();
            Initialize();

            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            movementEngine.Start();    
        }

        public void RotateRowRight(RotationType type)
        {
            var rotation = new Rotation(Rotation.Right, Math.PI / 4, type);
            var movements = cube.Rotate(rotation);
            Rotate(movements);
        }

        public void RotateRowLeft(RotationType type)
        {
            var rotation = new Rotation(Rotation.Left, Math.PI / 4, type);
            var movements = cube.Rotate(rotation);
            Rotate(movements);
        }

        public void RotateColumnUp(RotationType type)
        {
            var rotation = new Rotation(Rotation.Up, Math.PI / 4, type);
            var movements = cube.Rotate(rotation);
            Rotate(movements);
        }

        public void RotateColumnDown(RotationType type)
        {
            var rotation = new Rotation(Rotation.Down, Math.PI / 4, type);
            var movements = cube.Rotate(rotation);
            Rotate(movements);
        }

        public void RotateLeft()
        {
            var rotation = new Rotation(Rotation.Left, Math.PI / 4);
            var movements = cube.Rotate(rotation);
            Rotate(movements);
        }

        public void RotateRight()
        {
            var rotation = new Rotation(Rotation.Right, Math.PI / 4);
            var movements = cube.Rotate(rotation);
            Rotate(movements);
        }

        public void RotateUp()
        {
            var rotation = new Rotation(Rotation.Up, Math.PI / 4);
            var movements = cube.Rotate(rotation);
            Rotate(movements);
        }

        public void RotateDown()
        {
            var rotation = new Rotation(Rotation.Down, Math.PI / 4);
            var movements = cube.Rotate(rotation);
            Rotate(movements);
        }

        public void MixUp()
        {
            var actions = new Action[]
            {
                () => RotateRowRight(RotationType.First),
                () => RotateRowRight(RotationType.Second),
                () => RotateRowRight(RotationType.Third),
                () => RotateRowLeft(RotationType.First),
                () => RotateRowLeft(RotationType.Second),
                () => RotateRowLeft(RotationType.Third),
                () => RotateColumnUp(RotationType.First),
                () => RotateColumnUp(RotationType.Second),
                () => RotateColumnUp(RotationType.Third),
                () => RotateColumnDown(RotationType.First),
                () => RotateColumnDown(RotationType.Second),
                () => RotateColumnDown(RotationType.Third)
            };

            var random = new Random();
            for(var i = 0; i < 50; i++)
            {
                var index = random.Next(0, actions.Count());
                actions[index]();
            }
        }

        public void Resolve()
        {
            cubeSolver.Rotations -= OnRotations;
            cubeSolver.Rotations += OnRotations;
            cubeSolver.Solve(cube);
        }

        private void OnRotations(object sender, RotationsArgs e)
        {
            foreach(var rotation in e.Rotations)
            {
                var newRotation = new Rotation(rotation.Direction, (rotation.Angle > 0 ? 1 : -1) * (Math.PI / 4), rotation.Times * 2, rotation.Type);

                var movements = cube.Rotate(newRotation);
                Rotate(movements);
            }
        }

        private void Rotate(IEnumerable<List<Facie>> items)
        {
            var center = GetCenter(false);
            var negateCenter = GetCenter(true);

            foreach (var facies in items)
            {
                var animations = new FacieAnimation(center, negateCenter);
                foreach (var facie in facies)
                {
                    var geometry = group.Children.FirstOrDefault(x => x.GetValue(NameProperty).ToString() == facie.Key);
                    if (geometry != null)
                    {
                        animations.Add(facie, geometry);
                    }
                }

                movementEngine.BeginAnimation(animations);
            }
        }

        private void Initialize()
        {
            group.Children.Clear();

            InitializeFace(cube.FrontFace);
            InitializeFace(cube.LeftFace);
            InitializeFace(cube.RightFace);
            InitializeFace(cube.BottomFace);
            InitializeFace(cube.TopFace);
            InitializeFace(cube.BackFace);
        }

        private void InitializeFace(Face face)
        {
            foreach (var facie in face.Facies)
            {
                var shape = CreateFacie(facie, face.Type);
                group.Children.Add(shape);
            }
        }

        private GeometryModel3D CreateFacie(Facie facie, FaceType type)
        {
            var label = new Label
            {
                Background = new SolidColorBrush(ColorMapper.Map(facie.Color)),
                BorderBrush = new SolidColorBrush(Colors.Black),
                BorderThickness = new Thickness(0.3)
            };

            var positions = positionsFactory.CreatePositions(type);

            var geometry = new GeometryModel3D
            {
                Geometry = new MeshGeometry3D
                {
                    Positions = CreatePoints(positions, facie.FaciePosition),
                    TriangleIndices = new Int32Collection { 2, 1, 3, 2, 0, 1 },
                    TextureCoordinates = new PointCollection { new Point(-0.5, -0.5), new Point(0.5, -0.5), new Point(-0.5, 0.5), new Point(0.5, 0.5) }
                },
                Material = new DiffuseMaterial(new VisualBrush
                {
                    Visual = label
                })
            };

            geometry.SetValue(NameProperty, facie.Key);

            return geometry;
        }

        private static Point3DCollection CreatePoints(IDictionary<FaciePositionType, string> positions, FaciePositionType positionType)
        {
            var points = new Point3DCollection();

            var position = System.Text.RegularExpressions.Regex.Split(positions[positionType], @"\s{2}");

            for (var i = 0; i < position.Length; i++)
            {
                var values = position[i].Split(' ');

                var point = new Point3D(
                    Convert.ToDouble(values[0]),
                    Convert.ToDouble(values[1]),
                    Convert.ToDouble(values[2])
                );

                points.Add(point);
            }

            return points;
        }

        private Vector3D GetCenter(bool isNegate)
        {
            var bounds = group.Bounds;
            var center = new Vector3D(bounds.X + (bounds.SizeX / 2),
                                      bounds.Y + (bounds.SizeY / 2),
                                      bounds.Z + (bounds.SizeZ / 2));
            if (isNegate)
            {
                center.Negate();
            }

            return center;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    movementEngine.Stop();
                    cubeSolver.Rotations -= OnRotations;
                }

                disposed = true;
            }
        }

        ~RubiksCubeControl()
        {
            Dispose(false);
        }
    }
}