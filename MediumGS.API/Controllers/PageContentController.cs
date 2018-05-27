using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MediumGS.Service.Abstract;
using MediumGS.Data.Concrete;

namespace MediumGS.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/pagecontent")]
    public class PageContentController : Controller
    {
        private readonly IPageContentService _pageContentService;

        public PageContentController(IPageContentService pageContentRepository)
        {
            _pageContentService = pageContentRepository;
        }

        // GET: api/v1/pagecontent
        [HttpGet]
        public IEnumerable<PageContent> GetAll()
        {
            return _pageContentService.GetAllPages();
        }

        // GET: api/v1/pagecontent/{id}
        [HttpGet("{id}", Name = "GetSinglePageContent")]
        public IActionResult GetSingle(int id)
        {
            PageContent page = _pageContentService.GetPage(id);

            if (page != null) return Ok(page);

            return NotFound();
        }

        // POST: api/v1/pagecontent
        [HttpPost]
        public IActionResult Create([FromBody] PageContent page)
        {
            if (page == null) return BadRequest();

            _pageContentService.AddPage(page);

            return CreatedAtRoute("GetSinglePageContent", new { id = page.Id }, page);
        }

        // PUT: api/v1/pagecontent
        [HttpPut]
        public IActionResult Update([FromBody] PageContent page)
        {
            if (page == null || page.Id == 0) return BadRequest();

            _pageContentService.UpdatePage(page);

            return NoContent();
        }

        // DELETE: api/v1/pagecontent/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _pageContentService.DeletePage(id);

            return NoContent();
        }
    }
}