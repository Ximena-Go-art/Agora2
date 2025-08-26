using Service.Models;
using Service.Services;
using System.Threading.Tasks;
using Service.Models;
using Service.Services;

namespace TestAgora
{
    public class UnitTest1GenericServices
    {
        [Fact]
        public async void  TestGetAllInscripciones()
        {
            var service = new GenericServices<Inscripcion>();
            var result =  await service.GetAllAsync(null);
            Assert.NotNull(result);
            Assert.IsType<List<Inscripcion>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }
            
        }
        [Fact]
        public async void TestGetAllCapacitaciones()
        {
            var service = new GenericServices<Capacitacion>();
            var result = await service.GetAllAsync(null);
            Assert.NotNull(result);
            Assert.IsType<List<Capacitacion>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }

        }
        [Fact]
        public async void TestGetAllUsuarios()
        {
            var service = new GenericServices<Usuario>();
            var result = await service.GetAllAsync(null);
            Assert.NotNull(result);
            Assert.IsType<List<Usuario>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }

        }
        [Fact]
        public async void TestGetAllTipoInscripciones()
        {
            var service = new GenericServices<TipoInscripcion>();
            var result = await service.GetAllAsync(null);
            Assert.NotNull(result);
            Assert.IsType<List<TipoInscripcion>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }

        }
        [Fact]
        public async void TestGetAllTiposInscripcionesCapacitaciones()
        {
            var service = new GenericServices<TipoInscripcionCapacitacion>();
            var result = await service.GetAllAsync(null);
            Assert.NotNull(result);
            Assert.IsType<List<TipoInscripcionCapacitacion>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                Console.WriteLine($"Id: {item.Id}, CapacitacionID: {item.CapacitacionId}");
            }

        }
    }
}