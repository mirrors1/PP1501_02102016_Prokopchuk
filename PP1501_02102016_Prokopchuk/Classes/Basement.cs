using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1501_02102016_Prokopchuk.Classes
{
    enum MaterialTypeBasement { Stone, Reinforced, Wood, Aerated }
    /// <summary>
    /// Фундамент
    /// </summary>
    class Basement
    {        
        /// <summary>
        /// Площадь подошвы
        /// </summary>
        public int BaseArea { get; set; }
        /// <summary>
        /// Материал
        /// </summary>
        public MaterialTypeBasement Material { get; set; }
    }
}
