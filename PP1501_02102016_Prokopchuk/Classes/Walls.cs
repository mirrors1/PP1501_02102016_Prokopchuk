using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1501_02102016_Prokopchuk.Classes
{
    enum AppointmentType { BearingWal, InteriorWalls }
    enum MaterialsTypeWalls { Wood, Brick, Concrete }
    /// <summary>
    /// Стены
    /// </summary>    
    class Walls
    {
        /// <summary>
        /// Назначение
        /// </summary>
        public AppointmentType Appointment { get; set; }
        /// <summary>
        /// Материал
        /// </summary>
        public MaterialsTypeWalls Material { get; set; }
    }
}
