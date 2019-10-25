using AzimuteLib.Log;
using HolisticusAPI2.Desconto.Application;
using HolisticusAPI2.Desconto.Application.Services;
using HolisticusAPI2.Desconto.Domain.Interfaces.Services;
using NUnit.Framework;

namespace TesteDesconto
{
    [TestFixture()]
    public class Tests
    {
        private IDescontoAppService _service;
        private IAzimuteLogger _log;

        //public Tests(IDescontoAppService service, IAzimuteLogger log)
        //{
        //    _service = service;
        //    _log = log;
        //}

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            HolisticusAPI2.Desconto.Host.Controllers.DescontoController desconto = 
                new HolisticusAPI2.Desconto.Host.Controllers.DescontoController(_service, _log);
            var retorno = desconto.VerificarDesconto(1);

            Assert.Pass();
        }
    }
}