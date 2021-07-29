using NUnit.Framework;
using ControlFlow;
using System;

namespace ControlFlowUnitTest
{
    public class StoneTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(14, 0)]
        [TestCase(140,0)]
        [TestCase(144, 4)]
        [TestCase(200, 4)]
        [TestCase(280, 0)]
        [TestCase(300, 6)]
        public void GivenWholeNumberPounds_GetPounds_ReturnsExpectedValue(int totalPounds, int expectedRemainingPounds)
        {
            Assert.That(Method.GetPounds(totalPounds), Is.EqualTo(expectedRemainingPounds));
        }

        [TestCase(14, 1)]
        [TestCase(140,10)]
        [TestCase(144, 10)]
        [TestCase(200, 14)]
        [TestCase(280, 20)]
        [TestCase(300, 21)]
        public void GivenNumberOfPounds_GetStones_ReturnsExpectedValue(int totalPounds, int expectedRemainingPounds)
        {
            Assert.That(Method.GetStones(totalPounds), Is.EqualTo(expectedRemainingPounds));
        }

        [TestCase(64, "Fail")]
        [TestCase(65,"Pass")]
        [TestCase(84, "Pass")]
        [TestCase(85, "Distinction")]
        [TestCase(100, "Distinction")]
        
        public void GivenAMark_GetMarkClassification_ReturnsExpectedOutcome(int mark, string expectedOutcome)
        {
            Assert.That(Method.GetMarkClassicfication(mark), Is.EqualTo(expectedOutcome));
        }

        [TestCase(-1)]
        [TestCase(-20)]
        public void GivenAMassOfLessThan0_GetPounds_ReturnsArgumentOutOfRangeExceptions(int pounds)
        {
            Assert.That(() => Method.GetPounds(pounds),
                Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Cannot be less than 0."));
        }

        [TestCase(-1)]
        [TestCase(-22)]
        public void GivenAMassOfLessThan0_GetStones_ReturnsArgumentOutOfRangeExceptions(int stones)
        {
            Assert.That(() => Method.GetStones(stones),
                Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Cannot be less than 0."));
        }
    }
}
