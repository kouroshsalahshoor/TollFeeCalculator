using static TollFeeCalculator.TollCalculator;

namespace TollFeeCalculator.Tests
{
    public class TollCalculatorTests
    {

        [Fact]
        public void ShouldGetMax60ForOneDay()
        {
            //arange
            var calc = new TollCalculator();

            var _0600 = new DateTime(year: 2024, month: 1, day: 3, hour: 6, minute: 0, second: 0);
            var _0701 = new DateTime(year: 2024, month: 1, day: 3, hour: 7, minute: 1, second: 0);
            var _0802 = new DateTime(year: 2024, month: 1, day: 3, hour: 8, minute: 2, second: 0);
            var _0903 = new DateTime(year: 2024, month: 1, day: 3, hour: 9, minute: 3, second: 0);
            var _1004 = new DateTime(year: 2024, month: 1, day: 3, hour: 10, minute: 4, second: 0);
            var _1105 = new DateTime(year: 2024, month: 1, day: 3, hour: 11, minute: 5, second: 0);
            var _1206 = new DateTime(year: 2024, month: 1, day: 3, hour: 12, minute: 6, second: 0);
            var _1307 = new DateTime(year: 2024, month: 1, day: 3, hour: 13, minute: 7, second: 0);
            var _1408 = new DateTime(year: 2024, month: 1, day: 3, hour: 14, minute: 8, second: 0);
            var _1509 = new DateTime(year: 2024, month: 1, day: 3, hour: 15, minute: 9, second: 0);
            var _1610 = new DateTime(year: 2024, month: 1, day: 3, hour: 16, minute: 10, second: 0);
            var _1711 = new DateTime(year: 2024, month: 1, day: 3, hour: 17, minute: 11, second: 0);
            var _1812 = new DateTime(year: 2024, month: 1, day: 3, hour: 18, minute: 12, second: 0);
            var _1913 = new DateTime(year: 2024, month: 1, day: 3, hour: 19, minute: 13, second: 0);

            var dateTimes = new DateTime[] { _0600, _0701, _0802, _0903, _1004, _1105, _1206, _1307, _1408, _1509, _1610, _1711, _1812, _1913 };

            //act
            var fee = calc.GetTollFee(new Car(), dateTimes);

            //assert
            Assert.Equal(60, fee);
        }

        [Fact]
        public void ShouldCalculateFeeCorrectly()
        {
            //arange
            var calc = new TollCalculator();

            var _0600 = new DateTime(year: 2024, month: 1, day: 3, hour: 6, minute: 0, second: 0);
            var _0629 = new DateTime(year: 2024, month: 1, day: 3, hour: 6, minute: 29, second: 0);

            var _0630 = new DateTime(year: 2024, month: 1, day: 3, hour: 6, minute: 30, second: 0);
            var _0659 = new DateTime(year: 2024, month: 1, day: 3, hour: 6, minute: 59, second: 0);

            var _0700 = new DateTime(year: 2024, month: 1, day: 3, hour: 7, minute: 0, second: 0);
            var _0759 = new DateTime(year: 2024, month: 1, day: 3, hour: 7, minute: 59, second: 0);

            var _0800 = new DateTime(year: 2024, month: 1, day: 3, hour: 8, minute: 0, second: 0);
            var _0829 = new DateTime(year: 2024, month: 1, day: 3, hour: 8, minute: 29, second: 0);

            var _0830 = new DateTime(year: 2024, month: 1, day: 3, hour: 8, minute:30, second: 0);
            var _1459 = new DateTime(year: 2024, month: 1, day: 3, hour: 14, minute: 59, second: 0);

            var _1500 = new DateTime(year: 2024, month: 1, day: 3, hour: 15, minute: 0, second: 0);
            var _1529 = new DateTime(year: 2024, month: 1, day: 3, hour: 15, minute: 29, second: 0);

            var _1530 = new DateTime(year: 2024, month: 1, day: 3, hour: 15, minute: 30, second: 0);
            var _1659 = new DateTime(year: 2024, month: 1, day: 3, hour: 16, minute: 59, second: 0);

            var _1730 = new DateTime(year: 2024, month: 1, day: 3, hour: 17, minute: 30, second: 0);
            var _1759 = new DateTime(year: 2024, month: 1, day: 3, hour: 17, minute: 59, second: 0);

            var _1800 = new DateTime(year: 2024, month: 1, day: 3, hour: 18, minute: 0, second: 0);
            var _1829 = new DateTime(year: 2024, month: 1, day: 3, hour: 18, minute: 29, second: 0);

            var _1830 = new DateTime(year: 2024, month: 1, day: 3, hour: 18, minute: 30, second: 0);
            var _0559 = new DateTime(year: 2024, month: 1, day: 3, hour: 5, minute: 59, second: 0);

            //act
            var fee0600 = calc.GetTollFee(_0600, new Car());
            var fee0629 = calc.GetTollFee(_0629, new Car());

            var fee0630 = calc.GetTollFee(_0630, new Car());
            var fee0659 = calc.GetTollFee(_0659, new Car());

            var fee0700 = calc.GetTollFee(_0700, new Car());
            var fee0759 = calc.GetTollFee(_0759, new Car());

            var fee0800 = calc.GetTollFee(_0800, new Car());
            var fee0829 = calc.GetTollFee(_0829, new Car());

            var fee0830 = calc.GetTollFee(_0830, new Car());
            var fee1459 = calc.GetTollFee(_1459, new Car());

            var fee1500 = calc.GetTollFee(_1500, new Car());
            var fee1529 = calc.GetTollFee(_1529, new Car());

            var fee1530 = calc.GetTollFee(_1530, new Car());
            var fee1659 = calc.GetTollFee(_1659, new Car());

            var fee1730 = calc.GetTollFee(_1730, new Car());
            var fee1759 = calc.GetTollFee(_1759, new Car());

            var fee1800 = calc.GetTollFee(_1800, new Car());
            var fee1829 = calc.GetTollFee(_1829, new Car());

            var fee1830 = calc.GetTollFee(_1830, new Car());
            var fee0559 = calc.GetTollFee(_0559, new Car());

            //assert
            Assert.Equal(8, fee0600);
            Assert.Equal(8, fee0629);

            Assert.Equal(13, fee0630);
            Assert.Equal(13, fee0659);

            Assert.Equal(18, fee0700);
            Assert.Equal(18, fee0759);

            Assert.Equal(13, fee0800);
            Assert.Equal(13, fee0829);

            Assert.Equal(8, fee0830);
            Assert.Equal(8, fee1459);

            Assert.Equal(13, fee1500);
            Assert.Equal(13, fee1529);

            Assert.Equal(18, fee1530);
            Assert.Equal(18, fee1659);

            Assert.Equal(13, fee1730);
            Assert.Equal(13, fee1759);

            Assert.Equal(8, fee1800);
            Assert.Equal(8, fee1829);

            Assert.Equal(0, fee1830);
            Assert.Equal(0, fee0559);
        }

        [Fact]
        public void ShouldCalculateFeeOnceIfIntervalLessThan60Minutes()
        {
            //arange
            var calc = new TollCalculator();

            var _0600 = new DateTime(year: 2024, month: 1, day: 3, hour: 6, minute: 0, second: 0);
            var _0610 = new DateTime(year: 2024, month: 1, day: 3, hour: 6, minute: 10, second: 0);

            var dateTimes = new DateTime[] { _0600, _0610 };

            //act
            var fee = calc.GetTollFee(new Car(), dateTimes);

            //assert
            Assert.Equal(8, fee);
        }

        [Fact]
        public void ShouldReturnZeroForJuly()
        {
            //arange
            var calc = new TollCalculator();

            var mondayFirstofJuly6Am = new DateTime(year: 2024, month: 7, day: 1, hour: 6, minute: 0, second: 0);

            //act
            var fee = calc.GetTollFee(mondayFirstofJuly6Am, new Car());

            //assert
            Assert.Equal(0, fee);
        }

        [Fact]
        public void ShouldReturnZeroForMotorbike()
        {
            //arange
            var calc = new TollCalculator();

            var monday6Am = new DateTime(year: 2024, month: 1, day: 1, hour: 6, minute: 0, second: 0);

            //act
            var fee = calc.GetTollFee(monday6Am, new Motorbike());

            //assert
            Assert.Equal(0, fee);
        }

        [Fact]
        public void ShouldReturnZero1830To0559()
        {
            //arange
            var calc = new TollCalculator();

            var five59Am = new DateTime(year: 2024, month: 1, day: 3, hour: 5, minute: 59, second: 0);
            var eighteen30Pm = new DateTime(year: 2024, month: 1, day: 3, hour: 18, minute: 30, second: 0);

            var car = new Car();

            //act

            var fee0559Am = calc.GetTollFee(five59Am, car);
            var fee1830Pm = calc.GetTollFee(eighteen30Pm, car);

            //assert
            Assert.Equal(0, fee0559Am);
            Assert.Equal(0, fee1830Pm);
        }

        [Fact]
        public void ShouldReturnZeroForHolidays()
        {
            //arange
            var calc = new TollCalculator();

            var saturday6Am = new DateTime(year: 2024, month: 1, day: 6, hour: 6, minute: 0, second: 0);
            var sunday6Am = new DateTime(year: 2024, month: 1, day: 7, hour: 6, minute: 0, second: 0);

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