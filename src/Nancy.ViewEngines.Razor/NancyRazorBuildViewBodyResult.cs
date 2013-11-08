using System.Linq;
using System.Collections.Generic;

namespace Nancy.ViewEngines.Razor
{
    /// <summary>
    /// Encapsulates the result of generating the HTML body of a view, allowing the <see cref="RazorViewEngine"/>
    /// to represent the HttpStatus of the compilation process in the returned <see cref="Response"/> object.
    /// </summary>
    public class NancyRazorBuildViewBodyResult
    {
        public HttpStatusCode StatusCode { get; set; }
        public dynamic Body { get; set; }
    }
}