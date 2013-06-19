using Bteam.Specifications.Tests.Fakes;
using NUnit.Framework;

namespace Bteam.Specifications.Tests
{
    [TestFixture]
    public class CompositeSpecificationBehavior
    {
        [Test]
        public void DadasDosEspecificaciones_CrearUnAnd()
        {
            var nombreNoEstaVacioSpec = new NombreNoEstaVacioSpec();
            var nombreNoEsNuloSpec = new NombreNoEsNuloSpec();

            var andSpecification = nombreNoEstaVacioSpec.And(nombreNoEsNuloSpec);
            var fakeEntity = new FakeEntity();
            Assert.IsFalse(andSpecification.IsSatisfiedBy(fakeEntity));
        }

        [Test]
        public void DadasDosEspecificaciones_CrearUnOr()
        {
            var nombreNoEstaVacioSpec = new NombreNoEstaVacioSpec();
            var nombreNoEsNuloSpec = new NombreNoEsNuloSpec();

            var andSpecification = nombreNoEstaVacioSpec.Or(nombreNoEsNuloSpec);
            var fakeEntity = new FakeEntity();
            Assert.IsTrue(andSpecification.IsSatisfiedBy(fakeEntity));
        }

        [Test]
        public void DadasUnaEspecificacion_CrearUnNot()
        {
            var nombreNoEstaVacioSpec = new NombreNoEstaVacioSpec();

            var andSpecification = nombreNoEstaVacioSpec.Not();
            var fakeEntity = new FakeEntity();
            Assert.IsFalse(andSpecification.IsSatisfiedBy(fakeEntity));
        }

    }
}