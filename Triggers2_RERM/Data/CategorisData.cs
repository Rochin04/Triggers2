using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Triggers2_RERM.Model;

namespace Triggers2_RERM.Data
{
    public class CategorisData
    {
        public static ObservableCollection<ModelCategoris> ShowCategoris()
        {
            return new ObservableCollection<ModelCategoris>()
            {
                new ModelCategoris()
                {
                    description = "Cena",
                   numberItem = 4512,
                   images = "https://i.ibb.co/8MrsxTb/hotel.png",
                   backgroundColor = "#EAEDF6",
                   textColor = "#00000"
                },
                new ModelCategoris()
                {
                    description = "Hotel",
                   numberItem = 4512,
                   images = "https://i.ibb.co/qkVB33C/sombrero-de-fiesta.png",
                   backgroundColor = "#EAEDF6",
                   textColor = "#00000"
                },
                new ModelCategoris()
                {
                    description = "Fiesta",
                   numberItem = 4512,
                   images = "https://i.ibb.co/Cm0HbnH/plato.png",
                   backgroundColor = "#EAEDF6",
                   textColor = "#00000"
                },
                new ModelCategoris()
                {
                    description = "Flores",
                   numberItem = 4512,
                   images = "https://i.ibb.co/vxNFNHp/flores.png",
                   backgroundColor = "#EAEDF6",
                   textColor = "#00000"
                }
            };
        }
    }
}
