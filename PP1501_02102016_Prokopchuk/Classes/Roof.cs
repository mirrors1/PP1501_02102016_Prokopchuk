using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1501_02102016_Prokopchuk.Classes
{
    enum DesignType { Flat, Attic }
    enum MaterialTypeRoof { Slate , Wood, Stone, Tine }
    /// <summary>
    /// Крыша
    /// </summary>
    class Roof
    {
        /// <summary>
        /// Конструкция крыши
        /// </summary>
        public DesignType Design { get; set; }
        /// <summary>
        /// Кровельный материал
        /// </summary>
        public MaterialTypeRoof Material { get; set; }
    }
}
