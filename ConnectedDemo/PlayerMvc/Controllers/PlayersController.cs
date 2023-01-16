using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlayerMvc.Models;
using  DAL;
using BLL;
using BOL;

namespace PlayerMvc.Controllers;

public class PlayersController: Controller
{
    private readonly ILogger<PlayersController> _logger;

    public PlayersController(ILogger<PlayersController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(){

    PlayerManager newPlayer =new PlayerManager();

    List<Player> play=newPlayer.GetManyPlayers();
    this.ViewData["index"]=play;
        return View();
    }

}
