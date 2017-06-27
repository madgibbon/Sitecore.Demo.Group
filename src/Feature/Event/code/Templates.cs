using Sitecore.Data;

namespace Sitecore.Feature.Events
{
  public struct Templates
  {
    public struct Event
    {
      public static readonly ID ID = new ID("{6A1EC59C-DC72-4312-A697-497D196C9CF0}");
      public struct Fields
      {
        public static readonly ID Title = new ID("{0E83CEF4-936E-43C6-BA2E-AB3AF65666AC}");
        public static readonly ID Description = new ID("{73C2CD52-EEFC-4D2C-A2FB-D44F75B05781}");
        public static readonly ID Date = new ID("{8C82078B-0418-49CC-9638-C2ECD90F938F}");
        public static readonly ID Venue = new ID("{6BEDCB12-69F4-430D-9ABC-DD92F32CE722}");
        public static readonly ID VenueAddress = new ID("{6FDE5325-9135-44DF-A304-76D7A12F5FD2}");
      }
    }
  }
}