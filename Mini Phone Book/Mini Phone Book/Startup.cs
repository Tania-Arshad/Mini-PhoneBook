using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mini_Phone_Book.Startup))]
namespace Mini_Phone_Book
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
