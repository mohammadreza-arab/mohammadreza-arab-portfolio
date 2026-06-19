using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Data;
using Portfolio.Web.Models;

namespace Portfolio.Web.ViewComponents
{
    public class CertificateViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public CertificateViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var certificate = _context.Certificate.ToList();
            if (certificate==null)
            {
                return View(new Certificate());
            }
            return View(certificate);
        }
    }
}
