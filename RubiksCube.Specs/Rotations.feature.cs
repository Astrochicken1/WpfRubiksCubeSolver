﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace RubiksCube.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Rotations")]
    public partial class RotationsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Rotations.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Rotations", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Face Rotations")]
        [NUnit.Framework.TestCaseAttribute("Right", "1", "Green", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Up", "1", "Red", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Left", "1", "Blue", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Down", "1", "Orange", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Right", "2", "Yellow", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Up", "2", "Yellow", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Left", "2", "Yellow", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Down", "2", "Yellow", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Right", "3", "Blue", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Up", "3", "Orange", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Left", "3", "Green", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Down", "3", "Red", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Right", "4", "White", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Up", "4", "White", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Left", "4", "White", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Down", "4", "White", new string[0])]
        public virtual void FaceRotations(string direction, string times, string expected_Color, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Face Rotations", exampleTags);
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given("a cube with a visible \"White\" face", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.When(string.Format("the cube turns \"{0}\" {1} times", direction, times), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 6
 testRunner.Then(string.Format("the \"{0}\" face is visible", expected_Color), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Row Rotations")]
        [NUnit.Framework.TestCaseAttribute("1", "Right", "1", "Green", new string[0])]
        [NUnit.Framework.TestCaseAttribute("1", "Left", "1", "Blue", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", "Right", "1", "Green", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", "Left", "1", "Blue", new string[0])]
        [NUnit.Framework.TestCaseAttribute("3", "Right", "1", "Green", new string[0])]
        [NUnit.Framework.TestCaseAttribute("3", "Left", "1", "Blue", new string[0])]
        [NUnit.Framework.TestCaseAttribute("1", "Right", "2", "Yellow", new string[0])]
        [NUnit.Framework.TestCaseAttribute("1", "Left", "2", "Yellow", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", "Right", "2", "Yellow", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", "Left", "2", "Yellow", new string[0])]
        [NUnit.Framework.TestCaseAttribute("3", "Right", "2", "Yellow", new string[0])]
        [NUnit.Framework.TestCaseAttribute("3", "Left", "2", "Yellow", new string[0])]
        [NUnit.Framework.TestCaseAttribute("1", "Right", "3", "Blue", new string[0])]
        [NUnit.Framework.TestCaseAttribute("1", "Left", "3", "Green", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", "Right", "3", "Blue", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", "Left", "3", "Green", new string[0])]
        [NUnit.Framework.TestCaseAttribute("3", "Right", "3", "Blue", new string[0])]
        [NUnit.Framework.TestCaseAttribute("3", "Left", "3", "Green", new string[0])]
        [NUnit.Framework.TestCaseAttribute("1", "Right", "4", "White", new string[0])]
        [NUnit.Framework.TestCaseAttribute("1", "Left", "4", "White", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", "Right", "4", "White", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", "Left", "4", "White", new string[0])]
        [NUnit.Framework.TestCaseAttribute("3", "Right", "4", "White", new string[0])]
        [NUnit.Framework.TestCaseAttribute("3", "Left", "4", "White", new string[0])]
        public virtual void RowRotations(string position, string direction, string times, string expected_Color, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Row Rotations", exampleTags);
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
 testRunner.Given("a cube with a visible \"White\" face", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
 testRunner.When(string.Format("row {0} turns \"{1}\" {2} times", position, direction, times), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.Then(string.Format("row {0} is \"{1}\"", position, expected_Color), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
