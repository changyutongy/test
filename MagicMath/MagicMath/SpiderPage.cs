using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MagicMath
{
				public static class SpiderPage
				{
								public static async Task<String> GetData(string url)
								{
												using (var client = new HttpClient())
												{
																HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url, true));
																HttpResponseMessage response = client.GetAsync(request.RequestUri).Result;
																return await response.Content.ReadAsStringAsync();
												}
								}

								public static string encypt(string content)
								{
												return Microsoft.JScript.GlobalObject.escape(content);
								}
				}
}
