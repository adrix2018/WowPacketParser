using System.Collections.Generic;

namespace WowPacketParser.Messages.Client
{
    public unsafe struct ClientSetAllTaskProgress
    {
        public List<ClientTaskProgress> Progress;
    }
}
