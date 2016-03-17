﻿using RubiksCube.Entity;
using RubiksCube.Service;
using TechTalk.SpecFlow;
using NUnit.Framework;
using RubiksCube.Factory;

namespace RubiksCube.Specs
{
    [Binding]
    public class RotationsSteps
    {
        private Cube cube;
        private CubeService cubeService;

        [Given(@"a cube with a visible ""(.*)"" face")]
        public void GivenACubeWithAVisableFace(string visibleColor)
        {
            var cubeFactory = new CubeFactory();
            cube = cubeFactory.Create();
            cubeService = new CubeService();
        }
        
        [When(@"the cube turns ""(.*)"" (.*) times")]
        public void WhenTheCubeTurns(string direction, uint times)
        {
            var rotation = new Rotation(direction, times);
            cubeService.Rotate(cube, rotation);
        }
        
        [Then(@"then the ""(.*)"" face is visible")]
        public void ThenThenTheFaceIsVisible(string visibleColor)
        {
            foreach (var facie in cube.FrontFace.Facies)
            {
                Assert.AreEqual(facie.ColorName, visibleColor);    
            }
        }
    }
}
