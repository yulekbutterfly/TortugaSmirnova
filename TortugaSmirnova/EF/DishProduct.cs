//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TortugaSmirnova.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class DishProduct
    {
        public int ID { get; set; }
        public int IDProduct { get; set; }
        public int IDDish { get; set; }
    
        public virtual Dish Dish { get; set; }
        public virtual Product Product { get; set; }
    }
}
