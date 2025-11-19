using Microsoft.AspNetCore.Mvc;

public class DownloadController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Demo()
    {
        // ? LIEN CORRECT POUR T?L?CHARGEMENT DIRECT
        string googleDriveUrl = "https://drive.google.com/uc?export=download&id=1v1d7LmwWakt5dU_0N6h0ScYvvfDrO2Uj";
        return Redirect(googleDriveUrl);
    }
}

