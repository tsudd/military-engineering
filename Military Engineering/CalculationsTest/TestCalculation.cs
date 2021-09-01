using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculationsCore.FortificationBuilding;
using CalculationsCore.FortificationBuilding.BuildingConditions;
using CalculationsCore.FortificationBuilding.BuildingAbilities;

namespace CalculationsTest
{
    [TestClass]
    public class TestCalculation
    {
        [TestMethod]
        public void TestDayAbility()
        {
            // Given
            var dayAbility = new DayAbility();
            dayAbility.PeopleAmount = 50;
            dayAbility.ManPower = 0.95;
            dayAbility.AttritionRate = 1;
            dayAbility.Organization = 0.9;
            dayAbility.WorkTime = 10;
            dayAbility.BuildingGain = new Gain() { HumanEquivalent = 80 };

            // When
            var ability = dayAbility.Evaluate();

            ///then
            Assert.AreEqual(507.5, ability);
        }

        [TestMethod]
        public void TestTurns()
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
            dayAbility.BuildingGain = new Gain() { HumanEquivalent = 80 };

            var calc = new BuildingCalculation(element);
            calc.DayTime = DayTime.DayNight;
            calc.Pollution = FieldPollution.Purely;
            calc.Soil = SoilType.Medium;
            calc.Ability = dayAbility;

            // When
            var firstTurn = calc.EvaluateFirstTurn();
            var secondTurn = calc.EvaluateSecondTurn();
            var futureTurn = calc.EvaluateFutureTurn();
            var allTurns = calc.EvaluateAllTurns();

            //Then
            Assert.AreEqual(0.6, firstTurn);
            Assert.AreEqual(3, secondTurn);
            Assert.AreEqual(0, futureTurn);
            Assert.AreEqual(3.6, allTurns);
        }
    }
}
