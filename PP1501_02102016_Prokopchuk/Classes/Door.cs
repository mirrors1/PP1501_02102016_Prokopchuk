using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1501_02102016_Prokopchuk.Classes
{
    enum MaterialTypeDoor { Steel, Wood }
    enum IntendedType { Front, Interior }
    enum DirectionOpening { Left, Right, Symmetrical }
    /// <summary>
    /// Дверь
    /// </summary>
    class Door
    {
        /// <summary>
        /// Материал
        /// </summary>
        public MaterialTypeDoor Material { get; set; }
        /// <summary>
        /// Назначение
        /// </summary>
        public IntendedType Intended { get; set; }
        /// <summary>
        /// Направление открывания
        /// </summary>
        public DirectionOpening Open { get; set; }

    }
}
