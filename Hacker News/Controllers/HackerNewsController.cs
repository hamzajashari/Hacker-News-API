using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Hacker_News.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

[ApiController]
[Route("api/[controller]")]
public class HackerNewsController : ControllerBase
{
    private readonly HttpClient _httpClient;

    public HackerNewsController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }

    [HttpGet("news")]
    public async Task<IActionResult> GetNews(string filter = "All", string query = "", string numericFilter = "")
    {
        try
        {
            string apiUrl = "https://hn.algolia.com/api/v1/search";
            string tags = "";

            switch (filter.ToLower())
            {
                case "newest":
                    tags = "story";
                    break;
                case "hot":
                    tags = "story_";
                    break;
                case "show":
                    tags = "show_hn";
                    break;
                case "ask":
                    tags = "ask_hn";
                    break;
            }

            string queryString = $"?tags={tags}&query={query}&numericFilters={numericFilter}";

            var response = await _httpClient.GetStringAsync($"{apiUrl}{queryString}");
            var result = JsonConvert.DeserializeObject<NewsResponse>(response);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }



    //Details for news or comments by id, the Detail Model include the attribute type that can be "story","comment"...

    [HttpGet("news/{id}")]
    public async Task<IActionResult> GetNewsDetails(string id)
    {
        try
        {
            string apiUrl = $"https://hacker-news.firebaseio.com/v0/item/{id}.json";

            var response = await _httpClient.GetStringAsync(apiUrl);
            var result = JsonConvert.DeserializeObject<Item>(response);


            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
