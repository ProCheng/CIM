namespace CIM_Client.Models;

public class Message
{
    public string? UserName { set; get; }
    public string? UserAvatar { set; get; }
    public string? Content { set; get; }
    public int Type { set; get; }
    public string? SendTime { set; get; }
}


public enum MessageType
{
    // 服务器注册消息
    Register,
    // 好友私聊
    Private,
    // 群聊
    Group,
    // 登录消息
    Login,
    // 下线消息
    Offline,
    // 好友请求消息
    Request,
    // 好友接受消息
    Receive,
    // 好友删除消息
    Delete
}
