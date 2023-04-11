using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Appreact.Models;

namespace Appreact.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReporteController : ControllerBase
    {

        [HttpGet]
        [Route("ResumenSemana")]
        public IActionResult ResumenSemana() {

            List<VMVentasUltimaSemana> listaVenta = new List<VMVentasUltimaSemana>()
            {
                new VMVentasUltimaSemana(){ fecha = "10/09/2022", total = 12 },
                new VMVentasUltimaSemana(){   fecha = "11/09/2022", total = 18 },
                new VMVentasUltimaSemana(){   fecha = "12/09/2022", total = 20 },
                new VMVentasUltimaSemana(){   fecha = "13/09/2022", total = 10 },
                new VMVentasUltimaSemana(){   fecha = "14/09/2022", total = 25 },
            };

            List<VMProductosUltimaSemana> listaProductos = new List<VMProductosUltimaSemana>()
            {
                new VMProductosUltimaSemana(){ producto = "Teclado", total = 15 },
                new VMProductosUltimaSemana(){ producto = "Monitor", total = 12 },
                new VMProductosUltimaSemana(){ producto = "Microfono", total = 10 },
                new VMProductosUltimaSemana(){ producto = "Laptop", total = 8 }
            };

            return StatusCode(StatusCodes.Status200OK, new
            {
                ventasSemana = listaVenta,
                productosSemana = listaProductos
            });

        }

    }
}
