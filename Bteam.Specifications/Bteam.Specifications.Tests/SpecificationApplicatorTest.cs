using Bteam.Specifications.Factories;
using Bteam.Specifications.Tests.Fakes;
using Moq;
using NUnit.Framework;

namespace Bteam.Specifications.Tests
{
    [TestFixture]
    public class SpecificationApplicatorTest
    {
        #region Setup/Teardown

        [SetUp]
        public void Setup()
        {
            specificationFactory = new Mock<ISpecificationFactory>();
            specificationFactory.Setup(f => f.GetSpecification<NombreNoEsNuloSpec, FakeEntity>()).Returns(
                new NombreNoEsNuloSpec());


            acctionCalled = false;
        }

        #endregion

        private Mock<ISpecificationFactory> specificationFactory;
        private FakeEntity fakeEntity;
        private bool acctionCalled;

        private void CuandoSeRealizaLaAccion(SpecificationApplicator specificationApplicator)
        {
            specificationApplicator.DoIfSatisfied<NombreNoEsNuloSpec, FakeEntity>(fakeEntity,
                                                                                  entity => acctionCalled = true);
        }

        [Test]
        public void DoIfSatisfiedCallActionTest()
        {
            fakeEntity = new FakeEntity {Name = "Probando"};

            var specificationApplicator = new SpecificationApplicator(specificationFactory.Object);
            FluentAssert.Test.Given(specificationApplicator)
                .When(CuandoSeRealizaLaAccion)
                .Should(() => Assert.True(acctionCalled))
                .Verify();
        }

        [Test]
        public void DoIfSatisfiedNoCallActionTest()
        {
            fakeEntity = new FakeEntity();
            var specificationApplicator = new SpecificationApplicator(specificationFactory.Object);
            FluentAssert.Test.Given(specificationApplicator)
                .When(CuandoSeRealizaLaAccion)
                .Should(() => Assert.False(acctionCalled))
                .Verify();
        }

        [Test]
        public void DoIfSatisfiedSpecDeDosEntidadesCallActionTest()
        {
            fakeEntity = new FakeEntity { Name = "Probando" };

            var specificationApplicator = new SpecificationApplicator(specificationFactory.Object);
            specificationFactory.Setup(f => f.GetSpecification<FakeSpec2, FakeEntity, FakeEntity>()).Returns(
                            new FakeSpec2());
            specificationApplicator.DoIfSatisfied<FakeSpec2, FakeEntity, FakeEntity>(fakeEntity, fakeEntity,
                                                                                     (entity, entity1) =>
                                                                                         { });

            specificationFactory.Verify(f => f.GetSpecification<FakeSpec2, FakeEntity, FakeEntity>());
        }

        [Test]
        public void DoIfSatisfiedSpecDeTresEntidadesCallActionTest()
        {
            fakeEntity = new FakeEntity { Name = "Probando" };

            var specificationApplicator = new SpecificationApplicator(specificationFactory.Object);
            specificationFactory.Setup(f => f.GetSpecification<FakeSpec3, FakeEntity, FakeEntity, FakeEntity>()).Returns(
                            new FakeSpec3());
            specificationApplicator.DoIfSatisfied<FakeSpec3, FakeEntity, FakeEntity, FakeEntity>(fakeEntity, fakeEntity, fakeEntity,
                                                                                     (entity, entity1, entity2) =>
                                                                                     { });

            specificationFactory.Verify(f => f.GetSpecification<FakeSpec3, FakeEntity, FakeEntity, FakeEntity>());
        }

        [Test]
        public void DoIfSatisfiedSpecDeCuatroEntidadesCallActionTest()
        {
            fakeEntity = new FakeEntity { Name = "Probando" };

            var specificationApplicator = new SpecificationApplicator(specificationFactory.Object);
            specificationFactory.Setup(f => f.GetSpecification<FakeSpec4, FakeEntity, FakeEntity, FakeEntity, FakeEntity>()).Returns(
                            new FakeSpec4());
            specificationApplicator.DoIfSatisfied<FakeSpec4, FakeEntity, FakeEntity, FakeEntity, FakeEntity>(fakeEntity, fakeEntity, fakeEntity, fakeEntity,
                                                                                     (entity, entity1, entity2, entity3) =>
                                                                                     { });

            specificationFactory.Verify(f => f.GetSpecification<FakeSpec4, FakeEntity, FakeEntity, FakeEntity, FakeEntity>());
        }

        [Test]
        public void DoIfSatisfiedSpecDeCincoEntidadesCallActionTest()
        {
            fakeEntity = new FakeEntity { Name = "Probando" };

            var specificationApplicator = new SpecificationApplicator(specificationFactory.Object);
            specificationFactory.Setup(f => f.GetSpecification<FakeSpec5, FakeEntity, FakeEntity, FakeEntity, FakeEntity, FakeEntity>()).Returns(
                            new FakeSpec5());
            specificationApplicator.DoIfSatisfied<FakeSpec5, FakeEntity, FakeEntity, FakeEntity, FakeEntity, FakeEntity>(fakeEntity, fakeEntity, fakeEntity, fakeEntity, fakeEntity,
                                                                                     (entity, entity1, entity2, entity3, entity5) =>
                                                                                     { });

            specificationFactory.Verify(f => f.GetSpecification<FakeSpec5, FakeEntity, FakeEntity, FakeEntity, FakeEntity, FakeEntity>());
        }
    }
}