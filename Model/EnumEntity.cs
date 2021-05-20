namespace Model
{
    public enum ServerStatusEnum
    {
        Await = 0,//预上线
        Enable = 1,//启用
        Disable = 2,//禁用
        Repair = 3,//维护
    }

    public enum UserIdentityEnum
    {
        Super = 0,//超管
        User = 1,//用户
    }

    public enum UserAndServerStatusEnum
    {
        Await = 0,//等待
        Allow = 1,//批准
        Baned = 2,//禁止
    }
}
