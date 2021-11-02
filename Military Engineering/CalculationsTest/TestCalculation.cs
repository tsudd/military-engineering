using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculationsCore.FortificationBuilding;
using CalculationsCore.FortificationBuilding.BuildingConditions;
using CalculationsCore.FortificationBuilding.BuildingAbilities;
using System;

namespace CalculationsTest
{
    [TestClass]
    public class TestCalculation
    {
        public BuildingCalculation Calc { get; set; }
        public DayAbility Ability { get; set; }
        public BuildingElement Element { get; set; }
        [TestInitialize]
        public void Setup()
        {
            // Given
            var element = new BuildingElement();
            element.FirstTurn = 275;
            element.SecondTurn = 1579;
            element.FutureTurn = 200;
            Element = element;

            var dayAbility = new DayAbility();
            dayAbility.PeopleAmount = 50;
            dayAbility.ManPower = 0.95;
            dayAbility.AttritionRate = 0.7;
            dayAbility.Organization = 0.9;
            dayAbility.WorkTime = 10;
            //dayAbility.BuildingGain = new Gain() { HumanEquivalent = 80 };
            Ability = dayAbility;

            Calc = new BuildingCalculation(element);
            Calc.DayTime = DayTime.DayNight;
            Calc.Pollution = FieldPollution.Purely;
            Calc.Soil = SoilType.Medium;
            Calc.Ability = dayAbility;
        }
        [TestMethod]
        public void TestDayAbilityWithNoGain()
        {

            // When
            var ability = Ability.Evaluate(new BuildingElement());

            ///then
            Assert.AreEqual(299.25, Math.Round(ability, 2));
        }

        [TestMethod]
        public void TestTurnsWithNoGain()
        {
            Calc.Ability = Ability;

            // When
            var firstTurn = Calc.EvaluateFirstTurn();
            var secondTurn = Calc.EvaluateSecondTurn();
            var futureTurn = Calc.EvaluateFutureTurn();
            var allTurns = Calc.EvaluateAllTurns();

            //Then
            Assert.AreEqual(1.08, firstTurn);
            Assert.AreEqual(6.21, secondTurn);
            Assert.AreEqual(0.79, futureTurn);
            Assert.AreEqual(8.08, allTurns);
        }

        [TestMethod]
        public void TestDayAbilityWithGain()
        {
            // Given
            Ability.BuildingGains.Add(new Gain() { TrenchPerformance = 500 });
            Ability.BuildingGains.Add(new Gain() { PitPerformance = 90, Amount = 3 });

            // when
            Element.ElementType = ElementTypes.Pit;
            var ability = Ability.Evaluate(Element);

            //then
            Assert.AreEqual(2729.25, ability);
        }
    }
}
