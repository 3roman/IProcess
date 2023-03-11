using IThermal;
using Xunit;

namespace IThermalTests
{
    public class InsulationTests
    {
        [Fact]
        public void HeatConversationTest()
        {
            Assert.Equal("M2-114", ThermalInsulation.InsulationThickness4HeatConversation(300,330)); 
            Assert.Equal("F2-64", ThermalInsulation.InsulationThickness4HeatConversation(150,200));
            Assert.Equal("F2-51", ThermalInsulation.InsulationThickness4HeatConversation(1300, 30));
            Assert.Equal("-", ThermalInsulation.InsulationThickness4HeatConversation(111, 30));

        }

        [Fact]
        public void PersonnelProtectionTest()
        {
            Assert.Equal("M3-64", ThermalInsulation.InsulationThickness4PersonnelProtection(300, 330));
            Assert.Equal("F3-25", ThermalInsulation.InsulationThickness4PersonnelProtection(150, 200));
            Assert.Equal("F3-25", ThermalInsulation.InsulationThickness4PersonnelProtection(1300, 30));
            Assert.Equal("-", ThermalInsulation.InsulationThickness4PersonnelProtection(111, 30));

        }
    }
}
