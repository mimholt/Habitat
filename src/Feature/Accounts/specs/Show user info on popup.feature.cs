﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

#region Designer generated code


#pragma warning disable

namespace Habitat.Accounts.Specflow
{
  using TechTalk.SpecFlow;

  [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
  [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public partial class ShowUserInfoOnPopupFeature : Xunit.IUseFixture<ShowUserInfoOnPopupFeature.FixtureData>, System.IDisposable
  {
    private static TechTalk.SpecFlow.ITestRunner testRunner;

#line 1 "Show user info on popup.feature"
#line hidden

    public ShowUserInfoOnPopupFeature()
    {
      this.TestInitialize();
    }

    public static void FeatureSetup()
    {
      testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
      var featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Show user info on popup", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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

    public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
    {
      testRunner.OnScenarioStart(scenarioInfo);
    }

    public virtual void ScenarioCleanup()
    {
      testRunner.CollectScenarioErrors();
    }

    public virtual void SetFixture(ShowUserInfoOnPopupFeature.FixtureData fixtureData)
    {
    }

    void System.IDisposable.Dispose()
    {
      this.ScenarioTearDown();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Show user info on popup")]
    [Xunit.TraitAttribute("Description", "Account_Show user info on popup_UC1_Only email is shown")]
    public virtual void Account_ShowUserInfoOnPopup_UC1_OnlyEmailIsShown()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Show user info on popup_UC1_Only email is shown", new string[]
      {
        "NeedImplementation"
      });
#line 4
      this.ScenarioSetup(scenarioInfo);
#line 5
      testRunner.Given("Habitat website is opened on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
      var table1 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Password",
        "ConfirmPassword"
      });
      table1.AddRow(new string[]
      {
        "kov@sitecore.net",
        "k",
        "k"
      });
#line 6
      testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table1, "When ");
#line 9
      testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
      testRunner.And("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table2 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email"
      });
      table2.AddRow(new string[]
      {
        "kov@sitecore.net"
      });
#line 11
      testRunner.Then("User info is shown on User popup", ((string)(null)), table2, "Then ");
#line hidden
      this.ScenarioCleanup();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Show user info on popup")]
    [Xunit.TraitAttribute("Description", "Account_Show user info on popup_UC2_Full user info is shown")]
    public virtual void Account_ShowUserInfoOnPopup_UC2_FullUserInfoIsShown()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Show user info on popup_UC2_Full user info is shown", new string[]
      {
        "NeedImplementation"
      });
#line 17
      this.ScenarioSetup(scenarioInfo);
#line hidden
      var table3 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Password",
        "ConfirmPassword"
      });
      table3.AddRow(new string[]
      {
        "kov10@sitecore.net",
        "k",
        "k"
      });
#line 18
      testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table3, "Given ");
#line 21
      testRunner.When("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
      testRunner.And("User clicks Edit Profile from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table4 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Last Name",
        "First Name",
        "Phone number"
      });
      table4.AddRow(new string[]
      {
        "Teltov",
        "Konstantin",
        "+38(067)3333333"
      });
#line 23
      testRunner.And("User inputs data in to the fields", ((string)(null)), table4, "And ");
#line 26
      testRunner.And("User selects <Swiming> from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table5 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Name"
      });
      table5.AddRow(new string[]
      {
        "kov@sitecore.net",
        "Konstantin Teltov"
      });
#line 27
      testRunner.Then("User info is shown on User popup", ((string)(null)), table5, "Then ");
#line hidden
      this.ScenarioCleanup();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Show user info on popup")]
    [Xunit.TraitAttribute("Description", "Account_Show user info on popup_UC2_User Name with special symbols")]
    public virtual void Account_ShowUserInfoOnPopup_UC2_UserNameWithSpecialSymbols()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Show user info on popup_UC2_User Name with special symbols", new string[]
      {
        "NeedImplementation"
      });
#line 33
      this.ScenarioSetup(scenarioInfo);
#line hidden
      var table6 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Password",
        "ConfirmPassword"
      });
      table6.AddRow(new string[]
      {
        "kov10@sitecore.net",
        "k",
        "k"
      });
#line 34
      testRunner.Given("User with following data is registered in Habitat", ((string)(null)), table6, "Given ");
#line 37
      testRunner.When("Actor moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
      testRunner.And("User clicks Edit Profile from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table7 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Last Name",
        "First Name",
        "Phone number"
      });
      table7.AddRow(new string[]
      {
        "Teltov!@#$%^&?()-+*",
        "KONSTANTIN!@#$%^&?()-+*",
        "+38(067)3333333"
      });
#line 39
      testRunner.And("User inputs data in to the fields", ((string)(null)), table7, "And ");
#line 42
      testRunner.And("User selects <Swiming> from Interests drop-down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table8 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Name"
      });
      table8.AddRow(new string[]
      {
        "kov@sitecore.net",
        "Konstantin Teltov"
      });
#line 43
      testRunner.Then("User info is shown on User popup", ((string)(null)), table8, "Then ");
#line hidden
      this.ScenarioCleanup();
    }

    [Xunit.FactAttribute()]
    [Xunit.TraitAttribute("FeatureTitle", "Show user info on popup")]
    [Xunit.TraitAttribute("Description", "Account_Show user info on popup_Bug36103_Name label should dismiss if user has re" +
                                         "moved User Last Name and First Name")]
    public virtual void Account_ShowUserInfoOnPopup_Bug36103_NameLabelShouldDismissIfUserHasRemovedUserLastNameAndFirstName()
    {
      var scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Account_Show user info on popup_Bug36103_Name label should dismiss if user has re" +
                                                            "moved User Last Name and First Name", new string[]
                                                            {
                                                              "NeedImplementation"
                                                            });
#line 49
      this.ScenarioSetup(scenarioInfo);
#line hidden
      var table9 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email",
        "Password",
        "ConfirmPassword",
        "First name",
        "Last name"
      });
      table9.AddRow(new string[]
      {
        "kov@sitecore.net",
        "k",
        "k",
        "Konstantin",
        "Teltov"
      });
#line 50
      testRunner.Given("User with following data is registered in Habitat and logged in", ((string)(null)), table9, "Given ");
#line 53
      testRunner.When("User moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
      testRunner.And("User clicks Edit Profile from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
      testRunner.And("User clears data in <First name> and <Last name> fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
      testRunner.And("User clicks Update button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
      testRunner.And("When User moves cursor over the User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      var table10 = new TechTalk.SpecFlow.Table(new string[]
      {
        "Email"
      });
      table10.AddRow(new string[]
      {
        "kov@sitecore.net"
      });
#line 58
      testRunner.Then("User info is shown on User popup", ((string)(null)), table10, "Then ");
#line 61
      testRunner.And("Name label is no longer exists on the pop up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
      this.ScenarioCleanup();
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class FixtureData : System.IDisposable
    {
      public FixtureData()
      {
        FeatureSetup();
      }

      void System.IDisposable.Dispose()
      {
        FeatureTearDown();
      }
    }
  }
}

#pragma warning restore

#endregion