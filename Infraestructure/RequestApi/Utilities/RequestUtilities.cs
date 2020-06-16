using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RequestApi.Utilities
{
    public class RequestUtilities
    {
        private static readonly string url = "http://masglobaltestapi.azurewebsites.net/api/Employees";
        private static readonly HttpClient ClienteWeb = new HttpClient();
        public static async Task<string> GetRequest()
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            var response = await ClienteWeb.GetAsync(url).ConfigureAwait(false);
            var buffer = await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            return Encoding.UTF8.GetString(buffer, 0, buffer.Length);
        }
    }
}