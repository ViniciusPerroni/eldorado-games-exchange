using GamesExchange.Model.Games;
using GamesExchange.Model.Identification;
using GamesExchange.Model.lib;

namespace GamesExchange.Model.Exchanges
{
    public class Exchange : BaseEntity
    {
        public Exchange()
        {
        }

        public Exchange(DateTime createDate, DateTime expectedReturnDate, long gameId, long locatorId)
        {
            CreateDate = createDate;
            ExpectedReturnDate = expectedReturnDate;
            GameId = gameId;
            LocatorId = locatorId;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime ExpectedReturnDate { get; private set; }
        public DateTime? ReturnDate { get; private set; }
        public long GameId { get; private set; }
        public virtual Game Game { get; private set; }
        public long LocatorId { get; private set; }
        public virtual Person Locator { get; private set; }

        public void RegisterReturn()
        {
            ReturnDate = DateTime.Now;
        }
    }
}
