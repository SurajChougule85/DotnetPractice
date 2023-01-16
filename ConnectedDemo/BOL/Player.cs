namespace BOL;

//POJO  Class...
public class Player{

public int Id{get;set;}
public String? Name{get;set;}

public String? City{get; set;}

public Player(){

}

public Player(int id,string name,string city){
    this.Id=id;
    this.Name=name;
    this.City=city;
}


}
