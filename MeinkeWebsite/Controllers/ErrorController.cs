using Microsoft.AspNetCore.Mvc;

public class ErrorController : Controller
{
    [Route("Error/404")]
    public IActionResult Error404()
    {
        return View("NotFound");
    }

    [Route("Error/{code}")]
    public IActionResult HandleError(int code)
    {
        if (code == 404)
            return RedirectToAction(nameof(Error404));

        return View("Error");
    }
}
