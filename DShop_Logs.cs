using SQLite;

namespace DShop.Data
{
    public class DataShop_Logs : ModKit.ORM.ModEntity<DataShop_Logs>
    {
        [AutoIncrement][PrimaryKey] public int Id { get; set; }
        public int PointId { get; set; }
        public int ItemId { get; set; }
        public double Prix { get; set; }
        public int Quantité { get; set; }
        public bool Achetable { get; set; }
        public int CharacterId { get; set; }
        public string CharacterFullName { get; set; }
        public int BizId { get; set; }
        public int CreatedAt { get; set; }

        public DataShop_Logs()
        {
        }
    }
}
