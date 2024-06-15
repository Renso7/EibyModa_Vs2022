

using CommonModel;

namespace ApiWebPageEiby.Midleware
{
    public interface IHelperHttpContext
    {
        InfoRequest GetInfoRequest(HttpContext request);
    }
}
