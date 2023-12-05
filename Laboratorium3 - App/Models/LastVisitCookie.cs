namespace Laboratorium3___App.Models
{
    public class LastVisitCookie
    {
        private readonly RequestDelegate _next;
        public static readonly string CookieName = "visit";
        public static readonly string ItemKey = "lastVisit";

        public LastVisitCookie(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Cookies.ContainsKey(CookieName))
            {
                if (DateTime.TryParse(context.Request.Cookies[CookieName], out var date))
                {
                    context.Items.Add(ItemKey, date.ToString());
                }
            }
            else context.Items.Add(ItemKey, "First visit");

            context.Response.Cookies.Append(CookieName, DateTime.Now.ToString());
            await _next(context);
        }
    }
}
