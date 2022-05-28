using CyclingAPILib;
using CyclingAPILib.Interface;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text;

namespace MVCCyclist.Repos
{
    public class RepoMVC : ICyclistRepo
    {
        protected string baseUrl = "https://localhost:7145/api/";

        public async Task<Cyclist> Create(Cyclist entity)
        {
            using (HttpClient client = new HttpClient())
            {
                var values = new JObject();
                values.Add("Id", entity.Id);
                values.Add("Age", entity.Age);
                values.Add("FirstName", entity.FirstName);
                values.Add("LastName", entity.LastName);
                values.Add("BirthDate", entity.BirthDate);
                values.Add("Nationality", entity.Nationality);
                values.Add("Weight", entity.EstimateWeight);
                values.Add("Height", entity.Height);

                values.Add("RY", entity.RY);
                values.Add("CO", entity.CO);
                values.Add("MO", entity.MO);
                values.Add("HIL", entity.HIL);
                values.Add("ATT", entity.ATT);
                values.Add("PR", entity.PR);
                values.Add("REC", entity.REC);
                values.Add("ACC", entity.ACC);
                values.Add("TT", entity.TT);
                values.Add("RES", entity.RES);
                values.Add("DO", entity.DO);
                values.Add("END", entity.END);
                values.Add("SP", entity.SP);


                StringContent content = new StringContent(values.ToString(), Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{baseUrl}cyclist", content);
                if (response.IsSuccessStatusCode)
                {
                    Cyclist cycl = JsonConvert.DeserializeObject<Cyclist>(response.Content.ReadAsStringAsync().Result);
                    return await Task.FromResult(cycl);
                }
                return null;
            }
        }

        public Task<Cyclist> Delete(Cyclist entity)
        {
            throw new NotImplementedException();
        }

        public Task<Cyclist> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Cyclist>> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync($"{baseUrl}cyclist");

                List<Cyclist> res = JsonConvert.DeserializeObject<List<Cyclist>>(response);

                return await Task.FromResult(res);
            }
        }

        public async Task<Cyclist> GetById(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync($"{baseUrl}cyclist/{id}");

                var res = JsonConvert.DeserializeObject<Cyclist>(response);

                return await Task.FromResult(res);
            }
        }

        public async Task<Cyclist> Update(Cyclist entity)
        {
            using (HttpClient client = new HttpClient())
            {
                var values = JsonConvert.SerializeObject(entity);

                StringContent content = new StringContent(values.ToString(), Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"{baseUrl}cyclist/{entity.Id}", content);
                if (response.IsSuccessStatusCode)
                {
                    Cyclist cycl = JsonConvert.DeserializeObject<Cyclist>(response.Content.ReadAsStringAsync().Result);
                    return cycl;
                }
                return null;
            }
        }
    }
}
