using IThermal;
using Xunit;

namespace IThermalTests
{
    public class InsulationTests
    {
        [Fact]
        public void HeatConversationTest()
        {
            Assert.Equal("M2-114", Insulation.Insulation4HeatConversation(300,330)); 
            Assert.Equal("F2-64", Insulation.Insulation4HeatConversation(150,200));
            Assert.Equal("F2-51", Insulation.Insulation4HeatConversation(1300, 30));
            Assert.Equal("-", Insulation.Insulation4HeatConversation(111, 30));
        }

        [Fact]
        public void PersonnelProtectionTest()
        {
            Assert.Equal("M3-64", Insulation.Insulation4PersonnelProtection(300, 330));
            Assert.Equal("F3-25", Insulation.Insulation4PersonnelProtection(150, 200));
            Assert.Equal("F3-25", Insulation.Insulation4PersonnelProtection(1300, 30));
            Assert.Equal("-", Insulation.Insulation4PersonnelProtection(111, 30));
        }
    }
}
