using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1501_02102016_Prokopchuk.Classes
{
    enum MaterialTypeWindow { PVC, Wood, Aluminum }
    /// <summary>
    /// Окно
    /// </summary>
    class Window
    {
        /// <summary>
        /// Материал
        /// </summary>
        public MaterialTypeWindow Material { get; set; }
    }
}
