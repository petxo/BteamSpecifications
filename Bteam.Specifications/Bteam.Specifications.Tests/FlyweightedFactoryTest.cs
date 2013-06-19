using Bteam.Specifications.Factories;
using Bteam.Specifications.Tests.Fakes;
using NUnit.Framework;

namespace Bteam.Specifications.Tests
{
    [TestFixture]
    public class FlyweightedFactoryTest
    {
        [Test]
        public void CreateObject()
        {
            var flyweightedFactory = new FlyweightedFactory();
            var spec = flyweightedFactory.GetInstance<NombreNoEsNuloSpec>();
            var spec2 = flyweightedFactory.GetInstance<NombreNoEsNuloSpec>();
            Assert.AreSame(spec, spec2);
        }
    }
}