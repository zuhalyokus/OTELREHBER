using OTELREHBERISTEK.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Flurl.Http;
using Flurl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace OTELREHBERISTEK.Services
{
    public class Islemler
    {

        public async Task<bool> OtelekleAsync(string yetkiliAd, string yetkilisoyad,string firmaunvan)
        {

            
            string apiUrl = "https://localhost:7276/api/Otel";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string urlWithParameters = $"{apiUrl}?YetkiliAd={yetkiliAd}&Yetkilisoyad={yetkilisoyad}&firmaunvan={firmaunvan}";
                    HttpResponseMessage response = await client.PostAsync(urlWithParameters, null);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }
        public async Task<List<Otel>> Otellistesi()
        {
            try
            {
                string _url = "https://localhost:7276";
                var client = await _url
                    .AppendPathSegments("api", "Otel", "OtelListesi")
                    .GetAsync();

                if (client.StatusCode == 200)
                {
                    var content = await client.ResponseMessage.Content.ReadAsStringAsync();
            
                    List<Otel> oteller = JsonConvert.DeserializeObject< List<Otel>>(content).ToList();

                    return oteller;
                }

                return null;


            }
            catch (Exception)
            {

                return null;
            }


        }
        public async Task<List<Oteliletisim>> Oteliletisimlistesi(long id)
        {
            try
            {
                string _url = "https://localhost:7276";
                var client = await _url
                    .AppendPathSegments("api", "OtelIletisim", "OteliletisimListesi")
                     .SetQueryParams(new { id = id })
                     .GetAsync();

                if (client.StatusCode == 200)
                {
                    var content = await client.ResponseMessage.Content.ReadAsStringAsync();

                    List<Oteliletisim> oteliletisim = JsonConvert.DeserializeObject<List<Oteliletisim>>(content).ToList();

                    return oteliletisim;
                }

                return null;


            }
            catch (Exception)
            {

                return null;
            }


        }
        public async Task< bool> Otelsil(long id)
        {

            try
            {
                string _url = "https://localhost:7276";
                var response = await _url.AppendPathSegments("api", "Otel", "DeleteOtel")
                    .SetQueryParams(new { id = id })
                                         .DeleteAsync();
               

                if (response.StatusCode==200)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {

                return false;
            }


        }
        public async Task<bool> OtelIletisimsil(long id)
        {

            try
            {
                string _url = "https://localhost:7276";
                var response = await _url.AppendPathSegments("api", "OtelIletisim", "DeleteOtelIletisim")
                    .SetQueryParams(new { id = id })
                                         .DeleteAsync();


                if (response.StatusCode == 200)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {

                return false;
            }


        }
        public async Task<bool> OtelIletisimEkleAsync(string telefon, string email, string konum,long otelid)
        {


            string apiUrl = "https://localhost:7276/api/OtelIletisim";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string urlWithParameters = $"{apiUrl}?otelid={otelid}&Telefon={telefon}&Email={email}&Adres={konum}";
                    HttpResponseMessage response = await client.PostAsync(urlWithParameters, null);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

        }


    }
}
