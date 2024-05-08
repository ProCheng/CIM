using System.Windows;

namespace CIM_Client.Models;

public class FriendAdd
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Msg { get; set; }
    public string? IsReceived { get; set; }
    public bool IsReadOnly { get; set; }
    public string? CreateTime { get; set; }
}