using SQLite;
using System.Collections.Generic;

namespace DShop.Data
{
    public class DataShop_Pattern : ModKit.ORM.ModEntity<DataShop_Pattern>
    {
        [AutoIncrement][PrimaryKey] public int Id { get; set; }

        public string PatternName { get; set; }

        // Items
        public string Items { get; set; }
        [Ignore] public List<int> LItems { get; set; }

        // Entreprise Autorisé
        public bool IsBizPoint { get; set; }
        public string BizAutorisé { get; set; }
        [Ignore] public List<int> LBizAutorisé { get; set; }

    }
}
