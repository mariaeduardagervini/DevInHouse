namespace Escola.API.Config
{
    public class BaseMiddleware
    {
        private readonly RequestDelegate _next;
        public BaseMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
         

            await _next(context);          

        }
    }
}