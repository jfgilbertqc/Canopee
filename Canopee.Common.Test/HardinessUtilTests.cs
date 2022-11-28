using Canopee.Common.Utilities;

using FluentAssertions;

namespace Canopee.Common.Test
{
    public class HardinessUtilTests
    {
        [Fact]
        public void GetHardinessFromString_WithSubZoneA_ShouldConvert()
        {
            var value = HardinessUtil.GetHardinessFromString("1a");

            value.Should().Be(1.5f);
        }

        [Fact]
        public void GetHardinessFromString_WithSubZoneB_ShouldConvert()
        {
            var value = HardinessUtil.GetHardinessFromString("1b");

            value.Should().Be(1.0f);
        }

        [Fact]
        public void GetHardinessFromString_WithOutOfEnumValue_ShouldThrowException()
        {
            Action act = () => HardinessUtil.GetHardinessFromString("12");

            act.Should().Throw<Exception>();
        }

        [Fact]
        public void GetHardinessFromString_WithEmptyValue_ShouldThrowException()
        {
            Action act = () => HardinessUtil.GetHardinessFromString("");

            act.Should().Throw<Exception>();
        }

        [Fact]
        public void GetHardinessFromEnum_WithEnumValue_ShouldReturnHardiness()
        {
            var value = HardinessUtil.GetHardinessFromEnum(DataTransferObjects.TreeEnums.HardinessZone.FiveA);
            value.Should().Be(5.5f);
        }
    }
}