using System;
using System.Collections.Generic;
using RubiksCube.Core;
using RubiksCube.Core.Model;

namespace RubiksCube.Solvers
{
    public partial class FriedrichSolver
    {
        private class WhiteCross
        {
            private readonly IDictionary<EdgePosition, string> moves;

            public WhiteCross()
            {
                moves = new Dictionary<EdgePosition, string>();

                AddLeftFaceMoves();
                AddRightFaceMoves();
                AddBackFaceMoves();
                AddDownFaceMoves();
                AddUpFaceMoves();
            }

            private void AddUpFaceMoves()
            {
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Blue, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Green, FaciePositionType.MiddleDown), "");
                moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Orange, FaciePositionType.MiddleDown), "U' F R' F'");
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Red, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Yellow, FaciePositionType.MiddleDown), "");

                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Blue, FaciePositionType.LeftMiddle), "");
                moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Green, FaciePositionType.LeftMiddle), "L");
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Orange, FaciePositionType.LeftMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Red, FaciePositionType.LeftMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Yellow, FaciePositionType.LeftMiddle), "");

                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Blue, FaciePositionType.MiddleUp), "");
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Green, FaciePositionType.MiddleUp), "");
                moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Orange, FaciePositionType.MiddleUp), "U F R' F'");
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Red, FaciePositionType.MiddleUp), "");
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Yellow, FaciePositionType.MiddleUp), "");

                moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Blue, FaciePositionType.RightMiddle), "R'");
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Green, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Orange, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Red, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Up, Color.White, Color.Yellow, FaciePositionType.RightMiddle), "");
            }

            private void AddDownFaceMoves()
            {
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Blue, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Green, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Orange, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Red, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Yellow, FaciePositionType.MiddleDown), "");

                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Blue, FaciePositionType.LeftMiddle), "");
                moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Green, FaciePositionType.LeftMiddle), "L'");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Orange, FaciePositionType.LeftMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Red, FaciePositionType.LeftMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Yellow, FaciePositionType.LeftMiddle), "");

                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Blue, FaciePositionType.MiddleUp), "");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Green, FaciePositionType.MiddleUp), "");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Orange, FaciePositionType.MiddleUp), "");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Red, FaciePositionType.MiddleUp), "");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Yellow, FaciePositionType.MiddleUp), "");

                moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Blue, FaciePositionType.RightMiddle), "R");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Green, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Orange, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Red, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Down, Color.White, Color.Yellow, FaciePositionType.RightMiddle), "");
            }

            private void AddBackFaceMoves()
            {
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Blue, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Green, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Orange, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Red, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Yellow, FaciePositionType.MiddleDown), "");

                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Blue, FaciePositionType.LeftMiddle), "");
                moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Green, FaciePositionType.LeftMiddle), "L2");
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Orange, FaciePositionType.LeftMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Red, FaciePositionType.LeftMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Yellow, FaciePositionType.LeftMiddle), "");

                moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Blue, FaciePositionType.MiddleUp), "R' D' B' D R2");
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Green, FaciePositionType.MiddleUp), "");
                moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Orange, FaciePositionType.MiddleUp), "U2");
                moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Red, FaciePositionType.MiddleUp), "D2");
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Yellow, FaciePositionType.MiddleUp), "");

                moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Blue, FaciePositionType.RightMiddle), "R2");
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Green, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Orange, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Red, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Back, Color.White, Color.Yellow, FaciePositionType.RightMiddle), "");
            }

            private void AddRightFaceMoves()
            {
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Blue, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Green, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Orange, FaciePositionType.MiddleDown), "");
                moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Red, FaciePositionType.MiddleDown), "D'");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Yellow, FaciePositionType.MiddleDown), "");

                moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Blue, FaciePositionType.LeftMiddle), "R F' U F");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Green, FaciePositionType.LeftMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Orange, FaciePositionType.LeftMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Red, FaciePositionType.LeftMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Yellow, FaciePositionType.LeftMiddle), "");

                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Blue, FaciePositionType.MiddleUp), "");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Green, FaciePositionType.MiddleUp), "");
                moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Orange, FaciePositionType.MiddleUp), "U");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Red, FaciePositionType.MiddleUp), "");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Yellow, FaciePositionType.MiddleUp), "");

                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Blue, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Green, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Orange, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Red, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Right, Color.White, Color.Yellow, FaciePositionType.RightMiddle), "");
            }

            private void AddLeftFaceMoves()
            {
                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Blue, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Green, FaciePositionType.MiddleDown), "");
                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Orange, FaciePositionType.MiddleDown), "");
                moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Red, FaciePositionType.MiddleDown), "D");
                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Yellow, FaciePositionType.MiddleDown), "");

                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Blue, FaciePositionType.LeftMiddle), "");
                moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Green, FaciePositionType.LeftMiddle), "L' D' B' D L2");
                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Orange, FaciePositionType.LeftMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Red, FaciePositionType.LeftMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Yellow, FaciePositionType.LeftMiddle), "");

                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Blue, FaciePositionType.MiddleUp), "");
                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Green, FaciePositionType.MiddleUp), "");
                moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Orange, FaciePositionType.MiddleUp), "U'");
                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Red, FaciePositionType.MiddleUp), "");
                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Yellow, FaciePositionType.MiddleUp), "");

                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Blue, FaciePositionType.RightMiddle), "");
                moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Green, FaciePositionType.RightMiddle), "L D' B' D L2");
                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Orange, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Red, FaciePositionType.RightMiddle), "");
                // moves.Add(new EdgePosition(FaceType.Left, Color.White, Color.Yellow, FaciePositionType.RightMiddle), "");
            }

            public void Solve(ICube cube)
            {
                var positions = cube.GetEdgePositions(Color.White, new[] { FaceType.Back, FaceType.Down, FaceType.Left, FaceType.Right, FaceType.Up });
                foreach (var position in positions)
                {
                    if (!moves.ContainsKey(position))
                    {
                        Console.WriteLine("Failed to resolve {0} {1} edge at position {2} on {3} face.", position.Item2, position.Item3, position.Item4, position.Item1);

                        continue;
                    }

                    var algorythm = moves[position];
                    var rotations = MoveInterpretor.Interpret(algorythm);
                    foreach (var rotation in rotations)
                    {
                        cube.Rotate(rotation);
                    }
                }
            }
        }
    }
}
