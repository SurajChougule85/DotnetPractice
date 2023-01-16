namespace DAL;
using MySql.Data.MySqlClient;
using BOL;
using System.Collections.Generic;

public class Connected
{

public static string conString =@"server=localhost;port=3306;user=root;passward=suraj@123;database=player";

public static List<Player> GetAllPlayers(){

    List<Player> players=new List<Player>();

    using(MySqlConnection con=new MySqlConnection(conString)){

        string query="SELECT * FORM player_info";

        MySqlCommand cmd=new MySqlCommand(query,con);

        MySqlDataReader reader=cmd.ExecuteReader();

        while(reader.Read()){

            int id=int.Parse(reader["id"].ToString());
            string name=reader["name"].ToString();
            string city=reader["city"].ToString();

            Player ply=new Player{
                Id=id,
                Name=name,
                City=city
            };

            players.Add(ply);

        }

    } 
    return players;

}

}
