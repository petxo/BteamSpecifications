using Bteam.Specifications.Factories;
using Bteam.Specifications.Tests.Fakes;
using Moq;
using NUnit.Framework;

namespace Bteam.Specifications.Tests
{
    [TestFixture]
    public class SpecificationFactoryTest
    {
        private Mock<IFlyweightedFactory> _flyweightedFactory;
        private SpecificationFactory _specificationFactory;
        private NombreNoEsNuloSpec _specExpected;

        [SetUp]
        public void Setup()
        {
            _flyweightedFactory = new Mock<IFlyweightedFactory>();
            _specificationFactory = new SpecificationFactory(_flyweightedFactory.Object);
        }

        [Test]
        public void CuandoSePideUnSpecSeDevuelveElObjetoCorrecto()
        {
            var spec = _specificationFactory.GetSpecification<NombreNoEsNuloSpec, FakeEntity>();
            _flyweightedFactory.Verify(factory => factory.GetInstance<NombreNoEsNuloSpec>());
        }


        [Test]
        public void CuandoSePideUnSpecDeDosEntidadesSeDevuelveElObjetoCorrecto()
        {
            var spec = _specificationFactory.GetSpecification<FakeSpec2, FakeEntity, FakeEntity>();
            _flyweightedFactory.Verify(factory => factory.GetInstance<FakeSpec2>());
        }


        [Test]
        public void CuandoSePideUnSpecDeTresEntidadesSeDevuelveElObjetoCorrecto()
        {
            var spec = _specificationFactory.GetSpecification<FakeSpec3, FakeEntity, FakeEntity, FakeEntity>();
            _flyweightedFactory.Verify(factory => factory.GetInstance<FakeSpec3>());
        }


        [Test]
        public void CuandoSePideUnSpecDeCuatroEntidadesSeDevuelveElObjetoCorrecto()
        {
            var spec = _specificationFactory.GetSpecification<FakeSpec4, FakeEntity, FakeEntity, FakeEntity, FakeEntity>();
            _flyweightedFactory.Verify(factory => factory.GetInstance<FakeSpec4>());
        }

        [Test]
        public void CuandoSePideUnSpecDeCincoEntidadesSeDevuelveElObjetoCorrecto()
        {
            var spec = _specificationFactory.GetSpecification<FakeSpec5, FakeEntity, FakeEntity, FakeEntity, FakeEntity, FakeEntity>();
            _flyweightedFactory.Verify(factory => factory.GetInstance<FakeSpec5>());
        }

    }
}