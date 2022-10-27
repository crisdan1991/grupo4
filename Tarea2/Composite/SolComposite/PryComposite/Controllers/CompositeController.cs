using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PryComposite.CompositeFiles;
using PryComposite.Data;
using PryComposite.Dto;
using PryComposite.Models;
using System;
using System.Text.Json;

namespace PryComposite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompositeController : ControllerBase
    {
        private readonly ArchivosDbContext _appDbContext;
        public CompositeController(ArchivosDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> ConsultarDirectorios()
        {
            List<FileSystem> listaFileSystem = await _appDbContext.FileSystem.Where(p=> string.IsNullOrEmpty(p.TipoArchivo)).ToListAsync();

            List<DirectoriosDtoOut> listaDirectorios = new List<DirectoriosDtoOut>();
            foreach (var item in listaFileSystem)
            {
                listaDirectorios.Add(new DirectoriosDtoOut { Id = item.Id, Nombre = item.Nombre });
            }

            return Ok(listaDirectorios);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AgregarHijo([FromBody] FileSystemDtoIn eDto)
        {
            List<FileSystem> listaComponentes = await _appDbContext.FileSystem.ToListAsync();

            Component component = eDto.EsArchivo ? new Archivo(eDto.Nombre, eDto.TipoArchivo, eDto.Tamanio) : new Carpeta(eDto.Nombre);

            FileSystem fileSystem = new FileSystem
            {
                IdPadre = eDto.IdPadre,
                Nombre = component.Nombre,
                EsArchivo = eDto.EsArchivo,
                TipoArchivo = eDto.TipoArchivo,
                Tamanio = eDto.Tamanio,
            };

            _appDbContext.FileSystem.Add(fileSystem);
            bool seGuardo = await _appDbContext.SaveChangesAsync() != 0;

            //Component dir1 = new Carpeta("dir1");

            //dir1.AgregarHijo(component);
            //dir1.AgregarHijo(dir1);

            //component.AgregarHijo(dir1);

            //Console.WriteLine($"El tamaño del directorio {dir1.Nombre} es {dir1.ObtenerTamanio}");

            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> AgregarHijoManual([FromBody] FileSystemDtoIn eDto)
        {
            Component root = new Carpeta("raiz");

            Component archivo1 = new Archivo("archivo1", "pdf", 10);
            Component archivo2 = new Archivo("archivo2.txt", "pdf", 30);
            Component archivo3 = new Archivo("archivo3.txt", "pdf", 120);
            Component archivo4 = new Archivo("archivo4.txt", "pdf", 800);
            Component archivo5 = new Archivo("archivo5.txt", "pdf", 340);

            Component archivo6 = new Archivo("archivo6.txt", "pdf", 122);
            Component archivo7 = new Archivo("archivo7.txt", "pdf", 391);


            Component dir1 = new Carpeta("dir1");
            Component dir2 = new Carpeta("dir2");
            Component dir3 = new Carpeta("dir3");

            dir1.AgregarHijo(archivo1);
            dir1.AgregarHijo(archivo6);
            dir2.AgregarHijo(archivo2);
            dir3.AgregarHijo(archivo3);
            dir3.AgregarHijo(archivo4);
            dir1.AgregarHijo(dir3);

            root.AgregarHijo(dir1);
            root.AgregarHijo(dir2);
            root.AgregarHijo(archivo5);
            root.AgregarHijo(archivo7);

            Console.WriteLine($"El tamaño del directorio {root.Nombre} es {root.ObtenerTamanio}");
            Console.WriteLine($"El tamaño del directorio {dir1.Nombre} es {dir1.ObtenerTamanio}");
            Console.WriteLine($"El tamaño del directorio {dir2.Nombre} es {dir2.ObtenerTamanio}");
            Console.WriteLine($"El tamaño del directorio {dir3.Nombre} es {dir3.ObtenerTamanio}");

            Console.ReadKey();

            return Ok();
        }
    }
}
