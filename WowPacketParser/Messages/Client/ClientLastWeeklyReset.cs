using WowPacketParser.Messages.Submessages;

namespace WowPacketParser.Messages.Client
{
    public unsafe struct ClientLastWeeklyReset
    {
        public UnixTime Reset;
    }
}
