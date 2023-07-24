namespace GamesExchange.Model.lib
{
    public class PagedResult<T> where T : BaseEntity
    {
        public int RowCount { get; set; }
        public IList<T> Rows { get; set; }
    }
}
