using WowPacketParser.Messages.Cli;

namespace WowPacketParser.Messages.Player
{
    public unsafe struct PlayerMoveForceFlightSpeedChangeAck
    {
        public CliMovementSpeedAck Data;
    }
}
