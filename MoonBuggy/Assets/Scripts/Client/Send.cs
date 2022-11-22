using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class Send : MonoBehaviour
{
    private Socket socket;

    public void SetSocket(Socket _socket)
    {
        socket = _socket;
    }

    public void Create_Lobby()
    {
        string message = @"/create_lobby\r\n\r\n";
        byte[] requestData = Encoding.UTF8.GetBytes(message);
        socket.Send(requestData);
    }

    public void Join_Lobby(int id)
    {
        string message = @$"/join_lobby {id}\r\n\r\n";
        byte[] requestData = Encoding.UTF8.GetBytes(message);
        socket.Send(requestData);
    }

    public void Lobby_List()
    {
        string message = @"/list_lobby\r\n\r\n";
        byte[] requestData = Encoding.UTF8.GetBytes(message);
        socket.Send(requestData);
    }
}
