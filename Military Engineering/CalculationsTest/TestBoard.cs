using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculationsCore.FortificationBuilding;
using CalculationsCore.FortificationBuilding.BuildingConditions;
using CalculationsCore.FortificationBuilding.BuildingAbilities;

namespace CalculationsTest
{
    [TestClass]
    public class TestBoard
    {
        public FortificationBoard Board {  get; set; }
        public BuildingCalculation Calc {  get; set; }
        [TestInitialize]
        public void Setup()
        {
            // Given
            var element = new BuildingElement();
            element.FirstTurn = 275;
            element.SecondTurn = 1279;

            var dayAbility = new DayAbility();
            dayAbility.PeopleAmount = 50;
            dayAbility.ManPower = 0.95;
            dayAbility.AttritionRate = 1;
            dayAbility.Organization = 0.9;
            dayAbility.WorkTime = 10;
            //dayAbility.BuildingGain = new Gain() { HumanEquivalent = 80 };

            Calc = new BuildingCalculation(element);
            Calc.DayTime = DayTime.DayNight;
            Calc.Pollution = FieldPollution.Purely;
            Calc.Soil = SoilType.Medium;
            Calc.Ability = dayAbility;
            Board = new FortificationBoard();
        }
        [TestMethod]
        public void TestInsert()
        {
            // when
            var ind = Board.AddElement(Calc);

            // then
            Assert.AreEqual(Calc, Board.GetElement(ind)); 
        }

        [TestMethod]
        public void TestDelete()
        {
            // when
            var ind = Board.AddElement(Calc);
            Board.DeleteElement(ind);

            //then
            Assert.AreEqual(0, Board.GetCalculationsNumber());
        }

        [TestMethod]
        public void TestConditionChange()
        {
            // when
            var ind = Board.AddElement(Calc);
            Board.UpdateElementCondition(1, DayTime.Night);

            //then
            Assert.AreEqual(DayTime.Night, Board.GetElement(ind).DayTime);
        }

        [TestMethod]
        public void TestAbilityChange()
        {
            // when
            var ind = Board.AddElement(Calc);
            Board.UpdateElementAbility(1, 80, AbilityType.PeopleAmount);

            //then
            Assert.AreEqual(80, Board.GetElement(ind).Ability.PeopleAmount);
        }
    }
}
