using AppHotel.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppHotel.ViewModels
{
    public class SectionDetailViewModel
    {
        public ObservableCollection<object> Items { get; set; }

        public SectionDetailViewModel(Servicio servicio)
        {
            Items = new ObservableCollection<object>();

            // Agregar datos dependiendo del tipo de servicio
            if (servicio.Tipo == "Alojamiento")
            {
                Items.Add(new Alojamiento
                {
                    Nombre = "Habitación Deluxe",
                    Imagen = "deluxe.jpg",
                    Descripcion = "Disfruta de una estancia lujosa en nuestra Habitación Deluxe, equipada con todas las comodidades modernas y un ambiente elegante para una experiencia inolvidable."
                });

                Items.Add(new Alojamiento
                {
                    Nombre = "Suite Familiar",
                    Imagen = "familiar.jpg",
                    Descripcion = "Nuestra Suite Familiar ofrece amplios espacios y servicios diseñados para satisfacer las necesidades de toda la familia, garantizando comodidad y diversión para grandes y pequeños."
                });

                Items.Add(new Alojamiento
                {
                    Nombre = "Habitación Estándar",
                    Imagen = "estandar.jpg",
                    Descripcion = "Ideal para estancias cortas, la Habitación Estándar combina confort y funcionalidad, asegurando que disfrutes de un descanso reparador sin complicaciones."
                });
            }
            else if (servicio.Tipo == "Restaurante")
            {
                Items.Add(new Restaurante
                {
                    Nombre = "Restaurante Italiano",
                    Imagen = "resItaliano.jpg",
                    Descripcion = "Sumérgete en la auténtica cocina italiana, donde cada plato es una obra maestra hecha con ingredientes frescos y recetas tradicionales. Disfruta de un ambiente acogedor mientras saboreas nuestras pastas artesanales y deliciosas pizzas al horno de leña."
                });

                Items.Add(new Restaurante
                {
                    Nombre = "Restaurante Mexicano",
                    Imagen = "resMexicano.jpeg",
                    Descripcion = "Descubre los vibrantes sabores de México en nuestro Restaurante Mexicano. Desde tacos y enchiladas hasta guacamole fresco, cada bocado te transportará a un festín de colores y especias en un ambiente festivo y acogedor."
                });
            }
            else if (servicio.Tipo == "Bar")
            {
                Items.Add(new Bar
                {
                    Nombre = "Bar Tropical",
                    Imagen = "barTropical.jpg",
                    Descripcion = "Disfruta de una experiencia refrescante en nuestro Bar Tropical, donde los sabores exóticos de cocteles frutales y bebidas artesanales te transportarán a un paraíso tropical. Relájate en un ambiente alegre rodeado de palmeras y buena música."
                });

                Items.Add(new Bar
                {
                    Nombre = "Bar de Vinos",
                    Imagen = "barvinos.jpg",
                    Descripcion = "Explora nuestra selección de vinos finos en el Bar de Vinos, donde cada copa cuenta una historia. Ya sea que seas un conocedor o un principiante, nuestro personal estará encantado de guiarte en una experiencia de degustación inolvidable en un entorno sofisticado."
                });
            }
        }
    }
}
