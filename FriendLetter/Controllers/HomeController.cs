using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Letter() {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient("Pavel");
      myLetterVariable.SetSender("Olga");
      myLetterVariable.SetLocation("Bucharest");
      return View(myLetterVariable);
    }

    [Route("/journal")]
    public ActionResult Journal() { return View(); }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender, string location, string souvenir)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.SetRecipient(recipient);
      myLetterVariable.SetSender(sender);
      myLetterVariable.SetLocation(location);
      myLetterVariable.SetSouvenir(souvenir);
      return View(myLetterVariable);
    }

  }
}
