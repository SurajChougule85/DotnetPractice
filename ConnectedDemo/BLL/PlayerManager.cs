namespace BLL;
using BOL;
using DAL;
using System.Collections.Generic;

public class PlayerManager
{

public List<Player> GetManyPlayers(){
    List<Player> ply=Connected.GetAllPlayers();
    return ply;  
}

}
