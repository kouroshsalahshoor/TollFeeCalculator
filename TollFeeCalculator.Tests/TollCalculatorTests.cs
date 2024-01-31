using static TollFeeCalculator.TollCalculator;

namespace TollFeeCalculator.Tests
{
    public class TollCalculatorTests
    {
        [Fact]
        public void ShouldReturnZeroForMotorbike()
        {
            //arange
            var calc = new TollCalculator();

            var monday6Am = new DateTime(year: 2024, month: 1, day: 1, hour: 6, minute: 0, second: 0);

            //act
            var feeMotorbike = calc.GetTollFee(monday6Am, new Motorbike());

            //assert
            Assert.Equal(0, feeMotorbike);
        }

        [Fact]
        public void ShouldReturnZeroForHolidays()
        {
            //arange
            var calc = new TollCalculator();

            var saturday6Am = new DateTime(year: 2024, month: 1, day: 6, hour: 0, minute: 0, second: 0);
            var sunday6Am = new DateTime(year: 2024, month: 1, day: 7, hour: 0, minute: 0, second: 0);

            var car = new Car();

            //act

            var feeSaturday = calc.GetTollFee(saturday6Am, car);
            var feeSunday = calc.GetTollFee(sunday6Am, car);

            //assert
            Assert.Equal(0, feeSaturday);
            Assert.Equal(0, feeSunday);
        }
    }
}