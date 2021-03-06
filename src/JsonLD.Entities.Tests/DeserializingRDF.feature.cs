﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace JsonLD.Entities.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class DeserializingRDFDataIntoObjectsFeature : Xunit.IClassFixture<DeserializingRDFDataIntoObjectsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "DeserializingRDF.feature"
#line hidden
        
        public DeserializingRDFDataIntoObjectsFeature(DeserializingRDFDataIntoObjectsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Deserializing RDF data into objects", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Deserialize simple resource entity")]
        [Xunit.TraitAttribute("FeatureTitle", "Deserializing RDF data into objects")]
        [Xunit.TraitAttribute("Description", "Deserialize simple resource entity")]
        [Xunit.TraitAttribute("Category", "NQuads")]
        public virtual void DeserializeSimpleResourceEntity()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deserialize simple resource entity", null, new string[] {
                        "NQuads"});
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 5
    testRunner.Given("NQuads:", @"<http://example.com/Person> <http://www.w3.org/1999/02/22-rdf-syntax-ns#type> <http://example.com/ontology#Person> .
<http://example.com/Person> <http://xmlns.com/foaf/0.1/givenName> ""Tomasz"" .
<http://example.com/Person> <http://xmlns.com/foaf/0.1/familyName> ""Pluskiewicz"" .
<http://example.com/Person> <http://example.com/ontology#dateOfBirth> ""1975-08-15"" .", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 12
    testRunner.And("@context is:", "{\r\n    foaf: \"http://xmlns.com/foaf/0.1/\",\r\n    name: \"foaf:givenName\",\r\n    surn" +
                    "ame: \"foaf:familyName\",\r\n    birthDate: \"http://example.com/ontology#dateOfBirth" +
                    "\"\r\n}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
    testRunner.When("I deserialize into \'JsonLD.Entities.Tests.Entities.Person\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
    testRunner.Then("object should have property \'Name\' equal to \'Tomasz\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
    testRunner.And("object should have property \'Surname\' equal to \'Pluskiewicz\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
    testRunner.And("object should have DateTime property \'BirthDate\' equal to \'15-08-1975\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Deserialize single element list into collection")]
        [Xunit.TraitAttribute("FeatureTitle", "Deserializing RDF data into objects")]
        [Xunit.TraitAttribute("Description", "Deserialize single element list into collection")]
        [Xunit.TraitAttribute("Category", "NQuads")]
        [Xunit.InlineDataAttribute("JsonLD.Entities.Tests.Entities.HasInterestsList", new string[0])]
        public virtual void DeserializeSingleElementListIntoCollection(string type, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "NQuads"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deserialize single element list into collection", null, @__tags);
#line 27
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 28
    testRunner.Given("NQuads:", "<http://example.com/Person> <http://xmlns.com/foaf/0.1/topic_interest> _:list .\r\n" +
                    "_:list <http://www.w3.org/1999/02/22-rdf-syntax-ns#first> \"RDF\" .\r\n_:list <http:" +
                    "//www.w3.org/1999/02/22-rdf-syntax-ns#rest> <http://www.w3.org/1999/02/22-rdf-sy" +
                    "ntax-ns#nil> .", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 34
    testRunner.And("@context is:", "{\r\n    \"foaf\": \"http://xmlns.com/foaf/0.1/\",\r\n    \"interests\": { \"@id\": \"foaf:top" +
                    "ic_interest\", \"@container\": \"@list\" }\r\n}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
    testRunner.When(string.Format("I deserialize into \'{0}\'", type), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
    testRunner.Then("object should have property \'Interests\' containg string \'RDF\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Deserialize single element into collection")]
        [Xunit.TraitAttribute("FeatureTitle", "Deserializing RDF data into objects")]
        [Xunit.TraitAttribute("Description", "Deserialize single element into collection")]
        [Xunit.TraitAttribute("Category", "NQuads")]
        [Xunit.InlineDataAttribute("JsonLD.Entities.Tests.Entities.HasInterestsArray", new string[0])]
        [Xunit.InlineDataAttribute("JsonLD.Entities.Tests.Entities.HasInterestsEnumerable", new string[0])]
        [Xunit.InlineDataAttribute("JsonLD.Entities.Tests.Entities.HasInterestsCollection", new string[0])]
        [Xunit.InlineDataAttribute("JsonLD.Entities.Tests.Entities.HasInterestsSet", new string[0])]
        public virtual void DeserializeSingleElementIntoCollection(string type, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "NQuads"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deserialize single element into collection", null, @__tags);
#line 48
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
#line 49
    testRunner.Given("NQuads:", "<http://example.com/Person> <http://xmlns.com/foaf/0.1/topic_interest> \"RDF\" .", ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 53
    testRunner.And("@context is:", "{\r\n    \"foaf\": \"http://xmlns.com/foaf/0.1/\",\r\n    \"interests\": { \"@id\": \"foaf:top" +
                    "ic_interest\", \"@container\": \"@set\" }\r\n}", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
    testRunner.When(string.Format("I deserialize into \'{0}\'", type), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
    testRunner.Then("object should have property \'Interests\' containg string \'RDF\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                DeserializingRDFDataIntoObjectsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                DeserializingRDFDataIntoObjectsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
