using MediumGS.Data.Abstract;
using MediumGS.Data.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MediumGS.API.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/pagecontent")]
    public class PageContentController : Controller
    {
        private readonly IPageContentRepository _pageContentRepository;

        public PageContentController(IPageContentRepository pageContentRepository)
        {
            _pageContentRepository = pageContentRepository;
        }

        // GET: api/v1/pagecontent
        [HttpGet]
        public IEnumerable<PageContent> GetAll()
        {
            return _pageContentRepository.GetAll();
        }

        // GET: api/v1/pagecontent/{id}
        [HttpGet("{id}", Name = "GetSinglePageContent")]
        public IActionResult GetSingle(int id)
        {
            PageContent page = _pageContentRepository.GetSingle(id);

            if (page != null) return Ok(page);

            return NotFound();
        }

        // POST: api/v1/pagecontent
        [HttpPost]
        public IActionResult Create([FromBody] PageContent page)
        {
            if (page == null) return BadRequest();

            _pageContentRepository.Insert(page);

            return CreatedAtRoute("GetSinglePageContent", new { id = page.Id }, page);
        }

        // PUT: api/v1/pagecontent
        [HttpPut]
        public IActionResult Update([FromBody] PageContent page)
        {
            if (page == null || page.Id == 0) return BadRequest();

            _pageContentRepository.Update(page);

            return NoContent();
        }

        // DELETE: api/v1/pagecontent/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _pageContentRepository.Delete(id);

            return NoContent();
        }
    }
}