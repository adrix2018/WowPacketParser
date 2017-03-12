namespace WowPacketParser.Messages.UserClient
{
    public unsafe struct UserClientAddBattlenetFriend
    {
        public uint RoleID;
        public bool VerifyOnly;
        public ulong TargetGUID;
        public ulong ClientToken;
        public uint TargetVirtualRealmAddress;
        public string InvitationMsg;
    }
}
