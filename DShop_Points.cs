using SQLite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace DShop.Data
{
    public class DataShop_Points : ModKit.ORM.ModEntity<DataShop_Points>
    {
        [AutoIncrement][PrimaryKey] public int Id { get; set; }
        public int PatternId { get; set; }
        public string PointName { get; set; }
        public string PointPosition { get; set; }
        public Vector3 Position { get; set; }

        public DataShop_Points()
        {

        }
    }

}
