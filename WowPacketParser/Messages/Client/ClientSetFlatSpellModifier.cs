using System.Collections.Generic;

namespace WowPacketParser.Messages.Client
{
    public unsafe struct ClientSetFlatSpellModifier
    {
        public List<ClientSpellModifier> Modifiers;
    }
}
