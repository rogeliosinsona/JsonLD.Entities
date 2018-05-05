﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Deserializing RDF data into objects")]
    public partial class DeserializingRDFDataIntoObjectsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DeserializingRDF.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Deserializing RDF data into objects", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("Deserialize simple resource entity")]
        [NUnit.Framework.CategoryAttribute("NQuads")]
        public virtual void DeserializeSimpleResourceEntity()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deserialize simple resource entity", new string[] {
                        "NQuads"});
#line 4
this.ScenarioSetup(scenarioInfo);
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deserialize single element list into collection")]
        [NUnit.Framework.CategoryAttribute("NQuads")]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsList", null)]
        public virtual void DeserializeSingleElementListIntoCollection(string type, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "NQuads"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deserialize single element list into collection", @__tags);
#line 27
this.ScenarioSetup(scenarioInfo);
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deserialize single element into collection")]
        [NUnit.Framework.CategoryAttribute("NQuads")]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsArray", null)]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsEnumerable", null)]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsCollection", null)]
        [NUnit.Framework.TestCaseAttribute("JsonLD.Entities.Tests.Entities.HasInterestsSet", null)]
        public virtual void DeserializeSingleElementIntoCollection(string type, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "NQuads"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deserialize single element into collection", @__tags);
#line 48
this.ScenarioSetup(scenarioInfo);
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
    }
}
#pragma warning restore
#endregion
