using SQLite;

namespace DShop.Data
{
    public class DataShop_Items : ModKit.ORM.ModEntity<DataShop_Items>
    {
        [AutoIncrement][PrimaryKey] public int Id { get; set; }
        public int PatternId { get; set; }
        public int ItemId { get; set; }
        public double Prix { get; set; }
        public bool Vendable { get; set; }
        public bool Achetable { get; set; }

        public DataShop_Items()
        {

        }
    }
}